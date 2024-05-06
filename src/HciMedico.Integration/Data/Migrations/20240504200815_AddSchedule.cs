using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HciMedico.Integration.Migrations
{
    /// <inheritdoc />
    public partial class AddSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedule_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ScheduleCell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ShiftStartTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShiftEndTime = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsCurrentMonth = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsToday = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleCell", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleCell_Schedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.InsertData(
                table: "Schedule",
                columns: new[] { "Id", "EmployeeId" },
                values: new object[] { 1, 31 });

            migrationBuilder.InsertData(
                table: "ScheduleCell",
                columns: new[] { "Id", "DateTime", "IsCurrentMonth", "IsToday", "ScheduleId", "ShiftEndTime", "ShiftStartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9883), false, false, 1, "4 PM", "8 AM" },
                    { 2, new DateTime(2024, 5, 5, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9967), false, false, 1, "4 PM", "8 AM" },
                    { 3, new DateTime(2024, 5, 6, 22, 8, 13, 876, DateTimeKind.Local).AddTicks(9974), false, false, 1, "4 PM", "8 AM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_EmployeeId",
                table: "Schedule",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleCell_ScheduleId",
                table: "ScheduleCell",
                column: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleCell");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3921428382337", "+92526775846" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2852877060785", "+64304424559" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3409886966858", "+50868863770" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8641728475780", "+76848421666" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4622395228536", "+81858268785" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9510184849426", "+97592575982" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3661447676463", "+53438070239" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3315848383688", "+84041060422" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8438012359103", "+86853351441" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9852684965196", "+63885097521" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3232083734562", "+27550936404" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4227122087765", "+13512238640" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5355396389865", "+35084077938" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "6218552195586", "+35892462964" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5280058356465", "+72278619229" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7594452638593", "+81955539719" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1995926219222", "+28410047475" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4212121919541", "+93514487896" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8647014116720", "+52084554549" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2204306841193", "+22820890117" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "4976151784742", "+81603319421" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "1431995226552", "+43436571237" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7327588438110", "+86990888721" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5042481495581", "+86456187249" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "2853535433103", "+55222095055" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "8905172867227", "+21067830574" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5971700382796", "+88903036820" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "3167337212933", "+71364578886" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "7337591336388", "+80745291072" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5679551069941", "+94384643088" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5869020032875", "+81900398116" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "5582070442249", "+66837161156" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9768571063623", "+96229466108" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "9137625729750", "+62182044765" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "89892056240", "+46582407105" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "92830893950", "+82883939570" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "28531119941", "+83759636046" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "21600587674", "+49557199941" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "63006499609", "+37280224839" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "81286725914", "+71697220704" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "97157587487", "+90949098614" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "99431024589", "+88623198675" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "43087298404", "+22589093350" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Uid", "ContactInfo_TelephoneNumber" },
                values: new object[] { "68802090298", "+95564706835" });
        }
    }
}
