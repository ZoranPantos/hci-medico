using HciMedico.Library.Models.Enums;

namespace HciMedico.Library.Models;

public class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Uid { get; set; } = string.Empty;
    public string Education { get; set; } = string.Empty;

    public Gender Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Address Address { get; set; } = new();
    public ContactInfo Contact { get; set; } = new();

    public UserAccount UserAccount { get; set; } = new();
}
