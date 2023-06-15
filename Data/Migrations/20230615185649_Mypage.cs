using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mypage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Loans",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "12e12bfe-59a1-4ffe-93e9-6a985e398715", "Lowell.Treutel@yahoo.com", "f9e543c8dbe96279d607bc1576b4465fb5bfe5d9", "d4f8bffb-cbb6-4133-8dbc-733a418ce3c4", "Lowell.Treutel@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c5454294-690e-4bbd-8a0e-25fd6674ebe1", "Yvette82@gmail.com", "4b455766a4f6b0cec8ef0f0c91b6c23ad8269267", "5d79eff2-e162-4162-8521-0421fc99e634", "Yvette82@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6f4feb10-2aaf-4df3-9699-fafb8f2f75f7", "Ralph.Larson@yahoo.com", "cb7aea85ccae25e505ada786b8a186f85e83dc4f", "72530e80-b5af-42aa-aa03-1771d79cce8a", "Ralph.Larson@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05c3960f-e290-49e3-b094-d3fb9374a18b", "Simon_Sipes80@hotmail.com", "b2f5c1b50441baa42884223260eb030766087632", "a2720861-cff9-415b-be5c-36a727621c13", "Simon_Sipes80@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0526e6f8-51cc-4584-abf4-1b7d72287cbe", "Warren.Rice@gmail.com", "f47bb26bb1f17058848b96c5d0fbb62a2c87d9ef", "54fc29be-cc50-4190-8282-cc2d821071c6", "Warren.Rice@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b8f88555-6b4b-4bdf-b8a4-08eb02915c84", "Colin.Windler46@gmail.com", "77dba1cdbacb021ef7f94b9911f68b42c0820a7d", "dcc5c328-022c-45bf-88ca-9c7754ac0778", "Colin.Windler46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "010151ca-9e65-4e36-938a-2370611d45f0", "Roberta14@yahoo.com", "3e7da2eb379bd8de1cde8992eaee24a0474d9e4f", "2ba5745d-7426-485f-b01a-c8dcf256ccca", "Roberta14@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "84cc4d6e-3c73-42da-b3b5-c3d7698902b0", "Rodney.Mueller@yahoo.com", "cdff1b7b44870789247cd97ef9ed5289266d7be5", "e5b73c03-a7bf-470c-ad70-057ba4fe7ed5", "Rodney.Mueller@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ecc7c193-07ae-4196-8b55-dad1b0eedba2", "Irvin_Erdman@hotmail.com", "d3efb3a7851c7778b3589dddff27283c39c77325", "518c0d69-4888-40a2-82f6-1fa7ca4bf1d1", "Irvin_Erdman@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5f58ab95-dfec-4b45-86f2-8c667648d45f", "Eugene.Zboncak@yahoo.com", "04e943f5cbed8325931cc5d2bc33987fe7731560", "3f244c29-a5c6-4070-9ae0-651bb79a5737", "Eugene.Zboncak@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1083), "1" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1217), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1215), "2" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1247), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1246), "3" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1263), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1261), "4" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1309), "5" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1330), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1328), "6" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1347), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1345), "7" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1361), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1360), "8" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1377), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1375), "9" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1394), "10" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1411), "11" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1427), "12" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1445), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1444), "13" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1460), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1458), "14" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1474), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1473), "15" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1520), "16" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1539), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1537), "17" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1555), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1553), "18" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1569), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1568), "19" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1583), "20" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1601), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1599), "21" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1616), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1615), "22" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1631), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1630), "23" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1646), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1644), "24" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1660), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1659), "25" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1707), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1705), "26" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1720), "27" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1737), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1735), "28" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1752), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1750), "29" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1766), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1765), "30" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1781), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1780), "31" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1794), "32" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1810), "33" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1827), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1826), "34" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1869), "35" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1888), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1887), "36" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1904), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1902), "37" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1918), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1916), "38" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1933), "39" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1950), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1948), "40" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1963), "41" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1980), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1978), "42" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1996), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(1994), "43" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2010), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2009), "44" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2027), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2025), "45" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2071), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2069), "46" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2087), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2085), "47" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2102), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2101), "48" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2116), "49" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2133), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2131), "50" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2145), "51" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2184), "52" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2198), "53" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2215), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2214), "54" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2230), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2229), "55" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2247), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2245), "56" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2288), "57" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2303), "58" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2320), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2319), "59" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2337), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2336), "60" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2351), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2350), "61" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2365), "62" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2382), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2380), "63" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2397), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2396), "64" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2415), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2413), "65" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2472), "66" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2489), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2487), "67" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2506), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2503), "68" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2520), "69" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2534), "70" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2550), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2548), "71" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2563), "72" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2578), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2577), "73" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2593), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2592), "74" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2607), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2606), "75" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2649), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2647), "76" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2665), "77" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2680), "78" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2695), "79" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2712), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2711), "80" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2727), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2726), "81" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2741), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2740), "82" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2754), "83" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2769), "84" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2785), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2784), "85" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2798), "86" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2843), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2841), "87" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2858), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2856), "88" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2871), "89" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2884), "90" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2909), "91" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2938), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2935), "92" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2962), "93" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(2988), "94" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3014), "95" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3043), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3041), "96" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3066), "97" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3132), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3129), "98" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3159), new DateTime(2023, 6, 15, 20, 56, 49, 317, DateTimeKind.Local).AddTicks(3157), "99" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Loans",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe78a417-947b-4a1c-8acd-717f1aec1a0b", "Carroll.Farrell3@hotmail.com", "5ac8446de8a8fcbfc2534b6043746cb903fdc707", "947940f7-b435-4c9c-910c-00d350bf64f1", "Carroll.Farrell3@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ea2b1313-02cf-4bdc-86c8-a3f3b1e5322a", "Inez.Kuphal@gmail.com", "56e27e33e83a8dd246bdd49dd63249c158278446", "a3304dc7-2d65-4473-acb2-0d17be6cc41a", "Inez.Kuphal@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6f5485f6-f5d2-4dec-9267-4960a3dcfb4b", "Joy.Mohr66@yahoo.com", "261977f1440a7c581a6373a9474252d330f3343a", "0202e6c1-48f8-4911-a8e1-097a88b53c92", "Joy.Mohr66@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "240f5d8c-2e14-4ce0-aa82-db341e134566", "Percy.Hagenes55@hotmail.com", "5d7dbc6bedf204ed5e8c2b5357283b2187a497a0", "b866380d-354f-4cdd-909d-2dcad24bdafc", "Percy.Hagenes55@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ed727dd0-04f0-4285-aab6-317065dbe438", "Horace_Gleichner43@hotmail.com", "13448d74c5f49c57924bd2164534cd1458a1cb24", "1a820da6-8ad4-44bf-9589-3c280fdd197a", "Horace_Gleichner43@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "19e00ee7-37c5-49ca-8be4-ba730ad0e6c4", "Allen_Hyatt71@hotmail.com", "9e58da99471d5f4e7a1d00e6cfcd3ede86ef8b7e", "da22eeee-1752-4ff2-9689-6e94f4ad6d97", "Allen_Hyatt71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d44ec2f8-d025-48bc-a1c6-1185f8fa0827", "Lucy.Krajcik23@gmail.com", "8f4e257b3dc9759ad8bd85ccfee9f5aa57e1102f", "4708de32-9114-463a-941d-c5b4a059111b", "Lucy.Krajcik23@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "daa57ac0-073f-48f4-b712-b30767c16de4", "Janet.Steuber@hotmail.com", "066645386e8d5f1552d9d7afa5f1ab54873ceb78", "dd1249ea-5590-4c55-94b0-3084b9c045fe", "Janet.Steuber@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c11047d2-4387-4a3a-ab06-0512ef127f14", "Wilma_Berge17@hotmail.com", "4650eb0620845c8d86e45f5d714d879b3abf8fa0", "513d53ed-ff1b-4f32-b2dd-dd337bb956df", "Wilma_Berge17@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3f3e597f-7c8c-41bc-8f0e-3b0e8fb10d37", "Debbie.Stracke33@yahoo.com", "8d7244ad27750735c489050cc6e667aef7117c0d", "40bca8b8-c7a9-474e-9b33-7468eddb71ba", "Debbie.Stracke33@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(194), 1 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(360), 2 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(400), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(398), 3 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(425), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(422), 4 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(451), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(449), 5 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(476), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(474), 6 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(537), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(535), 7 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(561), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(559), 8 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(585), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(583), 9 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(610), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(608), 10 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(632), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(630), 11 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(654), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(652), 12 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(677), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(675), 13 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(699), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(697), 14 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(724), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(721), 15 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(747), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(745), 16 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(772), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(770), 17 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(845), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(843), 18 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(868), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(866), 19 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(891), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(889), 20 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(914), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(912), 21 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(936), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(934), 22 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(960), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(958), 23 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(983), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(981), 24 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1007), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1005), 25 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1029), 26 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1055), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1053), 27 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1079), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1077), 28 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1136), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1134), 29 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1159), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1157), 30 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1181), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1179), 31 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1204), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1202), 32 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1228), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1227), 33 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1253), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1251), 34 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1275), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1273), 35 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1297), 36 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1322), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1320), 37 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1381), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1379), 38 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1405), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1403), 39 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1428), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1426), 40 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1448), 41 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1473), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1471), 42 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1494), 43 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1518), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1516), 44 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1542), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1540), 45 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1564), 46 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1586), 47 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1613), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1611), 48 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1637), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1635), 49 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1696), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1693), 50 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1719), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1717), 51 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1743), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1741), 52 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1765), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1763), 53 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1787), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1785), 54 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1808), 55 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1832), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1831), 56 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1855), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1853), 57 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1878), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1876), 58 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1901), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1899), 59 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1925), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1923), 60 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1981), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(1979), 61 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2001), 62 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2026), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2024), 63 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2049), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2047), 64 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2076), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2074), 65 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2098), 66 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2123), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2121), 67 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2145), 68 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2167), 69 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2228), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2226), 70 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2251), 71 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2274), 72 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2297), 73 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2322), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2320), 74 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2346), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2344), 75 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2368), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2366), 76 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2390), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2388), 77 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2413), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2411), 78 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2433), 79 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2456), 80 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2512), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2510), 81 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2536), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2534), 82 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2556), 83 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2579), 84 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2604), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2602), 85 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2627), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2625), 86 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2650), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2648), 87 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2671), 88 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2696), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2694), 89 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2719), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2717), 90 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2742), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2740), 91 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2799), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2797), 92 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2823), 93 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2847), 94 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2872), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2870), 95 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2895), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2893), 96 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2916), 97 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2941), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2939), 98 });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndDate", "StartDate", "UserId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 6, 15, 15, 7, 57, 952, DateTimeKind.Local).AddTicks(2962), 99 });
        }
    }
}
