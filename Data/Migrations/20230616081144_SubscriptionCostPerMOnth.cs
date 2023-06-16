using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SubscriptionCostPerMOnth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubscriptionCostPerMonth",
                table: "Subscriptions",
                newName: "CostPerMonth");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c5cfd811-3e72-41da-9761-354d74b1b81d", "Warren_Dooley63@hotmail.com", "af6ac2486691ea30fa2bef6d2ab37a8677fadc1e", "21119b48-8e36-4fce-82d5-7c8ce783271f", "Warren_Dooley63@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "899266d4-86a1-4b4e-88e6-e49a99c9d8a1", "Jo2@gmail.com", "9f4aa2f7ae1f6682159873bd2dbc0aaf40a14052", "d17a2115-14b6-4afc-8db1-363a595fe8f4", "Jo2@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e38cd454-a905-4689-bde2-126937a386d1", "Sheldon14@hotmail.com", "fe82179f10360e00892caeff923d4679010cfc4d", "ac026aa1-35d3-4449-b173-12a0de686033", "Sheldon14@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e5087f21-58b3-4148-9259-fb8f694e97e2", "Colin_Gibson77@hotmail.com", "2d68c5c90ba400e82271bcd71b23b4a1231c29e3", "76c613aa-6005-4abd-ae14-85b7f3518a79", "Colin_Gibson77@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3fd65ec3-4aa6-4b10-99b9-8407da21e568", "Emanuel51@hotmail.com", "ac96bdac8a8834aac77d01d002fe13b9111612b5", "fc75d67e-0588-483c-bf6d-172faba25692", "Emanuel51@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3fac618c-6f7e-4e53-aefc-30d8ffd9b85d", "Edwin71@hotmail.com", "77a0ad8fd8a59bd4859735bd9c4ea8b408667048", "a8e40644-6b66-4044-9022-6f9e7e38360e", "Edwin71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bcabefe9-458b-4095-bb49-954cea729b11", "Beatrice_Ward@gmail.com", "6967a4bd3cb0a471008e15c2238e7dd4777aedb6", "f2c80e9b-c134-4d19-9a11-54514d482873", "Beatrice_Ward@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6f5531e7-3ee6-4ade-a66f-00b5959bf690", "Deanna.Bruen82@gmail.com", "ec033944b1a3b78614927d3ba9d5170ff803ed1b", "f195058e-b2f6-49c4-9062-ea210f0ce9d7", "Deanna.Bruen82@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1639bbeb-b727-43a4-834b-86db1d593421", "Russell.Deckow@yahoo.com", "02ad3b73e9d7f79410fae57ff57b5e2b0e728d70", "33a6bf6a-700f-4aa7-88a3-523b0051e68e", "Russell.Deckow@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "057c4bb9-1b0a-4218-b05e-ed2ba321e722", "Owen77@gmail.com", "bf3d469dc7451ab2cf655f687dd6c58134046230", "64c6ac9f-82ae-42c9-9e1e-967663041942", "Owen77@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2759), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2789), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2809), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2868), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2892), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2914), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2936), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2958) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2984), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3030), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3082), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3103), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3125), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3124) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3144), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3165), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3187), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3211), new DateTime(2023, 6, 16, 10, 11, 43, 845, DateTimeKind.Local).AddTicks(3209) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CostPerMonth",
                table: "Subscriptions",
                newName: "SubscriptionCostPerMonth");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6b09e1fb-2167-4c11-9dbb-e3aae5866cc4", "Blanche_Turcotte84@yahoo.com", "4e729b21a3ed9585121d34451bc3303bf424386d", "07e8de70-3329-496a-9dd3-315e862533c0", "Blanche_Turcotte84@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0b9c2654-b8f6-4ada-a67c-5c0eab7fd578", "Bethany.Schuster75@gmail.com", "6faedeb3c3a6e242dc301fc45a8edbc8ff553320", "2e1bbb3a-56e3-44a1-bd67-3c46ba97eaec", "Bethany.Schuster75@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8df0010d-bed2-4881-9c84-0e258f709520", "Eduardo_DAmore79@hotmail.com", "e695b70d52395b3f6a28a94ccff723345cf9db86", "ba930388-6af9-4277-95c6-857eaee3dab0", "Eduardo_DAmore79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cddc3c40-4ab8-449f-8237-ddc0832d520e", "Everett6@yahoo.com", "38bf5e194e447a56c76194005cd7cdac849c4133", "a2937c4c-04d7-4408-acf5-938237e98c73", "Everett6@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d46c198f-f8da-43a4-86a8-d242c05552e3", "Kelvin_Ortiz24@hotmail.com", "c0bdcabc96b21ef0992778dae3ec4cb2ea692a39", "b116eacf-0eb9-4f73-aacd-911372a4a832", "Kelvin_Ortiz24@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9deb583d-8c21-4eee-9211-816a8aedb6b3", "Margarita28@hotmail.com", "d36b0916d00ee223d533e81c4fbb9bdff3a26094", "1a14c25f-2de3-4508-978c-df407129ebcb", "Margarita28@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "13b20cc4-f3b9-4c03-94b5-ce22cb557def", "Susan_Connelly86@yahoo.com", "b028fa1c4d79851efcce7922bfc094364d63a8cd", "a3a12763-18c2-4ef9-a497-29ffa2fb631f", "Susan_Connelly86@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "575b0d84-1925-485e-ac85-b73c9effe7ba", "Eunice.Weber@yahoo.com", "c71667f70bb4655d1c3dddaf9c716bdb2f7895f6", "ed5509cf-2700-435f-95b6-e527472f7e72", "Eunice.Weber@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d7ce659a-d2ac-4c67-a00a-d9260461c99e", "Rita_Abbott30@gmail.com", "afd1861bf0c21ac808a246bc1933956edb08b386", "2311ac68-d4fd-4df4-b8ae-0806ad8faa7d", "Rita_Abbott30@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8edfecaa-4842-407d-afd8-f0a7c6fcc63f", "Austin_Marquardt46@gmail.com", "4f6c6ae002a47dbcdcd938b95af7c74a3c575a46", "5ce18c90-8ce7-4324-a709-161b3320a414", "Austin_Marquardt46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9410), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9458), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9457) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9476), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9516), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9535), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9555), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9570), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9586), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9602), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9619), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9634), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9675), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9674) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9693), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9692) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9708), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9707) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9723), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9722) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9739), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9738) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9755), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9754) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9772), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9812), new DateTime(2023, 6, 15, 23, 35, 6, 722, DateTimeKind.Local).AddTicks(9811) });
        }
    }
}
