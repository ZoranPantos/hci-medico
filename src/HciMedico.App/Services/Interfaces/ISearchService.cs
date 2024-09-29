using HciMedico.Domain.Models;

namespace HciMedico.App.Services.Interfaces;

public interface ISearchService
{
    List<Patient>? SearchPatients(List<Patient> targetSet, string key);
    List<Appointment>? SearchTrendingAppointments(List<Appointment> targetSet, string key);
    List<HealthRecord>? SearchHealthRecords(List<HealthRecord> targetSet, string key);
}
