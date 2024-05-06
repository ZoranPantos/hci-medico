using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HciMedico.Integration.Migrations
{
    /// <inheritdoc />
    public partial class ModifySchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCurrentMonth",
                table: "ScheduleCell");

            migrationBuilder.DropColumn(
                name: "IsToday",
                table: "ScheduleCell");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3384262071596", "+15666780343" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2658132836373", "+24790509813" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2532409488793", "+66474628961" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6811678342974", "+42631152442" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9600029282116", "+21617427183" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5276770316741", "+28399531045" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5746927454532", "+79913352656" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4696225976552", "+66005584636" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7114711152551", "+47779209190" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6486480839157", "+14288127379" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3965817553704", "+12426272519" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4156823073724", "+75481418684" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5121821627915", "+87418214193" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5211374836828", "+75364592978" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1802551891335", "+38940577852" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2375820720602", "+29979188755" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9337503975450", "+53699389207" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3983116119577", "+54960399510" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8276723945259", "+61108537903" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4951806759987", "+56500308251" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2047499570457", "+88792195462" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3195966088064", "+82999299228" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4633489903285", "+85135307935" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2660830962391", "+29857232757" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2508353798641", "+63042062184" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2657396575616", "+31786116590" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4180070824325", "+50495557313" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8500496072045", "+90937013781" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3528649539422", "+14347165963" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7126462048419", "+49580719709" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4303949010696", "+24195851934" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8857110795677", "+89272218697" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4109221651666", "+10517792406" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2611841137871", "+80334428669" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "18796195387", "+39198923035" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "61595277446", "+14513963028" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "52274089942", "+32671911461" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "32541094424", "+94152606659" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "41280565351", "+26075943503" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "85887777906", "+22578262881" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "36784459965", "+18146466221" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "33375472335", "+76614776205" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "86840999473", "+83083088753" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "14323167130", "+47968945176" });

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateTime",
                value: new DateTime(2024, 5, 5, 19, 24, 59, 824, DateTimeKind.Local).AddTicks(4862));

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateTime",
                value: new DateTime(2024, 5, 6, 19, 24, 59, 824, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateTime",
                value: new DateTime(2024, 5, 7, 19, 24, 59, 824, DateTimeKind.Local).AddTicks(4953));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCurrentMonth",
                table: "ScheduleCell",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsToday",
                table: "ScheduleCell",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5911405858549", "+21383309732" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6530102297212", "+66989934675" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6074455290252", "+65741355943" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6948183067372", "+88020817196" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2326307679607", "+26929507455" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1357577031357", "+87052234889" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3008600988786", "+15353408920" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3707717114226", "+36711005743" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2712540660505", "+57296284176" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9984214532370", "+16244873254" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1046711308699", "+77413176362" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7078155090894", "+76250818398" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9323684769836", "+52685767584" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2198666979399", "+80634570606" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9966230685083", "+99124280141" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2678453813854", "+84342469099" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2523708122987", "+71571444564" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6674492357931", "+92683930268" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1845155800581", "+89617825008" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1218077665672", "+81374915377" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8299168128488", "+29913340942" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5178509932691", "+88312057689" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9231903990582", "+89523123036" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7856428249527", "+64268419849" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1211146375706", "+38542864170" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1276377318198", "+97403470891" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9735638758747", "+54273544987" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6046950546148", "+33085147317" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4071560360700", "+15122595120" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4752409592766", "+82286149721" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2551887927127", "+76136664084" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2897328051941", "+73108195774" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9251995703922", "+25792962212" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8943595936392", "+26312032113" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "59454162427", "+51480103576" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "53764603955", "+86339809703" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "20188392355", "+96560100709" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "90153331740", "+65718690146" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "12380490422", "+49799576800" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "42683375071", "+89515385839" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "72320553671", "+73058486039" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "32693932282", "+33040795359" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "40049883785", "+21814063908" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "11252528666", "+75121046119" });

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateTime", "IsCurrentMonth", "IsToday" },
                values: new object[] { new DateTime(2024, 5, 4, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9883), false, false });

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateTime", "IsCurrentMonth", "IsToday" },
                values: new object[] { new DateTime(2024, 5, 5, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9967), false, false });

            migrationBuilder.UpdateData(
                table: "ScheduleCell",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateTime", "IsCurrentMonth", "IsToday" },
                values: new object[] { new DateTime(2024, 5, 6, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9974), false, false });
        }
    }
}
