using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Repositories;

public class HealthRecordsRepository : BaseRepository<HealthRecord>
{
    public HealthRecordsRepository(AppDbContext context) : base(context)
    {
    }
}
