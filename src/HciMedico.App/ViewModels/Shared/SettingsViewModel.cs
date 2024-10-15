﻿using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.Shared;

public class SettingsViewModel : Conductor<object>
{
    private readonly IWindowManager _windowManager;
    private readonly IRepository<UserSettings> _userSettingsRepository;
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

    public SettingsViewModel(IWindowManager windowManager, IRepository<UserSettings> userSettingsRepository)
    {
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
        _userSettingsRepository = userSettingsRepository ?? throw new ArgumentNullException(nameof(userSettingsRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        if (UserContext.CurrentUser is not null)
            _currentUserSettings = await _userSettingsRepository.FindAsync(setting => setting.UserAccountId == UserContext.CurrentUser.Id);

        if (_currentUserSettings is not null)
        SelectedLandingPage = _currentUserSettings.LandingPage;
    }

    public async Task UpdatePassword() => await _windowManager.ShowDialogAsync(new UpdatePasswordViewModel(IoC.Get<IHashingService>()));

    //Will be called after the corresponding property setter is executed
    public async Task OnLandingPageSelectionChanged()
    {
        if (_currentUserSettings is null) return;

        try
        {
            _currentUserSettings.LandingPage = _selectedLandingPage;
            await _userSettingsRepository.Update(_currentUserSettings);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(SettingsViewModel)}.{nameof(OnLandingPageSelectionChanged)}";
            throw new MedicoException(message, ex);
        }
    }
}
