using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class AppointmentsRepository : BaseRepository<Appointment>
{
    public AppointmentsRepository(AppDbContext context) : base(context)
    {
    }
}
