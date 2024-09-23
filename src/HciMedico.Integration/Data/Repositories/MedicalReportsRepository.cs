﻿using HciMedico.Domain.Models;

namespace HciMedico.Integration.Data.Repositories;

public class MedicalReportsRepository : BaseRepository<MedicalReport>
{
    public MedicalReportsRepository(AppDbContext context) : base(context)
    {
    }
}
