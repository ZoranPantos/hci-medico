namespace HciMedico.App.Validation;

public interface IInputValidator
{
    bool IsPersonNameValid(string input);
    bool IsRegionalNameValid(string input);
    bool IsStreetNumberValid(string input);
    bool IsPhoneNumberValid(string input);
    Task<bool> IsUidValid(string input, int patientId, bool editState);
    bool IsEmailValid(string input);
    bool IsDateOfBirthValid(DateTime input);
}
