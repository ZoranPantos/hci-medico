using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HciMedico.Integration.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Uid = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Education = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Address_Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Number = table.Column<int>(type: "int", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactInfo_TelephoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmployedSince = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CurrentSalary = table.Column<double>(type: "double", nullable: false),
                    Discriminator = table.Column<string>(type: "varchar(13)", maxLength: 13, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicalConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalConditions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicalSpecializations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSpecializations", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Uid = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address_Number = table.Column<int>(type: "int", nullable: false),
                    ContactInfo_Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ContactInfo_TelephoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasswordLastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserRole = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccounts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkSchedule_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctor_medicalspecialization",
                columns: table => new
                {
                    DoctorsId = table.Column<int>(type: "int", nullable: false),
                    SpecializationsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_doctor_medicalspecialization", x => new { x.DoctorsId, x.SpecializationsId });
                    table.ForeignKey(
                        name: "FK_doctor_medicalspecialization_Employees_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_doctor_medicalspecialization_MedicalSpecializations_Speciali~",
                        column: x => x.SpecializationsId,
                        principalTable: "MedicalSpecializations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HealthRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthRecords_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LandingPage = table.Column<int>(type: "int", nullable: false),
                    UserAccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WorkShift",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WorkScheduleId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ShiftStartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShiftEndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShift", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkShift_WorkSchedule_WorkScheduleId",
                        column: x => x.WorkScheduleId,
                        principalTable: "WorkSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateAndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HealthRecordId = table.Column<int>(type: "int", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    CounterWorkerId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: true),
                    IdentifierName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_CounterWorkerId",
                        column: x => x.CounterWorkerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Employees_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_HealthRecords_HealthRecordId",
                        column: x => x.HealthRecordId,
                        principalTable: "HealthRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "healthrecord_medicalcondition",
                columns: table => new
                {
                    MedicalConditionId = table.Column<int>(type: "int", nullable: false),
                    HealthRecordId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthrecord_medicalcondition", x => new { x.HealthRecordId, x.MedicalConditionId });
                    table.ForeignKey(
                        name: "FK_healthrecord_medicalcondition_HealthRecords_HealthRecordId",
                        column: x => x.HealthRecordId,
                        principalTable: "HealthRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthrecord_medicalcondition_MedicalConditions_MedicalCondi~",
                        column: x => x.MedicalConditionId,
                        principalTable: "MedicalConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MedicalReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Analysis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PreviousFindings = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Diagnosis = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Therapy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AdditionalNotes = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    HealthRecordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalReport_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalReport_HealthRecords_HealthRecordId",
                        column: x => x.HealthRecordId,
                        principalTable: "HealthRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "report_medicalcondition",
                columns: table => new
                {
                    MedicalConditionsId = table.Column<int>(type: "int", nullable: false),
                    MedicalReportsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_report_medicalcondition", x => new { x.MedicalConditionsId, x.MedicalReportsId });
                    table.ForeignKey(
                        name: "FK_report_medicalcondition_MedicalConditions_MedicalConditionsId",
                        column: x => x.MedicalConditionsId,
                        principalTable: "MedicalConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_report_medicalcondition_MedicalReport_MedicalReportsId",
                        column: x => x.MedicalReportsId,
                        principalTable: "MedicalReport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CurrentSalary", "DateOfBirth", "Discriminator", "Education", "EmployedSince", "FirstName", "Gender", "LastName", "Uid", "Address_City", "Address_Country", "Address_Number", "Address_Street", "ContactInfo_Email", "ContactInfo_TelephoneNumber" },
                values: new object[,]
                {
                    { 1, 2500.0, new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marko", 0, "Petrović", "2799420993082", "Beograd", "Serbia", 10, "Kralja Milutina", "marko.petrovic@test.com", "+80036027954" },
                    { 2, 2500.0, new DateTime(1980, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 1, "Jovanović", "6052503646290", "Novi Sad", "Serbia", 15, "Bulevar Oslobođenja", "ana.jovanovic@test.com", "+98714081547" },
                    { 3, 2500.0, new DateTime(1975, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikola", 0, "Stojanović", "8878632707165", "Banja Luka", "Bosnia and Herzegovina", 8, "Kralja Petra I", "nikola.stojanovic@test.com", "+54573476490" },
                    { 4, 2500.0, new DateTime(1972, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milan", 0, "Popović", "5970662650812", "Banja Luka", "Bosnia and Herzegovina", 22, "Vuka Karadžića", "milan.popovic@test.com", "+97273441050" },
                    { 5, 2500.0, new DateTime(1990, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jovana", 1, "Nikolić", "7164497981243", "Beograd", "Serbia", 17, "Kneza Miloša", "jovana.nikolic@test.com", "+51556887254" },
                    { 6, 2500.0, new DateTime(1983, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stefan", 0, "Ilić", "4528720990335", "Prijedor", "Bosnia and Herzegovina", 9, "Nikole Tesle", "stefan.ilic@test.com", "+32043408870" },
                    { 7, 2500.0, new DateTime(1978, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marija", 1, "Pavlović", "8243490550840", "Novi Sad", "Serbia", 14, "Jovana Cvijića", "marija.pavlovic@test.com", "+72027638829" },
                    { 8, 2500.0, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aleksandar", 0, "Đorđević", "2064255702666", "Bijeljina", "Bosnia and Herzegovina", 6, "Vojvode Živojina Mišića", "aleksandar.djordjevic@test.com", "+46861751060" },
                    { 9, 2500.0, new DateTime(1986, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 1, "Janković", "1561098965142", "Banja Luka", "Bosnia and Herzegovina", 11, "Branka Ćopića", "ana.jankovic@test.com", "+68835281099" },
                    { 10, 2500.0, new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petar", 0, "Stanković", "7776483142868", "Beograd", "Serbia", 20, "Vojislava Ilića", "petar.stankovic@test.com", "+13440232654" },
                    { 11, 2500.0, new DateTime(1982, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jelena", 1, "Petrović", "5140467060058", "Novi Sad", "Serbia", 19, "Aleksandra Puškina", "jelena.petrovic@test.com", "+82569729093" },
                    { 12, 2500.0, new DateTime(1974, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dragan", 0, "Kovačević", "1325359055536", "Banja Luka", "Bosnia and Herzegovina", 7, "Đure Jakšića", "dragan.kovacevic@test.com", "+77450457112" },
                    { 13, 2500.0, new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milica", 1, "Ivanović", "3340999722266", "Novi Sad", "Serbia", 16, "Kraljice Natalije", "milica.ivanovic@test.com", "+72928767275" },
                    { 14, 2500.0, new DateTime(1965, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemanja", 0, "Jović", "1055846180215", "Prijedor", "Bosnia and Herzegovina", 5, "Stevana Mokranjca", "nemanja.jovic@test.com", "+56742533174" },
                    { 15, 2500.0, new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mina", 1, "Pavlović", "5301018591286", "Beograd", "Serbia", 18, "Jug Bogdanova", "mina.pavlovic@test.com", "+60832734272" },
                    { 16, 2500.0, new DateTime(1971, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladimir", 0, "Stanišić", "1162270975669", "Bijeljina", "Bosnia and Herzegovina", 4, "Desanke Maksimović", "vladimir.stanisic@test.com", "+87517958640" },
                    { 17, 2500.0, new DateTime(1984, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jovanka", 1, "Đorđević", "4563739544754", "Beograd", "Serbia", 11, "Kneza Miloša", "jovanka.djordjevic@test.com", "+89173474553" },
                    { 18, 2500.0, new DateTime(1976, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Branimir", 0, "Nikolić", "3433899209420", "Banja Luka", "Bosnia and Herzegovina", 3, "Svetozara Markovića", "branimir.nikolic@test.com", "+64014745332" },
                    { 19, 2500.0, new DateTime(1980, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 1, "Janković", "3157855688489", "Beograd", "Serbia", 7, "Njegoševa", "ana.jankovic@test.com", "+37721631441" },
                    { 20, 2500.0, new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nikola", 0, "Stanković", "9522177937700", "Banja Luka", "Bosnia and Herzegovina", 2, "Vojvode Stepe", "nikola.stankovic@test.com", "+77350417929" },
                    { 21, 2500.0, new DateTime(1981, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sanja", 1, "Petrović", "8811143340407", "Novi Sad", "Serbia", 10, "Kralja Milutina", "sanja.petrovic@test.com", "+29301076314" },
                    { 22, 2500.0, new DateTime(1979, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miloš", 0, "Jovanović", "6071604875747", "Prijedor", "Bosnia and Herzegovina", 15, "Bulevar Oslobođenja", "milos.jovanovic@test.com", "+27956993516" },
                    { 23, 2500.0, new DateTime(1962, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tatjana", 1, "Stojanović", "6236969043097", "Novi Sad", "Serbia", 8, "Kralja Petra I", "tatjana.stojanovic@test.com", "+62407437551" },
                    { 24, 2500.0, new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladimir", 0, "Stanković", "6587032690563", "Bijeljina", "Bosnia and Herzegovina", 22, "Vuka Karadžića", "vladimir.stankovic@test.com", "+80858414598" },
                    { 25, 2500.0, new DateTime(1973, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivana", 1, "Janković", "1295240027929", "Beograd", "Serbia", 11, "Branka Ćopića", "ivana.jankovic@test.com", "+50186495759" },
                    { 26, 2500.0, new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nenad", 0, "Petrović", "9235805061506", "Banja Luka", "Bosnia and Herzegovina", 7, "Đure Jakšića", "nenad.petrovic@test.com", "+35018239587" },
                    { 27, 2500.0, new DateTime(1967, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milica", 1, "Ilić", "4938634708328", "Novi Sad", "Serbia", 16, "Kraljice Natalije", "milica.ilic@test.com", "+42109809655" },
                    { 28, 2500.0, new DateTime(1979, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vladan", 0, "Đorđević", "6902497446663", "Banja Luka", "Bosnia and Herzegovina", 5, "Stevana Mokranjca", "vladan.djordjevic@test.com", "+67335723643" },
                    { 29, 2500.0, new DateTime(1982, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sara", 1, "Pavlović", "1702563124188", "Beograd", "Serbia", 18, "Jug Bogdanova", "sara.pavlovic@test.com", "+82511921550" },
                    { 30, 2500.0, new DateTime(1986, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nemanja", 0, "Stanišić", "5937809602362", "Banja Luka", "Bosnia and Herzegovina", 4, "Desanke Maksimović", "nemanja.stanisic@test.com", "+74581499488" },
                    { 31, 1500.0, new DateTime(1998, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ksenija", 1, "Marković", "5779732416197", "Banja Luka", "Bosnia and Herzegovina", 10, "Svetog Save", "ksenija.markovic@test.com", "+21634910758" },
                    { 32, 1500.0, new DateTime(1995, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milica", 1, "Simeunović", "7268398561664", "Banja Luka", "Bosnia and Herzegovina", 7, "Vojvode Putnika", "milica.simeunovic@test.com", "+34473672208" },
                    { 33, 1500.0, new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Petar", 0, "Tomić", "6321629475232", "Banja Luka", "Bosnia and Herzegovina", 22, "Kralja Petra I", "petar.tomic@test.com", "+15954404074" },
                    { 34, 1500.0, new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", 1, "Jovanović", "5497357002942", "Banja Luka", "Bosnia and Herzegovina", 33, "Desanke Maksimović", "ana.jovanovic@test.com", "+52006474109" }
                });

            migrationBuilder.InsertData(
                table: "MedicalConditions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hypertension" },
                    { 2, "Diabetes mellitus" },
                    { 3, "Asthma" },
                    { 4, "Osteoarthritis" },
                    { 5, "Migraine" },
                    { 6, "Depression" },
                    { 7, "Schizophrenia" },
                    { 8, "Alzheimer's disease" },
                    { 9, "Parkinson's disease" },
                    { 10, "Rheumatoid arthritis" },
                    { 11, "Chronic obstructive pulmonary disease (COPD)" },
                    { 12, "Coronary artery disease" },
                    { 13, "Chronic kidney disease" },
                    { 14, "Irritable bowel syndrome (IBS)" },
                    { 15, "Chronic fatigue syndrome" },
                    { 16, "Fibromyalgia" },
                    { 17, "Multiple sclerosis" },
                    { 18, "Crohn's disease" },
                    { 19, "Ulcerative colitis" },
                    { 20, "Bipolar disorder" },
                    { 21, "Autism spectrum disorder" },
                    { 22, "Attention deficit hyperactivity disorder (ADHD)" },
                    { 23, "Celiac disease" },
                    { 24, "Anemia" },
                    { 25, "Endometriosis" },
                    { 26, "Polycystic ovary syndrome (PCOS)" },
                    { 27, "Erectile dysfunction" },
                    { 28, "Psoriasis" },
                    { 29, "Eczema" },
                    { 30, "Gout" },
                    { 31, "Osteoporosis" },
                    { 32, "Thyroid disorders" },
                    { 33, "Glaucoma" },
                    { 34, "Macular degeneration" },
                    { 35, "Cataracts" },
                    { 36, "Scoliosis" },
                    { 37, "Tuberculosis" },
                    { 38, "HIV/AIDS" },
                    { 39, "Hepatitis (various types)" },
                    { 40, "Epilepsy" },
                    { 41, "Stroke" },
                    { 42, "Heart failure" },
                    { 43, "Chronic pancreatitis" },
                    { 44, "Chronic bronchitis" },
                    { 45, "Pneumonia" },
                    { 46, "Chronic liver disease" },
                    { 47, "Systemic lupus erythematosus (SLE)" },
                    { 48, "Sickle cell disease" },
                    { 49, "Leukemia" },
                    { 50, "Lymphoma" },
                    { 51, "Melanoma" },
                    { 52, "Breast cancer" },
                    { 53, "Prostate cancer" },
                    { 54, "Colon cancer" },
                    { 55, "Lung cancer" },
                    { 56, "Pancreatic cancer" },
                    { 57, "Cervical cancer" },
                    { 58, "Bladder cancer" },
                    { 59, "Brain tumor" },
                    { 60, "Glioblastoma" },
                    { 61, "Myocardial infarction" },
                    { 62, "Cardiomyopathy" },
                    { 63, "Atrial fibrillation" },
                    { 64, "Deep vein thrombosis (DVT)" },
                    { 65, "Pulmonary embolism (PE)" },
                    { 66, "Atherosclerosis" },
                    { 67, "Peripheral artery disease" },
                    { 68, "Hypothyroidism" },
                    { 69, "Hyperthyroidism" },
                    { 70, "Menopause" },
                    { 71, "Benign prostatic hyperplasia (BPH)" },
                    { 72, "Glomerulonephritis" },
                    { 73, "Nephrotic syndrome" },
                    { 74, "Diverticulitis" },
                    { 75, "Pancreatitis" },
                    { 76, "Gastroparesis" },
                    { 77, "Barrett's esophagus" },
                    { 78, "Cirrhosis" },
                    { 79, "Hepatic encephalopathy" },
                    { 80, "Wilson's disease" },
                    { 81, "Hemochromatosis" },
                    { 82, "Pernicious anemia" },
                    { 83, "Thalassemia" },
                    { 84, "Hemophilia" },
                    { 85, "Von Willebrand disease" },
                    { 86, "Deep vein thrombosis (DVT)" },
                    { 87, "Pulmonary embolism (PE)" },
                    { 88, "Osteomyelitis" },
                    { 89, "Bursitis" },
                    { 90, "Tendinitis" },
                    { 91, "Plantar fasciitis" },
                    { 92, "Carpal tunnel syndrome" },
                    { 93, "Dupuytren's contracture" },
                    { 94, "Temporomandibular joint disorder (TMJ)" },
                    { 95, "Bell's palsy" },
                    { 96, "Trigeminal neuralgia" },
                    { 97, "Sciatica" },
                    { 98, "Herniated disc" },
                    { 99, "Spondylosis" },
                    { 100, "Spondylolisthesis" },
                    { 101, "Ankylosing spondylitis" },
                    { 102, "Temporal arteritis" },
                    { 103, "Polymyalgia rheumatica" },
                    { 104, "Dermatomyositis" },
                    { 105, "Polymyositis" },
                    { 106, "Bell's palsy" },
                    { 107, "Tinnitus" },
                    { 108, "Meniere's disease" },
                    { 109, "Otosclerosis" },
                    { 110, "Labyrinthitis" },
                    { 111, "Vertigo" },
                    { 112, "Motion sickness" },
                    { 113, "Insomnia" },
                    { 114, "Sleep apnea" },
                    { 115, "Narcolepsy" },
                    { 116, "Restless legs syndrome" },
                    { 117, "Bruxism" },
                    { 118, "Periodontitis" },
                    { 119, "Gingivitis" },
                    { 120, "Oral thrush" },
                    { 121, "Oral cancer" },
                    { 122, "Temporomandibular joint disorder (TMJ)" },
                    { 123, "Halitosis" },
                    { 124, "Gastroesophageal reflux disease (GERD)" },
                    { 125, "Hiatal hernia" },
                    { 126, "Gastritis" },
                    { 127, "Peptic ulcer disease" },
                    { 128, "Diverticulosis" },
                    { 129, "Hemorrhoids" },
                    { 130, "Colitis" },
                    { 131, "Gastric cancer" },
                    { 132, "Celiac disease" },
                    { 133, "Lactose intolerance" },
                    { 134, "Irritable bowel syndrome (IBS)" },
                    { 135, "Crohn's disease" },
                    { 136, "Ulcerative colitis" },
                    { 137, "Diverticulitis" },
                    { 138, "Pancreatitis" },
                    { 139, "Gallstones" },
                    { 140, "Cholecystitis" },
                    { 141, "Cholangitis" },
                    { 142, "Hepatitis" },
                    { 143, "Cirrhosis" },
                    { 144, "Fatty liver disease" },
                    { 145, "Gastroenteritis" },
                    { 146, "Appendicitis" },
                    { 147, "Irritable bowel syndrome (IBS)" },
                    { 148, "Peptic ulcer disease" },
                    { 149, "Gastric cancer" },
                    { 150, "Esophageal cancer" },
                    { 151, "Pancreatic cancer" },
                    { 152, "Colorectal cancer" },
                    { 153, "Liver cancer" },
                    { 154, "Gallbladder cancer" },
                    { 155, "Bile duct cancer" },
                    { 156, "Ovarian cancer" },
                    { 157, "Uterine cancer" },
                    { 158, "Cervical cancer" },
                    { 159, "Vulvar cancer" },
                    { 160, "Vaginal cancer" },
                    { 161, "Testicular cancer" },
                    { 162, "Penile cancer" },
                    { 163, "Prostate cancer" },
                    { 164, "Bladder cancer" },
                    { 165, "Kidney cancer" },
                    { 166, "Adrenal cancer" },
                    { 167, "Thyroid cancer" },
                    { 168, "Parathyroid cancer" },
                    { 169, "Thymoma" },
                    { 170, "Laryngeal cancer" },
                    { 171, "Nasopharyngeal cancer" },
                    { 172, "Oral cancer" },
                    { 173, "Salivary gland cancer" },
                    { 174, "Sinus cancer" },
                    { 175, "Nasal cavity cancer" },
                    { 176, "Pituitary tumor" },
                    { 177, "Adrenal tumor" },
                    { 178, "Neuroendocrine tumor" },
                    { 179, "Carcinoid tumor" },
                    { 180, "Gastrointestinal stromal tumor (GIST)" },
                    { 181, "Leiomyosarcoma" },
                    { 182, "Osteosarcoma" },
                    { 183, "Chondrosarcoma" },
                    { 184, "Ewing sarcoma" },
                    { 185, "Rhabdomyosarcoma" },
                    { 186, "Liposarcoma" },
                    { 187, "Fibrosarcoma" },
                    { 188, "Angiosarcoma" },
                    { 189, "Synovial sarcoma" },
                    { 190, "Meningioma" },
                    { 191, "Glioma" },
                    { 192, "Astrocytoma" },
                    { 193, "Medulloblastoma" },
                    { 194, "Ependymoma" },
                    { 195, "Pinealoma" },
                    { 196, "Chordoma" },
                    { 197, "Craniopharyngioma" },
                    { 198, "Hemangioma" },
                    { 199, "Lymphangioma" },
                    { 200, "Teratoma" }
                });

            migrationBuilder.InsertData(
                table: "MedicalSpecializations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Neurologist" },
                    { 2, "Orthopedist" },
                    { 3, "Dentist" },
                    { 4, "Cardiologist" },
                    { 5, "Dermatologist" },
                    { 6, "Endocrinologist" },
                    { 7, "Gastroenterologist" },
                    { 8, "Hematologist" },
                    { 9, "Oncologist" },
                    { 10, "Ophthalmologist" },
                    { 11, "Pediatrician" },
                    { 12, "Psychiatrist" },
                    { 13, "Radiologist" },
                    { 14, "Urologist" },
                    { 15, "Gynecologist" },
                    { 16, "Otolaryngologist" },
                    { 17, "Allergist" },
                    { 18, "Immunologist" },
                    { 19, "Rheumatologist" },
                    { 20, "Anesthesiologist" },
                    { 21, "Pathologist" },
                    { 22, "Geriatrician" },
                    { 23, "Pulmonologist" },
                    { 24, "Nephrologist" },
                    { 25, "Neonatologist" },
                    { 26, "Gastrointestinal surgeon" },
                    { 27, "Plastic surgeon" },
                    { 28, "Cardiothoracic surgeon" },
                    { 29, "Orthopedic surgeon" },
                    { 30, "Urological surgeon" },
                    { 31, "Oral and maxillofacial surgeon" },
                    { 32, "Oncological surgeon" },
                    { 33, "Neurological surgeon" },
                    { 34, "Pediatric surgeon" },
                    { 35, "Vascular surgeon" },
                    { 36, "Obstetrician" },
                    { 37, "Reproductive endocrinologist" },
                    { 38, "Podiatrist" },
                    { 39, "Optometrist" },
                    { 40, "Homeopath" },
                    { 41, "Nutritionist" },
                    { 42, "Psychologist" },
                    { 43, "Pharmacist" },
                    { 44, "General practicioner" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "FirstName", "LastName", "Uid", "Address_City", "Address_Country", "Address_Number", "Address_Street", "ContactInfo_Email", "ContactInfo_TelephoneNumber" },
                values: new object[,]
                {
                    { 1, "Boris", "Borisavljević", "18179386304", "Banja Luka", "Bosnia and Herzegovina", 1, "Kralja Milutina", "boris.borisavljevic@test.com", "+20414146755" },
                    { 2, "Saška", "Mačetić", "89223326672", "Banja Luka", "Bosnia and Herzegovina", 2, "Novska", "saska.macetic@test.com", "+45649196201" },
                    { 3, "Miloš", "Milosavljević", "46548392330", "Banja Luka", "Bosnia and Herzegovina", 3, "Milana Jazbeca", "milos.milosevic@test.com", "+78973443325" },
                    { 4, "Ana", "Stanojević", "96293082244", "Banja Luka", "Bosnia and Herzegovina", 4, "Krfska", "ana.stanojevic@test.com", "+18339997708" },
                    { 5, "Darko", "Darković", "64191925601", "Banja Luka", "Bosnia and Herzegovina", 5, "Miše Kovača", "darko.darkovic@test.com", "+87872174488" },
                    { 6, "Jovana", "Jovanović", "86951189417", "Banja Luka", "Bosnia and Herzegovina", 6, "Davida Štrbca", "jovana.jovanovic@test.com", "+31769233852" },
                    { 7, "Nikola", "Nikolić", "30119196772", "Banja Luka", "Bosnia and Herzegovina", 7, "Ranka Šipke", "nikola.nikolic@test.com", "+84344368466" },
                    { 8, "David", "Davidović", "29520209488", "Banja Luka", "Bosnia and Herzegovina", 8, "Karađorđeva", "david.davidovic@test.com", "+77153808822" },
                    { 9, "Stana", "Stanojević", "44946581522", "Banja Luka", "Bosnia and Herzegovina", 9, "Leskovačka", "stana.stanojevic@test.com", "+10401369089" },
                    { 10, "Goran", "Predojević", "62059127053", "Banja Luka", "Bosnia and Herzegovina", 10, "Krajiška", "goran.predojevic@test.com", "+62823252336" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CounterWorkerId", "CreationTime", "DateAndTime", "DoctorId", "HealthRecordId", "IdentifierName", "PatientId", "Status", "Type" },
                values: new object[,]
                {
                    { 31, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 9, 40, 0, 0, DateTimeKind.Unspecified), 11, null, "lana pepic", null, 0, 0 },
                    { 32, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 10, 20, 0, 0, DateTimeKind.Unspecified), 12, null, "nikola jokic", null, 0, 0 },
                    { 33, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 10, 40, 0, 0, DateTimeKind.Unspecified), 14, null, "marija novakovic", null, 0, 0 },
                    { 34, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 20, 11, 20, 0, 0, DateTimeKind.Unspecified), 19, null, "branko brankovic", null, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "HealthRecords",
                columns: new[] { "Id", "BloodGroup", "DateOfBirth", "Gender", "PatientId" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(1960, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { 2, 5, new DateTime(1961, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, 0, new DateTime(1963, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 3 },
                    { 4, 1, new DateTime(1964, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 5, 2, new DateTime(1965, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 5 },
                    { 6, 3, new DateTime(1966, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 7, 6, new DateTime(1967, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 7 },
                    { 8, 7, new DateTime(1968, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 8 },
                    { 9, 4, new DateTime(1969, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9 },
                    { 10, 5, new DateTime(1970, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 10 }
                });

            migrationBuilder.InsertData(
                table: "UserAccounts",
                columns: new[] { "Id", "EmployeeId", "Password", "PasswordLastUpdated", "UserRole", "Username" },
                values: new object[,]
                {
                    { 1, 1, "eESUiBPJLQ/s4CMXRZ6QZgXE2k/VbM5+QC1XNdpR7TA=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "marko.petrovic1" },
                    { 2, 2, "tmh4kL6Kj+aAlli2JuVvxEwfM+DCo7K+zV7Nb+NzXgk=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "ana.jovanovic2" },
                    { 3, 3, "rb9ClnCFci1dATS1bF1fKPW+dK9VIQYENH3QobXmkFM=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "nikola.stojanovic3" },
                    { 4, 4, "8vc5vplkQcG0tCR4dhcHgO/gibJLWFkJsZsfpwHum60=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "milan.popovic4" },
                    { 5, 5, "Z7TOhn2+TphnOSCh69fEszh7HYrJ1rsEVfIbfXjvGfs=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "jovana.nikolic5" },
                    { 6, 6, "EHP0K4G7nZESTMC8QObiSUAsjUCpHQL3waqFYr/bs/0=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "stefan.ilic6" },
                    { 7, 7, "Kj3uvEwBgBUH63vjqg/31Mif4W161bEyv+yAc4wCLqU=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "marija.pavlovic7" },
                    { 8, 8, "lHxoiDJxD0YhPdDWPmEdiY6ZxgJBpbvbvECh749kSK8=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "aleksandar.djordjevic8" },
                    { 9, 9, "ABIgJbyqGzRdpXNDVu5VX29suSgUHmDhscYOcEp1pL4=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "ana.jankovic9" },
                    { 10, 10, "MiPz131hmHi1XpC0SaTuD2f4MpuDrlms7dnlrCuAHIM=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "petar.stankovic10" },
                    { 11, 11, "sJaf1zIZn9LbgAYmXpDLmLEHxD4QI8/4dvQ4nrV7hg8=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "jelena.petrovic11" },
                    { 12, 12, "/cKh+rVsE99W5bIs4PCMq8iy7pYuB1wVIDsVdqFjkrI=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "dragan.kovacevic12" },
                    { 13, 13, "ePuTCLRUZoEFNlTlWHY5ZNunTltyviJECsqld+VeTQk=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "milica.ivanovic13" },
                    { 14, 14, "me8plQoA6wDHr6tOT5WDGd0CRol502zeZ01WD123vnw=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "nemanja.jovic14" },
                    { 15, 15, "oyp8I0a1DoQTCxH0iIuOb80DA7PGCsAJhsJLCtFVqqU=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "mina.pavlovic15" },
                    { 16, 16, "KG0SiGyv73f4er6WDUKTcvNvwZLEgpcI4/PZVgH+DZk=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "vladimir.stanisic16" },
                    { 17, 17, "Q9ULJHow9ABdRGP7u36vw2xrrapWSVjgixrVWyv8DQQ=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "jovanka.djordjevic17" },
                    { 18, 18, "+7il6G6rCI6QNidGnW/vQGFNFLPc3ihiCKrnqFOTOJ4=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "branimir.nikolic18" },
                    { 19, 19, "KpW3sAeAwyaI0prN0DKRtsoWnb2Z7tbVniVAI6Izxi4=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "ana.jankovic19" },
                    { 20, 20, "Uow46Y+l3Ay/hRyEmlNugioCnnhT2IuPjaaG75BcTsE=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "nikola.stankovic20" },
                    { 21, 21, "yJKlI7xdCsM3JYHtjhvop04ADVrYkqOJ/hKGYMmh0/g=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "sanja.petrovic21" },
                    { 22, 22, "/UssdFSw0+558PMPhS1POSU2tjbPYtYOJzSA7XUOMog=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "milos.jovanovic22" },
                    { 23, 23, "44IGSFhstzcDUmhTe6M4Z/KssToE8tSy2vG6ggn81vY=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "tatjana.stojanovic23" },
                    { 24, 24, "TF9XFyEy/WxKm0G+5Fhjpio5Oot7zIW2T/P2mNR2O9w=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "vladimir.stankovic24" },
                    { 25, 25, "qBhnbx8tXbGK0rLRy39RNJIjMYX7SS06I8KnyTBtk9Q=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "ivana.jankovic25" },
                    { 26, 26, "MFuDfJosLdAjWwopTmnyr4pa6R3sCIlB/i16crTlROo=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "nenad.petrovic26" },
                    { 27, 27, "COFH5IWyq4cYSnX1abXsHr4FZQqq7RrZUVLZHTSRLUo=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "milica.ilic27" },
                    { 28, 28, "Py/RFAy3B6i2ANiwPdVkqaQJakpjkKCJjSV/1TSoU7s=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "vladan.djordjevic28" },
                    { 29, 29, "Go3RakYLQ/g8ovKyoT5R1XJYRMkhqPz+zV/C8gVYu5E=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "sara.pavlovic29" },
                    { 30, 30, "ROPw0GUTGxouB4+yWRVtk29BUILTT3IrnsnySVt0NDY=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 0, "nemanja.stanisic30" },
                    { 31, 31, "7nJpngTuuD72k1l646OxwdyvNyt/+/5ZxSgxsS8z/Jc=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 1, "ksenija.markovic31" },
                    { 32, 32, "GtcieDv+kU/Lq8kwEiDOV/U7QM+yZLIEMhy0dRz0kIo=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 1, "milica.simeunovic32" },
                    { 33, 33, "MuNTgCJTqvnDqtV14+v7IGgmIA6jNXfKTELBcxB4ECI=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 1, "petar.tomic33" },
                    { 34, 34, "s6iZf5LkTbE3sAyW5eVBboT5bdMVwmdk1C9cELCfX/w=", new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified), 1, "ana.jovanovic34" }
                });

            migrationBuilder.InsertData(
                table: "WorkSchedule",
                columns: new[] { "Id", "EmployeeId" },
                values: new object[,]
                {
                    { 1, 31 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "doctor_medicalspecialization",
                columns: new[] { "DoctorsId", "SpecializationsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 33 },
                    { 2, 1 },
                    { 3, 2 },
                    { 3, 29 },
                    { 4, 2 },
                    { 5, 3 },
                    { 6, 5 },
                    { 7, 6 },
                    { 8, 7 },
                    { 9, 8 },
                    { 10, 9 },
                    { 11, 10 },
                    { 12, 13 },
                    { 13, 13 },
                    { 13, 24 },
                    { 14, 15 },
                    { 15, 19 },
                    { 16, 19 },
                    { 17, 41 },
                    { 18, 44 },
                    { 19, 44 },
                    { 20, 44 },
                    { 21, 31 },
                    { 22, 32 },
                    { 23, 34 },
                    { 24, 35 },
                    { 25, 37 },
                    { 26, 25 },
                    { 26, 38 },
                    { 27, 39 },
                    { 28, 40 },
                    { 29, 42 },
                    { 30, 43 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CounterWorkerId", "CreationTime", "DateAndTime", "DoctorId", "HealthRecordId", "IdentifierName", "PatientId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 0 },
                    { 2, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 8, 20, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 3, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 8, 40, 0, 0, DateTimeKind.Unspecified), 16, 2, "saska macetic", 2, 1, 0 },
                    { 4, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 9, 0, 0, 0, DateTimeKind.Unspecified), 16, 2, "saska macetic", 2, 1, 1 },
                    { 5, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, "milos milosavljevic", 3, 1, 0 },
                    { 6, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 10, 30, 0, 0, DateTimeKind.Unspecified), 15, 3, "milos milosavljevic", 3, 1, 1 },
                    { 7, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 0 },
                    { 8, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 11, 30, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 },
                    { 9, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "darko darkovic", 5, 1, 0 },
                    { 10, 34, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 12, 30, 0, 0, DateTimeKind.Unspecified), 4, 5, "darko darkovic", 5, 1, 1 },
                    { 11, 34, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, "jovana jovanovic", 6, 1, 0 },
                    { 12, 34, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, 6, "jovana jovanovic", 6, 1, 1 },
                    { 13, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, "nikola nikolic", 7, 1, 0 },
                    { 14, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 14, 30, 0, 0, DateTimeKind.Unspecified), 4, 7, "nikola nikolic", 7, 1, 1 },
                    { 15, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "david davidovic", 8, 1, 0 },
                    { 16, 32, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 15, 20, 0, 0, DateTimeKind.Unspecified), 1, 8, "david davidovic", 8, 1, 1 },
                    { 17, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 15, 40, 0, 0, DateTimeKind.Unspecified), 1, 9, "stana stanojevic", 9, 1, 0 },
                    { 18, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, "stana stanojevic", 9, 2, 1 },
                    { 19, 34, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 5, 16, 20, 0, 0, DateTimeKind.Unspecified), 1, 10, "goran predojevic", 10, 1, 0 },
                    { 20, 34, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 25, 16, 40, 0, 0, DateTimeKind.Unspecified), 1, 10, "goran predojevic", 10, 2, 1 },
                    { 21, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 6, 17, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 22, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 17, 20, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 23, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 7, 17, 40, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 },
                    { 24, 33, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 },
                    { 25, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 20, 18, 20, 0, 0, DateTimeKind.Unspecified), 9, 1, "boris borisavljevic", 1, 1, 0 },
                    { 26, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 18, 40, 0, 0, DateTimeKind.Unspecified), 9, 1, "boris borisavljevic", 1, 0, 1 },
                    { 27, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 19, 19, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, "saska macetic", 2, 1, 0 },
                    { 28, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 19, 20, 0, 0, DateTimeKind.Unspecified), 9, 2, "saska macetic", 2, 0, 1 },
                    { 29, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 19, 40, 0, 0, DateTimeKind.Unspecified), 9, 3, "milos milosavljevic", 3, 1, 0 },
                    { 30, 31, new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 9, 20, 0, 0, DateTimeKind.Unspecified), 9, 3, "milos milosavljevic", 3, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "UserSettings",
                columns: new[] { "Id", "LandingPage", "UserAccountId" },
                values: new object[,]
                {
                    { 1, 0, 1 },
                    { 2, 0, 2 },
                    { 3, 0, 3 },
                    { 4, 0, 4 },
                    { 5, 0, 5 },
                    { 6, 0, 6 },
                    { 7, 0, 7 },
                    { 8, 0, 8 },
                    { 9, 0, 9 },
                    { 10, 0, 10 },
                    { 11, 0, 11 },
                    { 12, 0, 12 },
                    { 13, 0, 13 },
                    { 14, 0, 14 },
                    { 15, 0, 15 },
                    { 16, 0, 16 },
                    { 17, 0, 17 },
                    { 18, 0, 18 },
                    { 19, 0, 19 },
                    { 20, 0, 20 },
                    { 21, 0, 21 },
                    { 22, 0, 22 },
                    { 23, 0, 23 },
                    { 24, 0, 24 },
                    { 25, 0, 25 },
                    { 26, 0, 26 },
                    { 27, 0, 27 },
                    { 28, 0, 28 },
                    { 29, 0, 29 },
                    { 30, 0, 30 },
                    { 31, 0, 31 },
                    { 32, 0, 32 },
                    { 33, 0, 33 },
                    { 34, 0, 34 }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "Id", "DateTime", "ShiftEndTime", "ShiftStartTime", "WorkScheduleId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 2, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 3, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 4, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 5, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 6, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 7, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 8, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 9, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 10, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 11, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 12, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 1 },
                    { 13, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 14, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 15, new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 16, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 17, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 18, new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 19, new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 20, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 21, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 22, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 23, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 },
                    { 24, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Local), "16:00", "08:00", 2 }
                });

            migrationBuilder.InsertData(
                table: "healthrecord_medicalcondition",
                columns: new[] { "HealthRecordId", "MedicalConditionId", "Status" },
                values: new object[,]
                {
                    { 1, 4, 0 },
                    { 1, 24, 1 },
                    { 2, 4, 0 },
                    { 2, 24, 1 },
                    { 3, 4, 0 },
                    { 3, 24, 1 },
                    { 4, 90, 0 },
                    { 5, 90, 0 },
                    { 6, 90, 0 },
                    { 7, 90, 0 },
                    { 8, 97, 0 },
                    { 9, 97, 0 },
                    { 10, 97, 0 }
                });

            migrationBuilder.InsertData(
                table: "MedicalReport",
                columns: new[] { "Id", "AdditionalNotes", "Analysis", "AppointmentId", "DateTime", "Diagnosis", "HealthRecordId", "PreviousFindings", "Therapy" },
                values: new object[] { 1, "Follow-up in 4 weeks to assess response to therapy. Patient advised to avoid high-impact activities and wear supportive shoes.", "Patient presents with heel pain, particularly upon first steps in the morning. Pain is localized to the medial aspect of the heel.", 1, new DateTime(2024, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "", 1, "No significant previous findings. Patient reports occasional mild discomfort after long periods of standing.", "Recommend rest, ice application, stretching exercises, and over-the-counter NSAIDs. Consider custom orthotics if pain persists." });

            migrationBuilder.InsertData(
                table: "report_medicalcondition",
                columns: new[] { "MedicalConditionsId", "MedicalReportsId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CounterWorkerId",
                table: "Appointments",
                column: "CounterWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_HealthRecordId",
                table: "Appointments",
                column: "HealthRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_doctor_medicalspecialization_SpecializationsId",
                table: "doctor_medicalspecialization",
                column: "SpecializationsId");

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_medicalcondition_MedicalConditionId",
                table: "healthrecord_medicalcondition",
                column: "MedicalConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecords_PatientId",
                table: "HealthRecords",
                column: "PatientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReport_AppointmentId",
                table: "MedicalReport",
                column: "AppointmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReport_HealthRecordId",
                table: "MedicalReport",
                column: "HealthRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_report_medicalcondition_MedicalReportsId",
                table: "report_medicalcondition",
                column: "MedicalReportsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_EmployeeId",
                table: "UserAccounts",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_UserAccountId",
                table: "UserSettings",
                column: "UserAccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkSchedule_EmployeeId",
                table: "WorkSchedule",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkShift_WorkScheduleId",
                table: "WorkShift",
                column: "WorkScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctor_medicalspecialization");

            migrationBuilder.DropTable(
                name: "healthrecord_medicalcondition");

            migrationBuilder.DropTable(
                name: "report_medicalcondition");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "WorkShift");

            migrationBuilder.DropTable(
                name: "MedicalSpecializations");

            migrationBuilder.DropTable(
                name: "MedicalConditions");

            migrationBuilder.DropTable(
                name: "MedicalReport");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "WorkSchedule");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
