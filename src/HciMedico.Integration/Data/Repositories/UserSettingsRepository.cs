using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class UserSettingsRepository : BaseRepository<UserSettings>
{
    public UserSettingsRepository(AppDbContext context) : base(context)
    {
    }
}
