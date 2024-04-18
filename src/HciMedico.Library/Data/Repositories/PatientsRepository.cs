using HciMedico.Library.Models;

namespace HciMedico.Library.Data.Repositories;

public class PatientsRepository : BaseRepository<Patient>
{
    public PatientsRepository(AppDbContext context) : base(context)
    {
    }
}
