using System.Text;
using System.Security.Cryptography;

namespace HciMedico.App.Services;

public class HashingService
{
    public static string GetHashString(string password)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

        using var sha256 = SHA256.Create();

        byte[] hashBytes = sha256.ComputeHash(passwordBytes);

        string hashedPassword = Convert.ToBase64String(hashBytes);

        return hashedPassword;
    }
}