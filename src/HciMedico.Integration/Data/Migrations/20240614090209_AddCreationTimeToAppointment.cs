using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Integration.Migrations
{
    /// <inheritdoc />
    public partial class AddCreationTimeToAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "Appointments",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreationTime",
                value: new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8369129430240", "+83369459547" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2389396335409", "+66193191001" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9886946793929", "+58772289198" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6084192318985", "+84062056885" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6923776251320", "+95940250501" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9891895780375", "+42545558931" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8261209377950", "+34671937423" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5844217908583", "+71975658709" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5093349266997", "+56472146174" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4470535199081", "+84401331726" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9278025247299", "+46480453411" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7943982229857", "+24283936851" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5314307485998", "+24497884693" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9734834979901", "+49781889639" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9579170835983", "+68064916663" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9734657711571", "+34852684665" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5107985563020", "+44640654275" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5181703722416", "+73092691755" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1416961770855", "+79681721240" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7905511840528", "+65761463269" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4547807840382", "+29225605679" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6676256245112", "+95050527405" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8834516563289", "+13095931019" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4027033764940", "+37313198359" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2494513672742", "+62322592864" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1353008390685", "+35713052712" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2357498186581", "+11945940144" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5038790201054", "+15366544591" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8886568861578", "+98178623063" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9188889382584", "+99911171112" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7946721457876", "+34549042689" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6453395387726", "+60000103991" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8887234511309", "+78856654119" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9352250731159", "+72940235048" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "15538365551", "+60997472237" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "55666594380", "+18438278869" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "82766983262", "+37292555365" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "24937879078", "+94798953177" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "86698651492", "+84243354506" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "18614237518", "+68891938493" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "41766999261", "+58053506742" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "93157094796", "+21686313337" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "27984406191", "+77786193751" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "82230377248", "+56549066383" });

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 7, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 7, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6182692913468", "+83679435864" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2224337530771", "+41707209635" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3418374383233", "+70996361497" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8810086442217", "+60076306657" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7118757318614", "+50322731519" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7924689259272", "+50470557040" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1130249482138", "+97678482079" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7838120795107", "+33787108190" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8518856884477", "+60328528215" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1100054148859", "+17409189148" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7797886686666", "+82635026258" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8821747055582", "+74229423160" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9436007138409", "+67694960312" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9468394803354", "+62221329372" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7787008069431", "+17538336862" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4387079881850", "+19147268641" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5444778597368", "+13351188974" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2626599717749", "+22816709002" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2181593455005", "+89527128911" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2862925353200", "+56999359671" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4463762547853", "+30338042356" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2161134323133", "+85124800930" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2206652691664", "+26282331171" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5320566509314", "+39523908051" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9638665805672", "+33498149216" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3544179015828", "+27634567529" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1516257739810", "+97974456119" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8246757369877", "+39860831859" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7384709388427", "+69531825919" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3937822325875", "+28146863171" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3293468502656", "+82844663056" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5282112420929", "+71211409806" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8164118783416", "+19570620896" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9851332878853", "+40433493638" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "57176874119", "+20328473828" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "61489454051", "+11903254378" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "87608991267", "+86439479495" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "91766247619", "+24372975530" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "46188942658", "+45866915538" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "18602547054", "+49155150435" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "86772738801", "+89679381128" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "58266375847", "+67934969237" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "34387265389", "+32888996787" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "56376270500", "+54547278837" });

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateTime",
                value: new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateTime",
                value: new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateTime",
                value: new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateTime",
                value: new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateTime",
                value: new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateTime",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateTime",
                value: new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateTime",
                value: new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateTime",
                value: new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateTime",
                value: new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateTime",
                value: new DateTime(2024, 5, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateTime",
                value: new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateTime",
                value: new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateTime",
                value: new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateTime",
                value: new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateTime",
                value: new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateTime",
                value: new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateTime",
                value: new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateTime",
                value: new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateTime",
                value: new DateTime(2024, 4, 29, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "WorkShift",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateTime",
                value: new DateTime(2024, 5, 7, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
