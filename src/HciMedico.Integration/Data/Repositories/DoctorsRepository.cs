using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class DoctorsRepository : BaseRepository<Doctor>
{
    public DoctorsRepository(AppDbContext context) : base(context)
    {
    }
}
