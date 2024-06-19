using System.Text;
using System.Security.Cryptography;

namespace HciMedico.App.Services;

public class HashingService : IHashingService
{
    public string GetHashString(string input)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(input);

        using var sha256 = SHA256.Create();

        byte[] hashBytes = sha256.ComputeHash(passwordBytes);

        string hashedPassword = Convert.ToBase64String(hashBytes);

        return hashedPassword;
    }
}