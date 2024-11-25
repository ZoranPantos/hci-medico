﻿using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;
using HciMedico.Domain.Models.Enums;
using HciMedico.App.Exceptions;
using System.Configuration;

namespace HciMedico.App.Services.Classes;

public class TimeSlotDetectionService : ITimeSlotDetectionService
{
    private readonly string _shiftStartHour = ConfigurationManager.AppSettings["ShiftStartHour"] ?? "8";
    private readonly string _shiftEndHour = ConfigurationManager.AppSettings["ShiftEndHour"] ?? "16";
    private readonly string _shiftStartMinutes = ConfigurationManager.AppSettings["ShiftStartMinutes"] ?? "0";
    private readonly string _shiftEndMinutes = ConfigurationManager.AppSettings["ShiftStartMinutes"] ?? "0";
    private readonly string _defaultAppointmentDuration = ConfigurationManager.AppSettings["DefaultAppointmentDurationInMinutes"] ?? "15";
    private readonly string _inBetweenAppointmentsBreak = ConfigurationManager.AppSettings["InBetweenAppointmentsBreak"] ?? "5";

    private readonly IRepository<Appointment> _appointmentRepository;
    public TimeSpan DefaultAppointmentDuration { get; }
    public TimeSpan InBetweenAppointmentsBreak { get; }
    public TimeOnly StartShift { get; }
    public TimeOnly EndShift { get; }

    public TimeSlotDetectionService(IRepository<Appointment> appointmentRepository)
    {
        _appointmentRepository = appointmentRepository ?? throw new ArgumentNullException(nameof(appointmentRepository));

        DefaultAppointmentDuration = new(0, int.Parse(_defaultAppointmentDuration), 0);
        InBetweenAppointmentsBreak = new(0, int.Parse(_inBetweenAppointmentsBreak), 0);
        StartShift = new(int.Parse(_shiftStartHour), int.Parse(_shiftStartMinutes));
        EndShift = new(int.Parse(_shiftEndHour), int.Parse(_shiftEndMinutes));
    }

    public async Task<ICollection<TimeOnly>> GetTimeSlotsByDate(DateTime appointmentDateTime, Doctor? assignedTo)
    {
        try
        {
            var resultTimes = new List<TimeOnly>();

            if (assignedTo is null) return resultTimes;

            var time = appointmentDateTime.Date == DateTime.Today.Date ? TimeOnly.FromDateTime(DateTime.Now) : StartShift;

            // Calculate the additional minutes needed to reach the next multiple of 5, e.g. if the time is 08:43:11, round it to 08:45:00
            int minutesToAdd = 5 - (time.Minute % 5);
            if (minutesToAdd == 5) minutesToAdd = 0;

            time = new(time.Hour, time.Minute + minutesToAdd, 0);

            var todaysIncomingAppointments = await _appointmentRepository.GetAllAsync(appointment =>
                appointment.AssignedTo.Id == assignedTo.Id &&
                appointment.Status == AppointmentStatus.Scheduled &&
                appointment.DateAndTime.Date == appointmentDateTime.Date
            );

            // It is assumed that all appointment start times are divisible by 5
            var appointmentTimes = todaysIncomingAppointments.Select(appointment => appointment.Time);

            while (time >= StartShift && time <= EndShift.AddMinutes(-DefaultAppointmentDuration.TotalMinutes))
            {
                resultTimes.Add(time);
                time = time.AddMinutes(5);
            }

            foreach (var appointmentTime in appointmentTimes)
            {
                // Remove previous time points to avoid appointments intersection
                resultTimes.Remove(appointmentTime.AddMinutes(-15));
                resultTimes.Remove(appointmentTime.AddMinutes(-10));
                resultTimes.Remove(appointmentTime.AddMinutes(-5));

                // Remove occupied time points
                resultTimes.Remove(appointmentTime);
                resultTimes.Remove(appointmentTime.AddMinutes(5));
                resultTimes.Remove(appointmentTime.AddMinutes(10));
                resultTimes.Remove(appointmentTime.AddMinutes(15));
            }

            resultTimes.Remove(EndShift);
            resultTimes.Remove(EndShift.AddMinutes(-5));
            resultTimes.Remove(EndShift.AddMinutes(-10));

            return resultTimes;
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(TimeSlotDetectionService)}.{nameof(GetTimeSlotsByDate)}";
            throw new MedicoException(message, ex);
        }
    }

    public TimeSpan GetDefaultAppointmentDuration() => DefaultAppointmentDuration;

    public TimeSpan GetInBetweenAppointmentsBreak() => InBetweenAppointmentsBreak;

    public TimeOnly GetStartShift() => StartShift;

    public TimeOnly GetEndShift() => EndShift;
}