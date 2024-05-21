using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models;

public class UserSettings
{
    public int Id { get; set; }

    public LandingPage LandingPage { get; set; }

    public int UserAccountId { get; set; }
    public UserAccount UserAccount { get; set; }
}
