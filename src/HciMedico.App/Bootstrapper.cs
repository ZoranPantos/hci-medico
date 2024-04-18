using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Helpers;
using HciMedico.App.Mappings;
using HciMedico.App.ViewModels;
using HciMedico.Library.Data;
using HciMedico.Library.Data.Repositories;
using HciMedico.Library.Models;
using HciMedico.Library.Models.DTOs;
using System.Windows;
using Wpf.Ui.Controls;

namespace HciMedico.App;

public class Bootstrapper : BootstrapperBase
{
    private readonly SimpleContainer _container = new();

    public Bootstrapper()
    {
        Initialize();

        ConventionManager
            .AddElementConvention<PasswordBox>(PasswordBoxHelper.BoundPasswordProperty, "Password", "PasswordChanged");
    }

    protected override void Configure()
    {
        base.Configure();

        _container.Instance(_container);

        // TODO: Review if these are needed, check for injecting window manager where views as windows are opened/closed
        // especially for event agregator if it is used
        // remove if not
        _container
            .Singleton<IWindowManager, WindowManager>()
            .Singleton<IEventAggregator, EventAggregator>();

        _container.Singleton<AppDbContext>();

        // Consider changing this
        // See if existing instance will be fetched or new singleton created
        _container
            .Singleton<IRepository<UserAccount>, UserAccountRepository>()
            .Singleton<IRepository<Patient>, PatientsRepository>();

        var mapperConfiguration = new MapperConfiguration(configuration => configuration.AddProfile<MappingProfile>());
        var mapper = mapperConfiguration.CreateMapper();

        _container.Instance(mapper);

        // TODO: Review if this is really needed; remove if not
        // Registering view-models for DI
        GetType().Assembly.GetTypes()
            .Where(type => type.IsClass)
            .Where(type => type.Name.EndsWith("ViewModel"))
            .ToList()
            .ForEach(vmType => _container.RegisterPerRequest(vmType, vmType.ToString(), vmType));
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