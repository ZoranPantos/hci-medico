using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class SchemaSetAndDataSeed2 : Migration
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
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DateAndTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    HealthRecordId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    CounterWorkerId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Discriminator", "Education", "FirstName", "Gender", "LastName", "Uid", "Address_City", "Address_Country", "Address_Number", "Address_Street", "ContactInfo_Email", "ContactInfo_TelephoneNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Marko", 0, "Petrović", "7549594555084", "Beograd", "Serbia", 10, "Kralja Milutina", "marko.petrovic@test.com", "+41631780567" },
                    { 2, new DateTime(1980, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Ana", 1, "Jovanović", "8352177851141", "Novi Sad", "Serbia", 15, "Bulevar Oslobođenja", "ana.jovanovic@test.com", "+43749997691" },
                    { 3, new DateTime(1975, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Nikola", 0, "Stojanović", "5302822157090", "Banja Luka", "Bosnia and Herzegovina", 8, "Kralja Petra I", "nikola.stojanovic@test.com", "+40556403129" },
                    { 4, new DateTime(1972, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Milan", 0, "Popović", "8209066918867", "Banja Luka", "Bosnia and Herzegovina", 22, "Vuka Karadžića", "milan.popovic@test.com", "+54146406570" },
                    { 5, new DateTime(1990, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Jovana", 1, "Nikolić", "8648132567128", "Beograd", "Serbia", 17, "Kneza Miloša", "jovana.nikolic@test.com", "+58835238320" },
                    { 6, new DateTime(1983, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Stefan", 0, "Ilić", "6098417892751", "Prijedor", "Bosnia and Herzegovina", 9, "Nikole Tesle", "stefan.ilic@test.com", "+65877834065" },
                    { 7, new DateTime(1978, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Marija", 1, "Pavlović", "3220700373484", "Novi Sad", "Serbia", 14, "tJovana Cvijićaest", "marija.pavlovic@test.com", "+38596606068" },
                    { 8, new DateTime(1968, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Aleksandar", 0, "Đorđević", "4503927483818", "Bijeljina", "Bosnia and Herzegovina", 6, "Vojvode Živojina Mišića", "aleksandar.djordjevic@test.com", "+89497616956" },
                    { 9, new DateTime(1986, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Ana", 1, "Janković", "8648015181003", "Banja Luka", "Bosnia and Herzegovina", 11, "Branka Ćopića", "ana.jankovic@test.com", "+37587780075" },
                    { 10, new DateTime(1970, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Petar", 0, "Stanković", "9193046072436", "Beograd", "Serbia", 20, "Vojislava Ilića", "petar.stankovic@test.com", "+41979338453" },
                    { 11, new DateTime(1982, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Jelena", 1, "Petrović", "7182825870535", "Novi Sad", "Serbia", 19, "Aleksandra Puškina", "jelena.petrovic@test.com", "+93672587020" },
                    { 12, new DateTime(1974, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Dragan", 0, "Kovačević", "5449972811399", "Banja Luka", "Bosnia and Herzegovina", 7, "Đure Jakšića", "dragan.kovacevic@test.com", "+76173532713" },
                    { 13, new DateTime(1993, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Milica", 1, "Ivanović", "5085796405530", "Novi Sad", "Serbia", 16, "Kraljice Natalije", "milica.ivanovic@test.com", "+60973543173" },
                    { 14, new DateTime(1965, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Nemanja", 0, "Jović", "4798834903701", "Prijedor", "Bosnia and Herzegovina", 5, "tStevana Mokranjcaest", "nemanja.jovic@test.com", "+76314348177" },
                    { 15, new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Mina", 1, "Pavlović", "1305379725882", "Beograd", "Serbia", 18, "Jug Bogdanova", "mina.pavlovic@test.com", "+25730083077" },
                    { 16, new DateTime(1971, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Vladimir", 0, "Stanišić", "8214752578600", "Bijeljina", "Bosnia and Herzegovina", 4, "Desanke Maksimović", "vladimir.stanisic@test.com", "+69843541537" },
                    { 17, new DateTime(1984, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Jovanka", 1, "Đorđević", "4198742148649", "Beograd", "Serbia", 11, "Kneza Miloša", "jovanka.djordjevic@test.com", "+13806523096" },
                    { 18, new DateTime(1976, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Branimir", 0, "Nikolić", "8429674713357", "Banja Luka", "Bosnia and Herzegovina", 3, "Svetozara Markovića", "branimir.nikolic@test.com", "+13347653436" },
                    { 19, new DateTime(1980, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Ana", 1, "Janković", "3028845697865", "Beograd", "Serbia", 7, "Njegoševa", "ana.jankovic@test.com", "+84037521250" },
                    { 20, new DateTime(1963, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Nikola", 0, "Stanković", "1452161315388", "Banja Luka", "Bosnia and Herzegovina", 2, "Vojvode Stepe", "nikola.stankovic@test.com", "+10874263642" },
                    { 21, new DateTime(1981, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Sanja", 1, "Petrović", "3156918160916", "Novi Sad", "Serbia", 10, "Kralja Milutina", "sanja.petrovic@test.com", "+71062811769" },
                    { 22, new DateTime(1979, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Miloš", 0, "Jovanović", "8897166904311", "Prijedor", "Bosnia and Herzegovina", 15, "Bulevar Oslobođenja", "milos.jovanovic@test.com", "+57155145494" },
                    { 23, new DateTime(1962, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Tatjana", 1, "Stojanović", "2177424551788", "Novi Sad", "Serbia", 8, "Kralja Petra I", "tatjana.stojanovic@test.com", "+23605581860" },
                    { 24, new DateTime(1995, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Vladimir", 0, "Stanković", "8741160800005", "Bijeljina", "Bosnia and Herzegovina", 22, "Vuka Karadžića", "vladimir.stankovic@test.com", "+82212243345" },
                    { 25, new DateTime(1973, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Ivana", 1, "Janković", "5617188586219", "Beograd", "Serbia", 11, "Branka Ćopića", "ivana.jankovic@test.com", "+58203231888" },
                    { 26, new DateTime(1984, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Nenad", 0, "Petrović", "6520612354914", "Banja Luka", "Bosnia and Herzegovina", 7, "Đure Jakšića", "nenad.petrovic@test.com", "+99416097033" },
                    { 27, new DateTime(1967, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Milica", 1, "Ilić", "1935874344624", "Novi Sad", "Serbia", 16, "Kraljice Natalije", "milica.ilic@test.com", "+55304348965" },
                    { 28, new DateTime(1979, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Banja Luka, Medical Faculty", "Vladan", 0, "Đorđević", "3489065914101", "Banja Luka", "Bosnia and Herzegovina", 5, "Stevana Mokranjca", "vladan.djordjevic@test.com", "+38650794505" },
                    { 29, new DateTime(1982, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Belgrade, Medical Faculty", "Sara", 1, "Pavlović", "4125876437223", "Beograd", "Serbia", 18, "Jug Bogdanova", "sara.pavlovic@test.com", "+89276300463" },
                    { 30, new DateTime(1986, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "University of Novi Sad, Medical Faculty", "Nemanja", 0, "Stanišić", "3599860543448", "Banja Luka", "Bosnia and Herzegovina", 4, "Desanke Maksimović", "nemanja.stanisic@test.com", "+56960419861" },
                    { 31, new DateTime(1998, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", "Ksenija", 1, "Marković", "5542176707587", "Banja Luka", "Bosnia and Herzegovina", 10, "Svetog Save", "ksenija.markovic@test.com", "+29561283990" },
                    { 32, new DateTime(1995, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", "Milica", 1, "Simeunović", "4105743375972", "Banja Luka", "Bosnia and Herzegovina", 7, "Vojvode Putnika", "milica.simeunovic@test.com", "+11368648855" },
                    { 33, new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", "Petar", 0, "Tomić", "5708784560193", "Banja Luka", "Bosnia and Herzegovina", 22, "Kralja Petra I", "petar.tomic@test.com", "+60329183115" },
                    { 34, new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "CounterWorker", "Medical High School, Banja Luka", "Ana", 1, "Jovanović", "3318802490291", "Banja Luka", "Bosnia and Herzegovina", 33, "Desanke Maksimović", "ana.jovanovic@test.com", "+66102124422" }
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
                table: "UserAccounts",
                columns: new[] { "Id", "EmployeeId", "Password", "Username" },
                values: new object[,]
                {
                    { 1, 1, "eESUiBPJLQ/s4CMXRZ6QZgXE2k/VbM5+QC1XNdpR7TA=", "marko.petrovic1" },
                    { 2, 2, "tmh4kL6Kj+aAlli2JuVvxEwfM+DCo7K+zV7Nb+NzXgk=", "ana.jovanovic2" },
                    { 3, 3, "rb9ClnCFci1dATS1bF1fKPW+dK9VIQYENH3QobXmkFM=", "nikola.stojanovic3" },
                    { 4, 4, "8vc5vplkQcG0tCR4dhcHgO/gibJLWFkJsZsfpwHum60=", "milan.popovic4" },
                    { 5, 5, "Z7TOhn2+TphnOSCh69fEszh7HYrJ1rsEVfIbfXjvGfs=", "jovana.nikolic5" },
                    { 6, 6, "EHP0K4G7nZESTMC8QObiSUAsjUCpHQL3waqFYr/bs/0=", "stefan.ilic6" },
                    { 7, 7, "Kj3uvEwBgBUH63vjqg/31Mif4W161bEyv+yAc4wCLqU=", "marija.pavlovic7" },
                    { 8, 8, "lHxoiDJxD0YhPdDWPmEdiY6ZxgJBpbvbvECh749kSK8=", "aleksandar.djordjevic8" },
                    { 9, 9, "ABIgJbyqGzRdpXNDVu5VX29suSgUHmDhscYOcEp1pL4=", "ana.jankovic9" },
                    { 10, 10, "MiPz131hmHi1XpC0SaTuD2f4MpuDrlms7dnlrCuAHIM=", "petar.stankovic10" },
                    { 11, 11, "sJaf1zIZn9LbgAYmXpDLmLEHxD4QI8/4dvQ4nrV7hg8=", "jelena.petrovic11" },
                    { 12, 12, "/cKh+rVsE99W5bIs4PCMq8iy7pYuB1wVIDsVdqFjkrI=", "dragan.kovacevic12" },
                    { 13, 13, "ePuTCLRUZoEFNlTlWHY5ZNunTltyviJECsqld+VeTQk=", "milica.ivanovic13" },
                    { 14, 14, "me8plQoA6wDHr6tOT5WDGd0CRol502zeZ01WD123vnw=", "nemanja.jovic14" },
                    { 15, 15, "oyp8I0a1DoQTCxH0iIuOb80DA7PGCsAJhsJLCtFVqqU=", "mina.pavlovic15" },
                    { 16, 16, "KG0SiGyv73f4er6WDUKTcvNvwZLEgpcI4/PZVgH+DZk=", "vladimir.stanisic16" },
                    { 17, 17, "Q9ULJHow9ABdRGP7u36vw2xrrapWSVjgixrVWyv8DQQ=", "jovanka.djordjevic17" },
                    { 18, 18, "+7il6G6rCI6QNidGnW/vQGFNFLPc3ihiCKrnqFOTOJ4=", "branimir.nikolic18" },
                    { 19, 19, "KpW3sAeAwyaI0prN0DKRtsoWnb2Z7tbVniVAI6Izxi4=", "ana.jankovic19" },
                    { 20, 20, "Uow46Y+l3Ay/hRyEmlNugioCnnhT2IuPjaaG75BcTsE=", "nikola.stankovic20" },
                    { 21, 21, "yJKlI7xdCsM3JYHtjhvop04ADVrYkqOJ/hKGYMmh0/g=", "sanja.petrovic21" },
                    { 22, 22, "/UssdFSw0+558PMPhS1POSU2tjbPYtYOJzSA7XUOMog=", "milos.jovanovic22" },
                    { 23, 23, "44IGSFhstzcDUmhTe6M4Z/KssToE8tSy2vG6ggn81vY=", "tatjana.stojanovic23" },
                    { 24, 24, "TF9XFyEy/WxKm0G+5Fhjpio5Oot7zIW2T/P2mNR2O9w=", "vladimir.stankovic24" },
                    { 25, 25, "qBhnbx8tXbGK0rLRy39RNJIjMYX7SS06I8KnyTBtk9Q=", "ivana.jankovic25" },
                    { 26, 26, "MFuDfJosLdAjWwopTmnyr4pa6R3sCIlB/i16crTlROo=", "nenad.petrovic26" },
                    { 27, 27, "COFH5IWyq4cYSnX1abXsHr4FZQqq7RrZUVLZHTSRLUo=", "milica.ilic27" },
                    { 28, 28, "Py/RFAy3B6i2ANiwPdVkqaQJakpjkKCJjSV/1TSoU7s=", "vladan.djordjevic28" },
                    { 29, 29, "Go3RakYLQ/g8ovKyoT5R1XJYRMkhqPz+zV/C8gVYu5E=", "sara.pavlovic29" },
                    { 30, 30, "ROPw0GUTGxouB4+yWRVtk29BUILTT3IrnsnySVt0NDY=", "nemanja.stanisic30" },
                    { 31, 31, "7nJpngTuuD72k1l646OxwdyvNyt/+/5ZxSgxsS8z/Jc=", "ksenija.markovic31" },
                    { 32, 32, "GtcieDv+kU/Lq8kwEiDOV/U7QM+yZLIEMhy0dRz0kIo=", "milica.simeunovic32" },
                    { 33, 33, "MuNTgCJTqvnDqtV14+v7IGgmIA6jNXfKTELBcxB4ECI=", "petar.tomic33" },
                    { 34, 34, "s6iZf5LkTbE3sAyW5eVBboT5bdMVwmdk1C9cELCfX/w=", "ana.jovanovic34" }
                });

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
                name: "IX_UserAccounts_EmployeeId",
                table: "UserAccounts",
                column: "EmployeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "doctor_medicalspecialization");

            migrationBuilder.DropTable(
                name: "healthrecord_medicalcondition");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "MedicalSpecializations");

            migrationBuilder.DropTable(
                name: "HealthRecords");

            migrationBuilder.DropTable(
                name: "MedicalConditions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
