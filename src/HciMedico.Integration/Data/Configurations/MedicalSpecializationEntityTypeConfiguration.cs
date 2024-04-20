using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class MedicalSpecializationEntityTypeConfiguration : IEntityTypeConfiguration<MedicalSpecialization>
{
    public void Configure(EntityTypeBuilder<MedicalSpecialization> builder)
    {
        builder.HasData(
            new MedicalSpecialization { Id = 1, Name = "Neurologist" },
            new MedicalSpecialization { Id = 2, Name = "Orthopedist" },
            new MedicalSpecialization { Id = 3, Name = "Dentist" },
            new MedicalSpecialization { Id = 4, Name = "Cardiologist" },
            new MedicalSpecialization { Id = 5, Name = "Dermatologist" },
            new MedicalSpecialization { Id = 6, Name = "Endocrinologist" },
            new MedicalSpecialization { Id = 7, Name = "Gastroenterologist" },
            new MedicalSpecialization { Id = 8, Name = "Hematologist" },
            new MedicalSpecialization { Id = 9, Name = "Oncologist" },
            new MedicalSpecialization { Id = 10, Name = "Ophthalmologist" },
            new MedicalSpecialization { Id = 11, Name = "Pediatrician" },
            new MedicalSpecialization { Id = 12, Name = "Psychiatrist" },
            new MedicalSpecialization { Id = 13, Name = "Radiologist" },
            new MedicalSpecialization { Id = 14, Name = "Urologist" },
            new MedicalSpecialization { Id = 15, Name = "Gynecologist" },
            new MedicalSpecialization { Id = 16, Name = "Otolaryngologist" },
            new MedicalSpecialization { Id = 17, Name = "Allergist" },
            new MedicalSpecialization { Id = 18, Name = "Immunologist" },
            new MedicalSpecialization { Id = 19, Name = "Rheumatologist" },
            new MedicalSpecialization { Id = 20, Name = "Anesthesiologist" },
            new MedicalSpecialization { Id = 21, Name = "Pathologist" },
            new MedicalSpecialization { Id = 22, Name = "Geriatrician" },
            new MedicalSpecialization { Id = 23, Name = "Pulmonologist" },
            new MedicalSpecialization { Id = 24, Name = "Nephrologist" },
            new MedicalSpecialization { Id = 25, Name = "Neonatologist" },
            new MedicalSpecialization { Id = 26, Name = "Gastrointestinal surgeon" },
            new MedicalSpecialization { Id = 27, Name = "Plastic surgeon" },
            new MedicalSpecialization { Id = 28, Name = "Cardiothoracic surgeon" },
            new MedicalSpecialization { Id = 29, Name = "Orthopedic surgeon" },
            new MedicalSpecialization { Id = 30, Name = "Urological surgeon" },
            new MedicalSpecialization { Id = 31, Name = "Oral and maxillofacial surgeon" },
            new MedicalSpecialization { Id = 32, Name = "Oncological surgeon" },
            new MedicalSpecialization { Id = 33, Name = "Neurological surgeon" },
            new MedicalSpecialization { Id = 34, Name = "Pediatric surgeon" },
            new MedicalSpecialization { Id = 35, Name = "Vascular surgeon" },
            new MedicalSpecialization { Id = 36, Name = "Obstetrician" },
            new MedicalSpecialization { Id = 37, Name = "Reproductive endocrinologist" },
            new MedicalSpecialization { Id = 38, Name = "Podiatrist" },
            new MedicalSpecialization { Id = 39, Name = "Optometrist" },
            new MedicalSpecialization { Id = 40, Name = "Homeopath" },
            new MedicalSpecialization { Id = 41, Name = "Nutritionist" },
            new MedicalSpecialization { Id = 42, Name = "Psychologist" },
            new MedicalSpecialization { Id = 43, Name = "Pharmacist" },
            new MedicalSpecialization { Id = 44, Name = "General practicioner" }
        );
    }
}
