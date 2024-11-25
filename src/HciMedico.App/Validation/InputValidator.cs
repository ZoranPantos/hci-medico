﻿using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;
using System.Text.RegularExpressions;

namespace HciMedico.App.Validation;

public class InputValidator : IInputValidator
{
    private readonly IRepository<Patient> _patientsRepository;

    public InputValidator(IRepository<Patient> patientsRepository) =>
        _patientsRepository = patientsRepository ?? throw new ArgumentNullException(nameof(patientsRepository));

    // Used for country, city or street name
    public bool IsRegionalNameValid(string input)
    {
        string pattern = @"^[\p{L}]+(?: [\p{L}]+)*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    // Checks if date of birth is realistic for registered person today
    public bool IsDateOfBirthValid(DateTime input) =>
        input.CompareTo(new DateTime(1920, 1, 1)) >= 0 && input.CompareTo(DateTime.Today) <= 0;

    public bool IsEmailValid(string input)
    {
        string pattern = @"^[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?)*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsPersonNameValid(string input)
    {
        string pattern = @"^(?! )[ \p{L}\'\-]+(?<! )$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsPhoneNumberValid(string input)
    {
        string pattern = @"^\+?[\d\s]*\d{6,11}$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsStreetNumberValid(string input)
    {
        string pattern = @"^[a-zA-Z]?[0-9]+[a-zA-Z0-9]?$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public async Task<bool> IsUidValid(string input, int patientId, bool editState)
    {
        bool isInDigits = input.All(Char.IsDigit);

        if (!editState) return isInDigits;

        var patient = await _patientsRepository.FindAsync(patient => patient.Uid.Equals(input) && patient.Id != patientId);
        var isUidInUse = patient is not null;

        return isInDigits && !isUidInUse;
    }
}
