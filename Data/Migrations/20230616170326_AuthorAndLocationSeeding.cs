using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorAndLocationSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "eaadc6c2-3a90-4a27-b16c-db6a231f1a7a", "Kristina.Durgan@gmail.com", "df5c3df5d6e68e9f2755c84c80308b0fe2fe6395", "6423f946-2a9e-4016-8894-1b039b82de8c", "Kristina.Durgan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8782fb79-affb-43a1-8bfb-a5e93e10447c", "Tamara32@gmail.com", "60009f9dd09ae790d716ab2ee3eca6b0f178654a", "88b75199-45fe-46ea-82e0-feb85fc0ab29", "Tamara32@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "510d6df4-7706-4798-9e96-415915903a62", "Gerardo61@gmail.com", "1ac30d60ebe7dac8b45e1af20d0f4e104791c814", "bce57c8d-260d-4696-b8b4-ec59559b01a6", "Gerardo61@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "04069bc6-eaa8-40ae-ae32-afb925ff3b60", "Ebony52@hotmail.com", "c4d668b374690e2591da9a73ce091901124fd188", "f4ecfb55-3d71-4766-9521-fced2f955c31", "Ebony52@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "831a4bc9-2e61-49cc-a69d-5920b8f0d750", "Kim27@gmail.com", "42f7a95c9f7109470ecd1f751735514985b50267", "784c9fb1-ef15-4dd7-8f1e-55dec5ab66de", "Kim27@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6b650e51-ad5f-47a9-8026-1a5c5e5cdc7c", "Agnes.Yundt@hotmail.com", "f9917e952a00f2ec6e3d62e3d1bad3aec85ae80d", "99f7014e-4302-4179-b135-3ba33191a810", "Agnes.Yundt@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "604c41b2-011b-411b-a683-b23d0aee2d92", "Claude86@hotmail.com", "b384869f37a1ada40a74f3c140c0737be608a76a", "a984ebfc-cb18-4d67-864c-0e63b24599f2", "Claude86@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b4780a5c-5078-49f9-b46e-aa2338c78206", "Christina0@gmail.com", "b7679efee3322d4145be4ebe08c4573b44919cdc", "a47a4084-f240-4612-8bc6-96e854f3bacd", "Christina0@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4f33be62-7738-4a19-9830-c11e847d6365", "Opal.Corkery@hotmail.com", "dfcd949c731b0f1378cbc32c8d4dff74c0cda66e", "712fc50a-c654-4c36-a52a-668d9ba0dcbf", "Opal.Corkery@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc96eb5e-fea9-4f14-9d05-6fc0f9c6dbca", "Christy.OHara@gmail.com", "00b95a1f2619de325e8f18e4357fc88f06c442ce", "b666cd2d-ebdd-4ab8-be0f-5cada7d4dc2c", "Christy.OHara@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11", 0, "3b0bbb63-1f78-46c8-aa9d-085099091b5a", "Wayne.Leffler28@yahoo.com", true, false, null, null, null, "efc21f7576f96fd0fdecfb0b0a0e94ca1a0c5356", null, false, "aafa77bb-5ae8-4c51-8e3e-507600ad5329", false, "Wayne.Leffler28@yahoo.com" },
                    { "12", 0, "b928d289-1d05-416d-9bc5-7404791803b6", "Wendell.Wyman@gmail.com", true, false, null, null, null, "5a2bfc30a997a95b0f942cd288f74b4585806c59", null, false, "61040821-b596-4eaa-8f57-1e3f52f83409", false, "Wendell.Wyman@gmail.com" },
                    { "13", 0, "83334451-d33c-40f7-8045-ce9428595249", "Leticia_Schinner95@yahoo.com", true, false, null, null, null, "3f0ace7cedfc73a7a7ae2df48622e67d7d542255", null, false, "4cbe7637-61fd-44e6-94f6-8fe5356339dd", false, "Leticia_Schinner95@yahoo.com" },
                    { "14", 0, "3b541d52-71f2-4b23-ba41-a843f70b9c1d", "Pearl.Kovacek39@hotmail.com", true, false, null, null, null, "80e6803c80d09429a0ab0587e7e9d2d7ac095252", null, false, "a3d38023-c518-45ec-bb57-b6aa9082ca75", false, "Pearl.Kovacek39@hotmail.com" },
                    { "15", 0, "c514aa6a-da22-457d-be4c-11ee3cc7cded", "Minnie_Macejkovic91@gmail.com", true, false, null, null, null, "bf7ea2839bf7d869a21c74b8885bf1b1f6549137", null, false, "73c341e2-02b1-4c97-a182-ede6d12722a7", false, "Minnie_Macejkovic91@gmail.com" },
                    { "16", 0, "61cb003d-c08b-46ca-8c10-1a5ec1d9cf5c", "Amos.Ward@yahoo.com", true, false, null, null, null, "7f7655c3b37a412265cc863e6be7a9a35ab755ea", null, false, "64c108d9-aaee-4d83-a9a5-4a6447876788", false, "Amos.Ward@yahoo.com" },
                    { "17", 0, "bb9d9564-e28c-42d0-9652-1cbf942a773a", "Isaac.Dibbert@gmail.com", true, false, null, null, null, "067a8d69033f52738cf7029fc5a60db6aee17156", null, false, "9f98cadb-ecfc-4f2e-bce6-4e9b3a84a842", false, "Isaac.Dibbert@gmail.com" },
                    { "18", 0, "6da2b5f2-1d23-49a4-a61e-cb4e84b4c680", "Teresa_OReilly@hotmail.com", true, false, null, null, null, "3050fbca165a079885ad1b4428cfd0070fbfbdea", null, false, "42752e60-1870-47fc-8ec4-7ddae1fd78b6", false, "Teresa_OReilly@hotmail.com" },
                    { "19", 0, "bbb43f8b-0cf1-47bf-afb0-fed5e283b297", "Lonnie3@yahoo.com", true, false, null, null, null, "167de33986cd59082ff7183df5fc8bc8e1185476", null, false, "d958dbaf-24e0-4b33-9974-27b32222259c", false, "Lonnie3@yahoo.com" },
                    { "20", 0, "13953dc6-2ecf-47e9-afd2-89c0206f2304", "Wendy78@gmail.com", true, false, null, null, null, "99905911f3f4e5ccb08bc65db1856f2e48067eab", null, false, "c887101c-8ba0-48e0-a4da-ce8cac3b9614", false, "Wendy78@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 50, "Vickie O'Connell" },
                    { 2, 50, "Lula Emard" },
                    { 3, 50, "Ben Friesen" },
                    { 4, 50, "Patty Gulgowski" },
                    { 5, 50, "Preston Strosin" },
                    { 6, 50, "Marcos Steuber" },
                    { 7, 50, "Homer Kilback" },
                    { 8, 50, "Lance Jenkins" },
                    { 9, 50, "Victoria Maggio" },
                    { 10, 50, "Julia Hermann" },
                    { 11, 50, "Erma Haley" },
                    { 12, 50, "Darrel Kub" },
                    { 13, 50, "Santiago O'Hara" },
                    { 14, 50, "Dominic Stark" },
                    { 15, 50, "Pat Rippin" },
                    { 16, 50, "Barry Bosco" },
                    { 17, 50, "Bill Walker" },
                    { 18, 50, "Jonathon Rempel" },
                    { 19, 50, "Robyn Kunde" },
                    { 20, 50, "Pat Fisher" }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9482), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9549), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9572), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9596), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9618), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9637), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9660), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9730), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9729) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9751), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9793), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9857), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9890), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9889) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9938), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9964), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9985), new DateTime(2023, 6, 16, 19, 3, 26, 26, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Verdieping 1" },
                    { 2, "Verdieping 2" },
                    { 3, "Verdieping 3" },
                    { 4, "Verdieping 4" },
                    { 5, "Verdieping 5" },
                    { 6, "Verdieping 6" },
                    { 7, "Verdieping 7" },
                    { 8, "Verdieping 8" },
                    { 9, "Verdieping 9" },
                    { 10, "Verdieping 10" },
                    { 11, "Verdieping 11" },
                    { 12, "Verdieping 12" },
                    { 13, "Verdieping 13" },
                    { 14, "Verdieping 14" },
                    { 15, "Verdieping 15" },
                    { 16, "Verdieping 16" },
                    { 17, "Verdieping 17" },
                    { 18, "Verdieping 18" },
                    { 19, "Verdieping 19" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5e913b74-5d86-470e-bbc6-47ba5e2b98a7", "Keith64@gmail.com", "0610b364bf6063f5b85d08eba3104f18b2b79971", "745bb7b4-a8f6-41d3-aabc-b874b4d6d4d0", "Keith64@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c261dc9a-0a68-4173-9394-e9d820accd66", "Dixie.Halvorson88@yahoo.com", "1350c77b7d9028a07ee7732d7723afca1f467593", "252c14f9-ea2b-4b09-b97a-d49163b318ec", "Dixie.Halvorson88@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "41029a7b-8d84-4a75-b941-8ec34f298f9c", "Don.Batz@yahoo.com", "f11914ac12da4ab57edd372554e1a625844bb17c", "db1464c7-27f2-4c65-a899-fe4cfbd5ebad", "Don.Batz@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0616e5cf-edfd-4307-89d9-38d7ae448e78", "Audrey_Willms47@gmail.com", "eb04c3bdabd1eec514c65b9de8509239ecfaac8d", "dd2f4732-1155-4322-a835-9b9a217e26b3", "Audrey_Willms47@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "42da2dad-7b98-4ce3-adfb-45a412f7960a", "Amy31@yahoo.com", "ac57eb85a1607cc670a8908fe3500391458eaabb", "8b9c1fb5-4d3e-400b-98b0-0bd8ce65ac74", "Amy31@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "01f11363-df9f-4af9-bc50-3655a00db403", "Sarah.Harvey@yahoo.com", "32b13acd7ae9f2af4079425e90028dd38dfc8635", "c244412d-3ddc-4216-b027-2e920c264d4b", "Sarah.Harvey@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1f0d7720-1eac-4004-b38a-a7d0385edd93", "Gregg24@hotmail.com", "4df9dce2afd35e84f84b6c5b4c8a0b01c4f21302", "677a0681-2694-44d8-a022-231cceeb8913", "Gregg24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c35015de-aa77-4196-b5fc-3a6169091d73", "Isabel_Raynor19@yahoo.com", "ce440c133664b4a2f2f4bb7f0764fa931fec5c0c", "9b9b886e-335c-406e-9891-cce6534e213a", "Isabel_Raynor19@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e3d1ee48-bb41-4447-91b9-8323e8dcb75e", "Marguerite_Stracke29@gmail.com", "43eec400df817b70a4f3716237843435cefa0e12", "e7789cd1-0311-4611-9f2c-98c3e9d8eeab", "Marguerite_Stracke29@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e5e912b1-5236-4c66-8acd-516bfb1b5311", "Sally_Price@hotmail.com", "695fbeda67510173dada862d56e42d31ed70cf9b", "abd9e69e-beed-494c-a8fe-0085f6652b7a", "Sally_Price@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7198), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7224), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7241), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7257), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7274), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7314), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7362), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7379), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7394), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7409), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7408) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7424), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7459), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7478), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7495), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7512), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7544), new DateTime(2023, 6, 16, 17, 43, 27, 24, DateTimeKind.Local).AddTicks(7543) });
        }
    }
}
