using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Repositories;

public class MedicalConditionsRepository : BaseRepository<MedicalCondition>
{
    public MedicalConditionsRepository(AppDbContext context) : base(context)
    {
    }
}
