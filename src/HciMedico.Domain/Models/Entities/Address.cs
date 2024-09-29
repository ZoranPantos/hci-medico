namespace HciMedico.Domain.Models.Entities;

public class Address
{
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public int Number { get; set; }
}
