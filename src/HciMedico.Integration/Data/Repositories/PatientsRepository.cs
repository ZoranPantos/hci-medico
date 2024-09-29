using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Repositories;

public class PatientsRepository : BaseRepository<Patient>
{
    public PatientsRepository(AppDbContext context) : base(context)
    {
    }
}
