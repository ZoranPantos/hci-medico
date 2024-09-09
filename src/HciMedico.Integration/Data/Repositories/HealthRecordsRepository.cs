using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class HealthRecordsRepository : BaseRepository<HealthRecord>
{
    public HealthRecordsRepository(AppDbContext context) : base(context)
    {
    }
}
