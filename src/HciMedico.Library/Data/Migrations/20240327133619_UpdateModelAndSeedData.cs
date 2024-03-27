using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Library.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordLastUpdated",
                table: "UserAccounts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "CurrentSalary",
                table: "Employees",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployedSince",
                table: "Employees",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9079460531869", "+88187431655" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6625989698153", "+61739119354" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5966458618539", "+26158565010" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2075320046367", "+73978838020" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3466289137509", "+42868697523" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1802388932835", "+61234982015" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2282125292678", "+46248556280" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5361956574531", "+25761489512" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3677207519147", "+45367962003" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4160788520629", "+98409648042" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8635692151616", "+58025662569" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1448691189816", "+73348764533" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8808334092063", "+51272018184" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7762696989015", "+14958690819" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5949472860162", "+34627849905" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1333774297653", "+65033885718" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2124098964269", "+53053712295" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7333016870949", "+76725290286" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2837265586558", "+67148112906" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9042503429538", "+94224124971" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2726274768656", "+92541973230" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4136675928066", "+83771176593" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4686238089433", "+61295548365" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7147426239508", "+78952684609" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8993795162092", "+69615197107" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5442801994120", "+82472999106" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6340852459316", "+84059081112" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1440341456702", "+69073161718" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2408025876767", "+43448099913" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 2500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4012389267280", "+77301683158" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 1500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2452048082547", "+31824775605" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 1500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "9427653256836", "+96231708687" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 1500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5878783118758", "+81706626932" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CurrentSalary", "EmployedSince", "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { 1500.0, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2333860677780", "+94812124567" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "39749831237", "+63905897716" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "74967310493", "+18307388879" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "61971913574", "+96840056194" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "93566152640", "+90118693833" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "14066490876", "+93970851807" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "60620932390", "+20057170044" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "39628350366", "+26520442818" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "22180481352", "+38434279901" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "73117788759", "+91685285684" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "20722425002", "+68246449685" });

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 3,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 4,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 5,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 6,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 7,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 8,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 9,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 10,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 11,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 12,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 13,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 14,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 15,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 16,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 17,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 18,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 19,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 20,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 21,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 22,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 23,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 24,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 25,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 26,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 27,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 28,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 29,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 30,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 31,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 32,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 33,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserAccounts",
                keyColumn: "Id",
                keyValue: 34,
                column: "PasswordLastUpdated",
                value: new DateTime(2024, 2, 2, 10, 27, 36, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordLastUpdated",
                table: "UserAccounts");

            migrationBuilder.DropColumn(
                name: "CurrentSalary",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployedSince",
                table: "Employees");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5758292473537", "+18709678895" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2264055964011", "+92878946016" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1829990141680", "+16718121181" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2900186252664", "+78287378238" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2323440250403", "+85149575781" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1669116900818", "+61760380733" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1104100255859", "+78899129572" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4413422914957", "+33861275952" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1132924863776", "+76220005251" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7919231186054", "+16181655695" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9059348587172", "+25846591454" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5851760122159", "+57317518334" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8224241829603", "+17658553337" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3585222528465", "+40203307714" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4898333385514", "+35525347752" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4682545979979", "+95856396523" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8771638183872", "+48946149315" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7725469775569", "+61686964999" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1174855542699", "+70029505653" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9711740448955", "+41642598177" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5117060230315", "+57346813137" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5436263254601", "+73157250365" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6112719155153", "+59034428472" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8746142958928", "+24516646483" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3651848060671", "+70607178279" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6195510767788", "+59971704825" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9871079318289", "+32994868200" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1900546831350", "+31481486234" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8148677947310", "+73716837809" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8903664014666", "+84232702585" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9739463427016", "+76976204371" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8724253100001", "+70152052827" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1126878033949", "+18953987301" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2135718916140", "+58891159989" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "49801543363", "+49033706182" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "99132400627", "+84177211636" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "18493346026", "+86933047458" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "55776312544", "+79379988711" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "20877895497", "+35959590848" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "50190925538", "+23461837511" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "21684265337", "+95037616276" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "77759490391", "+69704192389" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "91884772011", "+31868460524" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "96768897860", "+68236527222" });
        }
    }
}
