using Caliburn.Micro;
using HciMedico.App.Services;
using HciMedico.Domain.Models;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.Shared;

public class UpdatePasswordViewModel : Conductor<object>
{
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

    public bool CanSave(string oldPassword, string newPassword, string confirmedNewPassword) =>
        oldPassword.Length >= 6 && oldPassword.Length <= 20 &&
        newPassword.Length >= 6 && newPassword.Length <= 20 &&
        confirmedNewPassword.Length >= 6 && confirmedNewPassword.Length <= 20;

    public async Task Save(string oldPassword, string newPassword, string confirmedNewPassword)
    {
        try
        {
            string currentPasswordHash = UserContext.CurrentUser!.Password;
            string oldPasswordHash = HashingService.GetHashString(oldPassword);

            if (!oldPasswordHash.Equals(currentPasswordHash))
            {
                ValidationMessage = "Incorrect old password";
                return;
            }

            if (!confirmedNewPassword.Equals(newPassword))
            {
                ValidationMessage = "Confirmed password does not match initial password";
                return;
            }

            if (newPassword.Length < 6 || newPassword.Length > 20)
            {
                ValidationMessage = "New password does not respect intended length range";
                return;
            }

            string newPasswordHash = HashingService.GetHashString(newPassword);

            if (newPasswordHash.Equals(currentPasswordHash))
            {
                ValidationMessage = "This password is already in use";
                return;
            }

            //TODO: Consider moving this to constructor injection
            var userAccountRepository = IoC.Get<IRepository<UserAccount>>();

            var currentUserAccount = await userAccountRepository.GetByIdAsync(UserContext.CurrentUser.Id) ??
                throw new Exception("Fetched user account was null");

            currentUserAccount.Password = newPasswordHash;
            currentUserAccount.PasswordLastUpdated = DateTime.Now;

            await userAccountRepository.Update(currentUserAccount);

            UserContext.Initialize(currentUserAccount);

            await TryCloseAsync();
        }
        catch (Exception)
        {

        }
    }

    public async Task Cancel()
    {
        await TryCloseAsync();
    }
}