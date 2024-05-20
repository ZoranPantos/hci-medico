﻿using AutoMapper;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Domain.Models.Enums;

namespace HciMedico.App.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Patient, TreatedPatientDisplayModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.HealthRecord.DateOfBirth))
            .ForMember(dest => dest.NumberOfVisits, opt => opt.MapFrom(src => GetResolvedAppointmentsCount(src)));

        CreateMap<Appointment, TreatedPatientAppointmentDisplayModel>()
            .ForMember(dest => dest.DateAndTime, opt => opt.MapFrom(src => src.DateAndTime))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.GetName(typeof(AppointmentStatus), src.Status)))
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => Enum.GetName(typeof(AppointmentType), src.Type)));

        CreateMap<Patient, PatientDisplayModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
            .ForMember(dest => dest.LastVisit, opt => opt.MapFrom(src => GetDateTimeForLastResolvedAppointmentOfPatient(src)));
    }

    private static int GetResolvedAppointmentsCount(Patient patient) =>
        patient.Appointments.Count(appointment => appointment.Status == AppointmentStatus.Resolved);

    private static DateTime? GetDateTimeForLastResolvedAppointmentOfPatient(Patient patient)
    {
        if (patient.Appointments is null || patient.Appointments.Count == 0)
            return null;

        return patient.Appointments
            .Where(appointment => appointment.Status == AppointmentStatus.Resolved)
            .Select(appointment => appointment.DateAndTime)
            .Max();
    }
}