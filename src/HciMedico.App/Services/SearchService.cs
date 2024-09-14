using HciMedico.Domain.Models;
using System.Text.RegularExpressions;

namespace HciMedico.App.Services;

public class SearchService : ISearchService
{
    public List<Patient>? SearchPatients(List<Patient> targetSet, string key)
    {
        ArgumentNullException.ThrowIfNull(targetSet);

        var foundPatients = new List<Patient>();

        key = key.Trim();

        if (!string.IsNullOrEmpty(key))
        {
            key = Regex.Replace(key, @"\s+", " ");

            string[] queryPartitions = key.Split(" ");

            if (queryPartitions.Length == 2)
            {
                foundPatients = targetSet
                    .Where(patient =>
                        (patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                        (patient.FirstName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }

            if (!foundPatients.Any())
            {
                foundPatients = targetSet
                    .Where(patient => queryPartitions
                        .Any(partition =>
                            patient.FirstName.StartsWith(partition, StringComparison.OrdinalIgnoreCase) ||
                            patient.LastName.StartsWith(partition, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }
        }
        else
            foundPatients = targetSet;

        return foundPatients;
    }

    public List<Appointment>? SearchTrendingAppointments(List<Appointment> targetSet, string key)
    {
        ArgumentNullException.ThrowIfNull(targetSet);

        var foundAppointments = new List<Appointment>();

        key = key.Trim();

        if (!string.IsNullOrEmpty(key))
        {
            key = Regex.Replace(key, @"\s+", " ");

            string[] queryPartitions = key.Split(" ");

            if (queryPartitions.Length == 2)
            {
                foundAppointments = targetSet
                    .Where(appointment =>
                    {
                        var patient = appointment.Patient;

                        if (patient is not null)
                        {
                            return (patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                                patient.LastName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                                (patient.FirstName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                                patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase));
                        }

                        if (!string.IsNullOrEmpty(appointment.IdentifierName))
                        {
                            string[]? identifierPartitions = !string.IsNullOrEmpty(appointment.IdentifierName) ? appointment.IdentifierName.Split(" ") : null;

                            if (identifierPartitions is null)
                                return false;

                            if (identifierPartitions.Length != 2)
                            {
                                return identifierPartitions[0].StartsWith(queryPartitions[0], StringComparison.OrdinalIgnoreCase) ||
                                    identifierPartitions[1].StartsWith(queryPartitions[0], StringComparison.OrdinalIgnoreCase);
                            }

                            return (queryPartitions[0].Equals(identifierPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                                queryPartitions[1].Equals(identifierPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                                (queryPartitions[0].Equals(identifierPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                                queryPartitions[1].Equals(identifierPartitions[0], StringComparison.OrdinalIgnoreCase));
                        }

                        return false;
                    })
                    .ToList();
            }

            if (!foundAppointments.Any())
            {
                foundAppointments = targetSet
                    .Where(appointment =>
                    {
                        if (appointment.Patient is not null)
                        {
                            return queryPartitions.Any(partition =>
                                appointment.Patient.FirstName.StartsWith(partition, StringComparison.OrdinalIgnoreCase) ||
                                appointment.Patient.LastName.StartsWith(partition, StringComparison.OrdinalIgnoreCase));
                        }

                        return queryPartitions.Any(partition =>
                            appointment.IdentifierName.StartsWith(partition, StringComparison.OrdinalIgnoreCase));
                    })
                    .ToList();
            }
        }
        else
            foundAppointments = targetSet;

        return foundAppointments;
    }

    public List<HealthRecord>? SearchHealthRecords(List<HealthRecord> targetSet, string key)
    {
        ArgumentNullException.ThrowIfNull(targetSet);

        var foundHealthRecords = new List<HealthRecord>();

        key = key.Trim();

        if (!string.IsNullOrEmpty(key))
        {
            key = Regex.Replace(key, @"\s+", " ");

            string[] queryPartitions = key.Split(" ");

            if (queryPartitions.Length == 1)
            {
                foundHealthRecords = targetSet.Where(healthRecord =>
                {
                    var patient = healthRecord.Patient;

                    if (patient is not null)
                    {
                        return (patient.Uid.Equals(queryPartitions[0]) ||
                            patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) ||
                            patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase));
                    }

                    return false;
                })
                .ToList();
            }

            if (queryPartitions.Length == 2)
            {
                foundHealthRecords = targetSet.Where(healthRecord =>
                {
                    var patient = healthRecord.Patient;

                    if (patient is not null)
                    {
                        return (patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                            patient.LastName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                            (patient.FirstName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                            patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase));
                    }

                    return false;
                })
                .ToList();
            }
        }
        else
            foundHealthRecords = targetSet;

        return foundHealthRecords;
    }
}
