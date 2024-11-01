using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.Shared;

public class UpdatePasswordViewModel : Conductor<object>
{
    private readonly IHashingService _hashingService;
    private readonly IToastNotificationService _toastNotificationService;

    public string Note => UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
        "Password length must be at least 6 and at most 20 characters" :
        "Dužina lozinke mora biti najmanje 6 i najviše 20 karaktera";

    private string _oldPassword = string.Empty;
    public string OldPassword
    {
        get => _oldPassword;
        set
        {
            _oldPassword = value;
            NotifyOfPropertyChange(() => OldPassword);
        }
    }

    private string _newPassword = string.Empty;
    public string NewPassword
    {
        get => _newPassword;
        set
        {
            _newPassword = value;
            NotifyOfPropertyChange(() => NewPassword);
        }
    }

    private string _confirmedNewPassword = string.Empty;
    public string ConfirmedNewPassword
    {
        get => _confirmedNewPassword;
        set
        {
            _confirmedNewPassword = value;
            NotifyOfPropertyChange(() => ConfirmedNewPassword);
        }
    }

    private string _validationMessage = string.Empty;
    public string ValidationMessage
    {
        get => _validationMessage;
        set
        {
            _validationMessage = value;
            NotifyOfPropertyChange(() => ValidationMessage);
        }
    }

    public UpdatePasswordViewModel(IHashingService hashingService, IToastNotificationService toastNotificationService)
    {
        _hashingService = hashingService ?? throw new ArgumentNullException(nameof(hashingService));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
    }

    public bool CanSave(string oldPassword, string newPassword, string confirmedNewPassword) =>
        oldPassword.Length >= 6 && oldPassword.Length <= 20 &&
        newPassword.Length >= 6 && newPassword.Length <= 20 &&
        confirmedNewPassword.Length >= 6 && confirmedNewPassword.Length <= 20;

    public async Task Save(string oldPassword, string newPassword, string confirmedNewPassword)
    {
        try
        {
            string currentPasswordHash = UserContext.CurrentUser!.Password;
            string oldPasswordHash = _hashingService.GetHashString(oldPassword);

            if (!oldPasswordHash.Equals(currentPasswordHash))
            {
                ValidationMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                    "Incorrect old password" :
                    "Neispravna stara lozinka";

                return;
            }

            if (!confirmedNewPassword.Equals(newPassword))
            {
                ValidationMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                    "Confirmed password does not match initial password" :
                    "Potvrđena lozinka ne odgovara inicijalnoj lozinci";

                return;
            }

            if (newPassword.Length < 6 || newPassword.Length > 20)
            {
                ValidationMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                    "New password does not respect intended length range" :
                    "Nova lozinka ne poštuje pravila za dužinu";

                return;
            }

            string newPasswordHash = _hashingService.GetHashString(newPassword);

            if (newPasswordHash.Equals(currentPasswordHash))
            {
                ValidationMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                    "This password is already in use" :
                    "Lozinka je već u upotrebi";

                return;
            }

            var userAccountRepository = IoC.Get<IRepository<UserAccount>>();

            var currentUserAccount = await userAccountRepository.GetByIdAsync(UserContext.CurrentUser.Id) ??
                throw new Exception("Fetched user account was null");

            currentUserAccount.Password = newPasswordHash;
            currentUserAccount.PasswordLastUpdated = DateTime.Now;

            await userAccountRepository.Update(currentUserAccount);

            UserContext.Initialize(currentUserAccount);

            await TryCloseAsync();

            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Password updated" :
                "Lozinka ažurirana";

            _toastNotificationService.ShowSuccess(toastMessage);
        }
        catch (Exception ex)
        {
            ValidationMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Failed to update password" :
                "Ažuriranje lozinke neuspješno";

            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Update failed" :
                "Ažuriranje neuspješno";

            _toastNotificationService.ShowError(toastMessage);

            string message = $"Exception caught and rethrown in {nameof(UpdatePasswordViewModel)}.{nameof(Save)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}