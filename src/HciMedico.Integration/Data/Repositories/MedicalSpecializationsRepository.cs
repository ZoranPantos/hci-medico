using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class MedicalSpecializationsRepository : BaseRepository<MedicalSpecialization>
{
    public MedicalSpecializationsRepository(AppDbContext context) : base(context)
    {
    }
}
