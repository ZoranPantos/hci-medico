using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitOrders_Employees_CounterWorkerId",
                table: "VisitOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitOrders_Employees_DoctorId",
                table: "VisitOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitOrders_HealthRecords_HealthRecordId",
                table: "VisitOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitOrders_Patients_PatientId",
                table: "VisitOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitOrders",
                table: "VisitOrders");

            migrationBuilder.RenameTable(
                name: "VisitOrders",
                newName: "Appointments");

            migrationBuilder.RenameIndex(
                name: "IX_VisitOrders_PatientId",
                table: "Appointments",
                newName: "IX_Appointments_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitOrders_HealthRecordId",
                table: "Appointments",
                newName: "IX_Appointments_HealthRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitOrders_DoctorId",
                table: "Appointments",
                newName: "IX_Appointments_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_VisitOrders_CounterWorkerId",
                table: "Appointments",
                newName: "IX_Appointments_CounterWorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Employees_CounterWorkerId",
                table: "Appointments",
                column: "CounterWorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Employees_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_HealthRecords_HealthRecordId",
                table: "Appointments",
                column: "HealthRecordId",
                principalTable: "HealthRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Employees_CounterWorkerId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Employees_DoctorId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_HealthRecords_HealthRecordId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "VisitOrders");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_PatientId",
                table: "VisitOrders",
                newName: "IX_VisitOrders_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_HealthRecordId",
                table: "VisitOrders",
                newName: "IX_VisitOrders_HealthRecordId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_DoctorId",
                table: "VisitOrders",
                newName: "IX_VisitOrders_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Appointments_CounterWorkerId",
                table: "VisitOrders",
                newName: "IX_VisitOrders_CounterWorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitOrders",
                table: "VisitOrders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitOrders_Employees_CounterWorkerId",
                table: "VisitOrders",
                column: "CounterWorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitOrders_Employees_DoctorId",
                table: "VisitOrders",
                column: "DoctorId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitOrders_HealthRecords_HealthRecordId",
                table: "VisitOrders",
                column: "HealthRecordId",
                principalTable: "HealthRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitOrders_Patients_PatientId",
                table: "VisitOrders",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
