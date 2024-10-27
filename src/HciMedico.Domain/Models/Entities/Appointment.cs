using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models.Entities;

public class Appointment
{
    public int Id { get; set; }

    public DateTime DateAndTime { get; set; }
    public DateTime CreationTime { get; set; }

    public DateOnly Date => DateOnly.FromDateTime(DateAndTime);
    public TimeOnly Time => TimeOnly.FromDateTime(DateAndTime);

    public AppointmentStatus Status { get; set; }
    public AppointmentType Type { get; set; }

    public int? HealthRecordId { get; set; }
    public HealthRecord? HealthRecord { get; set; }

    public int DoctorId { get; set; }
    public Doctor AssignedTo { get; set; }

    public int CounterWorkerId { get; set; }
    public CounterWorker CreatedBy { get; set; }

    public int? PatientId { get; set; }
    public Patient? Patient { get; set; }
    public string IdentifierName { get; set; } = string.Empty;

    public MedicalReport MedicalReport { get; set; }
}
