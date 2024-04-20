using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models;

public class UserAccount
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime PasswordLastUpdated { get; set; } = DateTime.MinValue;
    public UserRole UserRole { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
