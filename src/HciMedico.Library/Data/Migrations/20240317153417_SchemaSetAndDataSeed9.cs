using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class SchemaSetAndDataSeed9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_HealthRecords_HealthRecordId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HealthRecordId",
                table: "Appointments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CounterWorkerId", "DateAndTime", "DoctorId", "HealthRecordId", "IdentifierName", "PatientId", "Status", "Type" },
                values: new object[,]
                {
                    { 25, 31, new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, "boris borisavljevic", 1, 1, 0 },
                    { 26, 31, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 1, "boris borisavljevic", 1, 0, 1 },
                    { 27, 31, new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, "saska macetic", 2, 1, 0 },
                    { 28, 31, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, "saska macetic", 2, 0, 1 },
                    { 29, 31, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, "milos milosavljevic", 3, 1, 0 },
                    { 30, 31, new DateTime(2025, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, "milos milosavljevic", 3, 0, 1 },
                    { 31, 32, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, null, "lana pepic", null, 0, 0 },
                    { 32, 32, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null, "nikola jokic", null, 0, 0 },
                    { 33, 32, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, "marija novakovic", null, 0, 0 },
                    { 34, 32, new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null, "branko brankovic", null, 0, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8551055957630", "+66401918664" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6014538299707", "+89602569729" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9418079613360", "+74236938178" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6665751157858", "+42222158529" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8160938424745", "+72704618540" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1154613610156", "+36352153701" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7208743508121", "+51080484862" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8102242473707", "+12833313678" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1911010212606", "+16171831317" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9166398493608", "+19957337806" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6740887325446", "+19613421968" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2739059593670", "+74907148620" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7747480278143", "+11579272093" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9867778910698", "+65195371843" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4230894739161", "+92890489605" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8969010138333", "+69322480868" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1331375279721", "+10182243768" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9097040448923", "+48402599942" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3506373940616", "+47532925133" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9343186040370", "+37472090347" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2975409078391", "+29951363645" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7919710257204", "+14940514643" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2113078209488", "+30671925765" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6475570550393", "+21915995833" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3038247033817", "+16522731984" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5045273185843", "+48689310517" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9768452791568", "+43667701756" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4362053292902", "+47497102328" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1163210607112", "+67804205844" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8290927252977", "+45090444483" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4692609407333", "+50317650159" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7638318639758", "+53070677794" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8993082457199", "+88368170434" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5208737580493", "+99598044082" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "44011243331", "+76834629435" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "74378259704", "+15119487370" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "40862017839", "+93102569680" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "75208982851", "+54688848511" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "27435282769", "+58136489301" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "27148463265", "+97041235136" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "75707252530", "+26936981210" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "60222569919", "+17633198757" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "70357632833", "+79190359682" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "80924008849", "+80435080122" });

            migrationBuilder.InsertData(
                table: "healthrecord_medicalcondition",
                columns: new[] { "HealthRecordId", "MedicalConditionId", "Status" },
                values: new object[,]
                {
                    { 1, 24, 1 },
                    { 2, 24, 1 },
                    { 3, 24, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_HealthRecords_HealthRecordId",
                table: "Appointments",
                column: "HealthRecordId",
                principalTable: "HealthRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_HealthRecords_HealthRecordId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientId",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 3, 24 });

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HealthRecordId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9433558208728", "+45937011510" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7211467860786", "+19337415116" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8029500402653", "+72104344336" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1329929251638", "+98421419616" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7339855333972", "+37118708358" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5486946324705", "+54100597014" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6759309708714", "+80425687326" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1281836961638", "+84044409759" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7813202465197", "+73197815981" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4557188213468", "+35875713035" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1836101421936", "+29879402201" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7782487222794", "+53148515378" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4537472466264", "+37502976280" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5139348842558", "+31927002358" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1852946315292", "+99480697790" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2082949394553", "+88063372921" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2332265773459", "+86984978055" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3647727896473", "+29102360505" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4191219180495", "+39507106075" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1352937375144", "+85253201476" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6176435905906", "+13190906675" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6628528064255", "+10079946940" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2007708235834", "+81534577549" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7729246269749", "+33373355870" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6664659112638", "+32471830695" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3116719098222", "+67434419612" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2016155087662", "+53552808976" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4599108110903", "+70180069060" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4073421038336", "+12496169621" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1816458863222", "+17582932439" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2350612656955", "+14382489184" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7679211706590", "+25394056065" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4220398921008", "+14387064569" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6577151156062", "+58494406731" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "72418593746", "+32521743994" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "30815181899", "+81040222562" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "52048382999", "+65198148983" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "21298041880", "+30152344928" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "98627525476", "+50667888715" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "93058071626", "+60649950726" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "11691673630", "+22518257876" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "30539044603", "+40772292032" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "51172253294", "+49023783579" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "65930927813", "+75963599244" });

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
    }
}
