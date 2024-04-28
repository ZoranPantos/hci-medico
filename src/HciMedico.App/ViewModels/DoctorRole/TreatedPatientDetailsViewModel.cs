using Caliburn.Micro;
using HciMedico.Domain.Models;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class TreatedPatientDetailsViewModel : Conductor<object>
{
    private int _id;
    private readonly IRepository<Patient> _patientRepository;

    private string _firstName = string.Empty;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            NotifyOfPropertyChange(() => FirstName);
        }
    }

    private string _lastName = string.Empty;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            NotifyOfPropertyChange(() => LastName);
        }
    }

    private string _placeOfResidence = string.Empty;
    public string PlaceOfResidence
    {
        get => _placeOfResidence;
        set
        {
            _placeOfResidence = value;
            NotifyOfPropertyChange(() => PlaceOfResidence);
        }
    }

    private string _email = string.Empty;
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            NotifyOfPropertyChange(() => Email);
        }
    }

    private string _telephoneNumber = string.Empty;
    public string TelephoneNumber
    {
        get => _telephoneNumber;
        set
        {
            _telephoneNumber = value;
            NotifyOfPropertyChange(() => TelephoneNumber);
        }
    }

    public TreatedPatientDetailsViewModel(int id, IRepository<Patient> patientRepository)
    {
        _id = id;
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var treatedPatient = await _patientRepository.FindAsync(patient => patient.Id == _id, true, "Appointments,HealthRecord");

            FirstName = treatedPatient?.FirstName ?? "No data available";
            LastName = treatedPatient?.LastName ?? "No data available";

            PlaceOfResidence = treatedPatient is not null ?
                $"{treatedPatient.Address.City}, {treatedPatient.Address.Country}" : "No data available";

            Email = treatedPatient?.ContactInfo.Email ?? "No data available";
            TelephoneNumber = treatedPatient?.ContactInfo.TelephoneNumber ?? "No data available";
        }
        catch (Exception)
        {

        }
    }
}
