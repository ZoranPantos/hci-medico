using System.Net.Mail;
using System.Text.RegularExpressions;

namespace HciMedico.App.Validation;

public class InputValidator : IInputValidator
{
    // Used for country, city or street name
    public bool IsRegionalNameValid(string input)
    {
        string pattern = @"^(?!\s)(?!.*\s$)[a-zA-Z0-9čćšžđČĆŠŽĐ\u0400-\u04FF\u0500-\u052F\u2DE0-\u2DFF\uA640-\uA69F\u1C80-\u1C8F\s]+$";
        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    // Checks if date of birth is realistic for registered person today
    public bool IsDateOfBirthValid(DateTime input) =>
        input.CompareTo(new DateTime(1920, 1, 1)) >= 0 && input.CompareTo(DateTime.Now.Date) <= 0;

    public bool IsEmailValid(string input)
    {
        try
        {
            var mailAddress = new MailAddress(input);

            return mailAddress.Address.Equals(input);
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool IsPersonNameValid(string input)
    {
        string pattern = @"^[^\p{C}\s]+(?:\s+[^\p{C}\s]+)*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsPhoneNumberValid(string input)
    {
        string pattern = @"^\s*(?:\+?([1-9]\d{1,14}))?(?! )[-\.]?(\d{3})[-\.]?(\d{3})(?!\s)$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsStreetNumberValid(string input)
    {
        string pattern = "^(?![a-zA-Z]+$)[a-zA-Z0-9]*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(input);
    }

    public bool IsUidValid(string input) => input.All(Char.IsDigit);
}
