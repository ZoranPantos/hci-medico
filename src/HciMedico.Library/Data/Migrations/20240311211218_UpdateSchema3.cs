using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalSpecialization_Employees_DoctorsId",
                table: "DoctorMedicalSpecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_DoctorMedicalSpecialization_MedicalSpecializations_Specializ~",
                table: "DoctorMedicalSpecialization");

            migrationBuilder.DropTable(
                name: "HealthRecordMedicalCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DoctorMedicalSpecialization",
                table: "DoctorMedicalSpecialization");

            migrationBuilder.RenameTable(
                name: "DoctorMedicalSpecialization",
                newName: "doctor_medicalspecialization");

            migrationBuilder.RenameIndex(
                name: "IX_DoctorMedicalSpecialization_SpecializationsId",
                table: "doctor_medicalspecialization",
                newName: "IX_doctor_medicalspecialization_SpecializationsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doctor_medicalspecialization",
                table: "doctor_medicalspecialization",
                columns: new[] { "DoctorsId", "SpecializationsId" });

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

            migrationBuilder.CreateIndex(
                name: "IX_healthrecord_medicalcondition_MedicalConditionId",
                table: "healthrecord_medicalcondition",
                column: "MedicalConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalspecialization_Employees_DoctorsId",
                table: "doctor_medicalspecialization",
                column: "DoctorsId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doctor_medicalspecialization_MedicalSpecializations_Speciali~",
                table: "doctor_medicalspecialization",
                column: "SpecializationsId",
                principalTable: "MedicalSpecializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalspecialization_Employees_DoctorsId",
                table: "doctor_medicalspecialization");

            migrationBuilder.DropForeignKey(
                name: "FK_doctor_medicalspecialization_MedicalSpecializations_Speciali~",
                table: "doctor_medicalspecialization");

            migrationBuilder.DropTable(
                name: "healthrecord_medicalcondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doctor_medicalspecialization",
                table: "doctor_medicalspecialization");

            migrationBuilder.RenameTable(
                name: "doctor_medicalspecialization",
                newName: "DoctorMedicalSpecialization");

            migrationBuilder.RenameIndex(
                name: "IX_doctor_medicalspecialization_SpecializationsId",
                table: "DoctorMedicalSpecialization",
                newName: "IX_DoctorMedicalSpecialization_SpecializationsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DoctorMedicalSpecialization",
                table: "DoctorMedicalSpecialization",
                columns: new[] { "DoctorsId", "SpecializationsId" });

            migrationBuilder.CreateTable(
                name: "HealthRecordMedicalCondition",
                columns: table => new
                {
                    HealthRecordsId = table.Column<int>(type: "int", nullable: false),
                    MedicalConditionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthRecordMedicalCondition", x => new { x.HealthRecordsId, x.MedicalConditionsId });
                    table.ForeignKey(
                        name: "FK_HealthRecordMedicalCondition_HealthRecords_HealthRecordsId",
                        column: x => x.HealthRecordsId,
                        principalTable: "HealthRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthRecordMedicalCondition_MedicalConditions_MedicalCondit~",
                        column: x => x.MedicalConditionsId,
                        principalTable: "MedicalConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_HealthRecordMedicalCondition_MedicalConditionsId",
                table: "HealthRecordMedicalCondition",
                column: "MedicalConditionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalSpecialization_Employees_DoctorsId",
                table: "DoctorMedicalSpecialization",
                column: "DoctorsId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DoctorMedicalSpecialization_MedicalSpecializations_Specializ~",
                table: "DoctorMedicalSpecialization",
                column: "SpecializationsId",
                principalTable: "MedicalSpecializations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
