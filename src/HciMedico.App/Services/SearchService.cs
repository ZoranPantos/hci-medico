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
}
