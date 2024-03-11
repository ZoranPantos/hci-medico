using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAndTime",
                table: "VisitOrders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "IdentifierName",
                table: "VisitOrders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "VisitOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_VisitOrders_PatientId",
                table: "VisitOrders",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitOrders_Patients_PatientId",
                table: "VisitOrders",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitOrders_Patients_PatientId",
                table: "VisitOrders");

            migrationBuilder.DropIndex(
                name: "IX_VisitOrders_PatientId",
                table: "VisitOrders");

            migrationBuilder.DropColumn(
                name: "DateAndTime",
                table: "VisitOrders");

            migrationBuilder.DropColumn(
                name: "IdentifierName",
                table: "VisitOrders");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "VisitOrders");
        }
    }
}
