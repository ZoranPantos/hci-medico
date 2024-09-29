using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Repositories;

public class MedicalSpecializationsRepository : BaseRepository<MedicalSpecialization>
{
    public MedicalSpecializationsRepository(AppDbContext context) : base(context)
    {
    }
}
