namespace HciMedico.App.Validation;

public interface IInputValidator
{
    bool IsPersonNameValid(string input);
    bool IsRegionalNameValid(string input);
    bool IsStreetNumberValid(string input);
    bool IsPhoneNumberValid(string input);
    bool IsUidValid(string input);
    bool IsEmailValid(string input);
    bool IsDateOfBirthValid(DateTime input);
}
