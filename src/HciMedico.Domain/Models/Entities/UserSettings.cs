using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models.Entities;

public class UserSettings
{
    public int Id { get; set; }

    public LandingPage LandingPage { get; set; }
    public ApplicationLanguage ApplicationLanguage { get; set; }

    public int UserAccountId { get; set; }
    public UserAccount UserAccount { get; set; }
}
