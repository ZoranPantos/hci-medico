using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class UserAccountRepository : BaseRepository<UserAccount>
{
    public UserAccountRepository(AppDbContext context) : base(context)
    {
    }
}
