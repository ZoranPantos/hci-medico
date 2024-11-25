﻿using HciMedico.Domain.Models.Relationships;

namespace HciMedico.Domain.Models.Entities;

public class MedicalCondition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<HealthRecordMedicalCondition> HealthRecordMedicalConditions { get; set; }
    public ICollection<MedicalReport> MedicalReports { get; set; }
}
