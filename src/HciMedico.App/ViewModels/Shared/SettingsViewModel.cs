﻿using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Classes;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.Shared;

public class SettingsViewModel : Conductor<object>
{
    private readonly IWindowManager _windowManager;
    private readonly IRepository<UserSettings> _userSettingsRepository;
    private readonly IToastNotificationService _toastNotificationService;
    private UserSettings? _currentUserSettings = null;

    public LandingPage[] LandingPageOptions { get; } = Enum.GetValues<LandingPage>();

    private LandingPage _selectedLandingPage;
    public LandingPage SelectedLandingPage
    {
        get => _selectedLandingPage;
        set
        {
            _selectedLandingPage = value;
            NotifyOfPropertyChange(() => SelectedLandingPage);
        }
    }

    public ApplicationLanguage[] ApplicationLanguageOptions { get; } = Enum.GetValues<ApplicationLanguage>();

    private ApplicationLanguage _selectedApplicationLanguage;
    public ApplicationLanguage SelectedApplicationLanguage
    {
        get => _selectedApplicationLanguage;
        set
        {
            _selectedApplicationLanguage = value;
            NotifyOfPropertyChange(() => SelectedApplicationLanguage);
        }
    }

    public SettingsViewModel(
        IWindowManager windowManager,
        IRepository<UserSettings> userSettingsRepository,
        IToastNotificationService toastNotificationService)
    {
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
        _userSettingsRepository = userSettingsRepository ?? throw new ArgumentNullException(nameof(userSettingsRepository));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        if (UserContext.CurrentUser is not null)
            _currentUserSettings = await _userSettingsRepository.FindAsync(setting => setting.UserAccountId == UserContext.CurrentUser.Id);

        if (_currentUserSettings is not null)
        {
            SelectedLandingPage = _currentUserSettings.LandingPage;
            SelectedApplicationLanguage = _currentUserSettings.ApplicationLanguage;
        }
    }

    public async Task UpdatePassword() =>
        await _windowManager.ShowDialogAsync(new UpdatePasswordViewModel(IoC.Get<IHashingService>(), _toastNotificationService));

    // Will be called after the corresponding property setter is executed
    public async Task OnLandingPageSelectionChanged()
    {
        if (_currentUserSettings is null) return;

        try
        {
            _currentUserSettings.LandingPage = _selectedLandingPage;
            await _userSettingsRepository.Update(_currentUserSettings);

            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Landing page updated" :
                "Početna strana podešena";

            _toastNotificationService.ShowSuccess(toastMessage);
        }
        catch (Exception ex)
        {
            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Update failed" :
                "Ažuriranje neuspješno";

            _toastNotificationService.ShowError(toastMessage);

            string message = $"Exception caught and rethrown in {nameof(SettingsViewModel)}.{nameof(OnLandingPageSelectionChanged)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task OnApplicationLanguageSelectionChanged()
    {
        if (_currentUserSettings is null) return;

        try
        {
            _currentUserSettings.ApplicationLanguage = SelectedApplicationLanguage;
            await _userSettingsRepository.Update(_currentUserSettings);

            LanguageManager.SetLanguage(SelectedApplicationLanguage);

            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Application language updated" :
                "Jezik aplikacije ažuriran";

            _toastNotificationService.ShowSuccess(toastMessage);
        }
        catch (Exception ex)
        {
            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Update failed" :
                "Ažuriranje neuspješno";

            _toastNotificationService.ShowError(toastMessage);

            string message = $"Exception caught and rethrown in {nameof(SettingsViewModel)}.{nameof(OnApplicationLanguageSelectionChanged)}";
            throw new MedicoException(message, ex);
        }
    }
}
