using HciMedico.Library.Models;

namespace HciMedico.Library.Data.Repositories;

public class UserAccountRepository : BaseRepository<UserAccount>
{
    public UserAccountRepository(AppDbContext context) : base(context)
    {
    }
}
