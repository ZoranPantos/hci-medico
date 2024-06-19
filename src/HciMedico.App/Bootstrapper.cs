using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Helpers;
using HciMedico.App.Mappings;
using HciMedico.App.Services;
using HciMedico.App.Validation;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Integration.Data;
using HciMedico.Integration.Data.Repositories;
using System.Windows;
using Wpf.Ui.Controls;

namespace HciMedico.App;

public class Bootstrapper : BootstrapperBase
{
    private readonly SimpleContainer _container = new();

    public Bootstrapper() => Initialize();

    protected override void Configure()
    {
        base.Configure();

        _container.Instance(_container);

        _container.Singleton<IWindowManager, WindowManager>();

        _container.Singleton<AppDbContext>();

        _container
            .Singleton<IRepository<UserAccount>, UserAccountRepository>()
            .Singleton<IRepository<Patient>, PatientsRepository>()
            .Singleton<IRepository<MedicalCondition>, MedicalConditionsRepository>()
            .Singleton<IRepository<UserSettings>, UserSettingsRepository>()
            .Singleton<IRepository<Appointment>, AppointmentsRepository>()
            .Singleton<IRepository<Doctor>, DoctorsRepository>()
            .Singleton<IRepository<MedicalSpecialization>, MedicalSpecializationsRepository>();

        _container
            .Singleton<IInputValidator, InputValidator>()
            .Singleton<ISearchService, SearchService>()
            .Singleton<IHashingService, HashingService>();

        var mapperConfiguration = new MapperConfiguration(configuration => configuration.AddProfile<MappingProfile>());
        var mapper = mapperConfiguration.CreateMapper();

        _container.Instance(mapper);

        // Registering view-models for DI
        GetType().Assembly.GetTypes()
            .Where(type => type.IsClass)
            .Where(type => type.Name.EndsWith("ViewModel"))
            .ToList()
            .ForEach(vmType => _container.RegisterPerRequest(vmType, vmType.ToString(), vmType));

        ConventionManager
            .AddElementConvention<PasswordBox>(PasswordBoxHelper.BoundPasswordProperty, "Password", "PasswordChanged");
    }

    protected override async void OnStartup(object sender, StartupEventArgs e)
    {
        Application.Current.ShutdownMode = ShutdownMode.OnExplicitShutdown;

        await DisplayRootViewForAsync(typeof(LoginViewModel));
    }

    protected override object GetInstance(Type serviceType, string key) => _container.GetInstance(serviceType, key);

    protected override IEnumerable<object> GetAllInstances(Type serviceType) => _container.GetAllInstances(serviceType);

    protected override void BuildUp(object instance) => _container.BuildUp(instance);
}