using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class SchemaSetAndDataSeed8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CounterWorkerId", "DateAndTime", "DoctorId", "HealthRecordId", "IdentifierName", "PatientId", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 31, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 0 },
                    { 2, 31, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 3, 31, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 2, "saska macetic", 2, 1, 0 },
                    { 4, 32, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 2, "saska macetic", 2, 1, 1 },
                    { 5, 32, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, "milos milosavljevic", 3, 1, 0 },
                    { 6, 32, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 3, "milos milosavljevic", 3, 1, 1 },
                    { 7, 33, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 0 },
                    { 8, 33, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 },
                    { 9, 33, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "darko darkovic", 5, 1, 0 },
                    { 10, 34, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5, "darko darkovic", 5, 1, 1 },
                    { 11, 34, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, "jovana jovanovic", 6, 1, 0 },
                    { 12, 34, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 6, "jovana jovanovic", 6, 1, 1 },
                    { 13, 31, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, "nikola nikolic", 7, 1, 0 },
                    { 14, 31, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, "nikola nikolic", 7, 1, 1 },
                    { 15, 32, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "david davidovic", 8, 1, 0 },
                    { 16, 32, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8, "david davidovic", 8, 1, 1 },
                    { 17, 33, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, "stana stanojevic", 9, 1, 0 },
                    { 18, 33, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9, "stana stanojevic", 9, 2, 1 },
                    { 19, 34, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, "goran predojevic", 10, 1, 0 },
                    { 20, 34, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10, "goran predojevic", 10, 2, 1 },
                    { 21, 31, new DateTime(2024, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 22, 31, new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 1, "boris borisavljevic", 1, 1, 1 },
                    { 23, 33, new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 },
                    { 24, 33, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "ana stanojevic", 4, 1, 1 }
                });

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

            migrationBuilder.InsertData(
                table: "healthrecord_medicalcondition",
                columns: new[] { "HealthRecordId", "MedicalConditionId", "Status" },
                values: new object[,]
                {
                    { 1, 4, 0 },
                    { 2, 4, 0 },
                    { 3, 4, 0 },
                    { 4, 90, 0 },
                    { 5, 90, 0 },
                    { 6, 90, 0 },
                    { 7, 90, 0 },
                    { 8, 97, 0 },
                    { 9, 97, 0 },
                    { 10, 97, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 4, 90 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 5, 90 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 6, 90 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 7, 90 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 8, 97 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 9, 97 });

            migrationBuilder.DeleteData(
                table: "healthrecord_medicalcondition",
                keyColumns: new[] { "HealthRecordId", "MedicalConditionId" },
                keyValues: new object[] { 10, 97 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9742903008148", "+86343741147" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7950789961742", "+55344039733" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9327073671679", "+51428795145" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5607964224001", "+15408303945" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3381328613236", "+38074785472" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9802706112440", "+49264156603" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1205307808864", "+27686872936" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6668748609216", "+42539432318" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7646453488078", "+43573080374" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3678689087147", "+98758970769" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8704640601340", "+53903184899" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2168688742299", "+18325845888" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2452382633687", "+94530189809" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9794931675816", "+53576141894" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6995122323175", "+35631489408" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9085535162431", "+79581571963" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3909566477715", "+85406656608" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6554413167483", "+15943012962" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9224370969980", "+64719923923" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8086807271629", "+49864053295" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7267164047861", "+24538877442" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4133638904695", "+89187967282" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4524447961645", "+80490684060" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2519836791446", "+35597104817" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5468368078849", "+57148330580" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9863953903000", "+21076048692" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3506269927644", "+68663448824" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5827230426275", "+99982958014" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4019981083698", "+49330173840" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8474326844100", "+90347499782" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9411346698978", "+89255735753" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3144722661967", "+79450126463" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8532657900584", "+73763833381" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7444550525812", "+23728561655" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "56826214251", "+22870938866" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "79752805601", "+16141964865" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "45249971718", "+83545726986" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "30686144516", "+26370549908" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "13841117052", "+71758586728" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "91112135604", "+80480497078" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "66228893530", "+42704492877" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "33094115272", "+12635235829" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "68174140018", "+22819538050" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "86352220548", "+24218123718" });
        }
    }
}
