using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Repositories;

public class AppointmentsRepository : BaseRepository<Appointment>
{
    public AppointmentsRepository(AppDbContext context) : base(context)
    {
    }
}
