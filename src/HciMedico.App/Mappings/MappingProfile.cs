using AutoMapper;
using HciMedico.Library.Models.DTOs;
using HciMedico.Library.Models;
using HciMedico.Library.Models.Enums;

namespace HciMedico.App.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Patient, TreatedPatientDto>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.HealthRecord.DateOfBirth))
            .ForMember(dest => dest.NumberOfVisits, opt => opt.MapFrom(src => GetResolvedAppointmentsCount(src)));
    }

    private static int GetResolvedAppointmentsCount(Patient patient) =>
        patient.Appointments.Count(a => a.Status == AppointmentStatus.Resolved);
}
