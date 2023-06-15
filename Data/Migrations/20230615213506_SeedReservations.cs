using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7525f946-1550-4efc-8dba-f1652ed4f3c7", "Carolyn.Wiegand@yahoo.com", "48668d6c3a6ea12b154ae38e3bed73f56b90cb8e", "3861cfde-2331-45f9-81fb-20686d00de63", "Carolyn.Wiegand@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "94293b68-6c27-4217-9698-a14af2b66214", "Ira.Dare97@gmail.com", "882fe6a0c35ffc88cdc7eb0f3321211db4718d71", "d4624fc8-0896-44d2-b6d5-876a87d17f22", "Ira.Dare97@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "439f3a9f-9a3c-4d34-a637-bdf8b78fa6b5", "Dianne.Price@yahoo.com", "1d925e9dec5d9eb98db04f4b071cc9e892c7eebd", "441abc5b-e2f5-40f3-abf4-fd9c95d2f2c3", "Dianne.Price@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "31301802-4de8-4569-87fb-50324efe4f69", "Martha38@hotmail.com", "f24c01483ec0c9658f22f12b02e49a93b967c9fc", "830f012e-e846-4543-88fd-14738a110444", "Martha38@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e8d7bc29-591f-4e1f-aebd-0d8762e84406", "Marsha57@hotmail.com", "f67768af66ae95ed22b9a79f54e4e811b6f502fe", "2f5d118a-d400-4f61-a0aa-bf96ef42c744", "Marsha57@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d1f4efe5-a2eb-4faf-93da-5f88c513b746", "Ethel.Ruecker@yahoo.com", "c90c44d4dcfa30e4fb26a803771bedeca9db29ed", "afee418f-c692-4667-bae6-2eac4c2353eb", "Ethel.Ruecker@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a670a5b0-688d-429b-9da2-5fd4716415e4", "Mamie.Ferry@hotmail.com", "cfd8e62dc27f388965ec4f90afafe5caf6e57f24", "de4fa6d4-1d44-4f8a-af82-0fb728ce6a1b", "Mamie.Ferry@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a06a592f-3cbd-4b61-8a72-03333ebdba6e", "Kelley60@hotmail.com", "1bdd4af5e585cd2cd3216537b0d7ef79ac92134b", "14fba08b-694e-405b-98c3-8e5add037ac6", "Kelley60@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "817a9a5a-836f-4701-94eb-11aa5b9d317e", "Eileen.Boyle4@yahoo.com", "cc405d355d1a265196c82bf6294e0d97c8b41748", "450462a5-5c85-4fbb-9a81-2329e5c952e5", "Eileen.Boyle4@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bd4f4c6e-e4f7-4149-b2aa-36aa899056f3", "Lauren7@yahoo.com", "9458192ae1a68096edf834c797077eaccc8a6bff", "bb50b58f-5199-46bd-a4e6-1c681969aa0b", "Lauren7@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5419), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5456), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5455) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5474), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5473) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5491), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5531), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5548), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5567), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5566) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5628), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5649), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5667), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5666) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5685), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5703), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5720), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5736), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5735) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5779), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5778) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5801), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5836), new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5835) });
        }
    }
}
