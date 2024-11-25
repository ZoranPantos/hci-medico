﻿using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Relationships;
using HciMedico.Integration.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace HciMedico.Integration.Data;

public sealed class AppDbContext : DbContext
{
    private readonly string connectionString = ConfigurationManager.ConnectionStrings["MedicoConnection"].ConnectionString;

    public DbSet<UserAccount> UserAccounts { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<CounterWorker> CounterWorkers { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<MedicalSpecialization> MedicalSpecializations { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<HealthRecord> HealthRecords { get; set; }
    public DbSet<MedicalCondition> MedicalConditions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new EmployeeEntityTypeConfiguration().Configure(modelBuilder.Entity<Employee>());
        new DoctorEntityTypeConfiguration().Configure(modelBuilder.Entity<Doctor>());
        new CounterWorkerEntityTypeConfiguration().Configure(modelBuilder.Entity<CounterWorker>());
        new PatientEntityTypeConfiguration().Configure(modelBuilder.Entity<Patient>());
        new MedicalConditionEntityTypeConfiguration().Configure(modelBuilder.Entity<MedicalCondition>());
        new MedicalSpecializationEntityTypeConfiguration().Configure(modelBuilder.Entity<MedicalSpecialization>());
        new UserAccountEntityTypeConfiguration().Configure(modelBuilder.Entity<UserAccount>());
        new HealthRecordEntityTypeConfiguration().Configure(modelBuilder.Entity<HealthRecord>());
        new AppointmentEntityTypeConfiguration().Configure(modelBuilder.Entity<Appointment>());
        new WorkScheduleEntityTypeConfiguration().Configure(modelBuilder.Entity<WorkSchedule>());
        new WorkShiftEntityTypeConfiguration().Configure(modelBuilder.Entity<WorkShift>());
        new UserSettingsEntityTypeConfiguration().Configure(modelBuilder.Entity<UserSettings>());
        new MedicalReportEntityTypeConfiguration().Configure(modelBuilder.Entity<MedicalReport>());

        new HealthRecordMedicalConditionEntityTypeConfiguration()
            .Configure(modelBuilder.Entity<HealthRecordMedicalCondition>());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString),
            optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
        );
    }
}
