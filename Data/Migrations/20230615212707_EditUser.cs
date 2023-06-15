using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class EditUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Location", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 10, "J.K. Rowling", "Verdieping 10", "Harry Potter: 10", 2007 },
                    { 11, "J.K. Rowling", "Verdieping 11", "Harry Potter: 11", 2008 },
                    { 12, "J.K. Rowling", "Verdieping 12", "Harry Potter: 12", 2009 },
                    { 13, "J.K. Rowling", "Verdieping 13", "Harry Potter: 13", 2010 },
                    { 14, "J.K. Rowling", "Verdieping 14", "Harry Potter: 14", 2011 },
                    { 15, "J.K. Rowling", "Verdieping 15", "Harry Potter: 15", 2012 },
                    { 16, "J.K. Rowling", "Verdieping 16", "Harry Potter: 16", 2013 },
                    { 17, "J.K. Rowling", "Verdieping 17", "Harry Potter: 17", 2014 },
                    { 18, "J.K. Rowling", "Verdieping 18", "Harry Potter: 18", 2015 },
                    { 19, "J.K. Rowling", "Verdieping 19", "Harry Potter: 19", 2016 }
                });

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

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "EndDate", "ItemId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 10, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5649), 10, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5648), "10" },
                    { 11, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5667), 11, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5666), "11" },
                    { 12, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5685), 12, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5684), "12" },
                    { 13, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5703), 13, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5701), "13" },
                    { 14, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5720), 14, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5719), "14" },
                    { 15, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5736), 15, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5735), "15" },
                    { 16, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5779), 16, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5778), "16" },
                    { 17, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5801), 17, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5799), "17" },
                    { 18, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5819), 18, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5818), "18" },
                    { 19, new DateTime(2023, 7, 6, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5836), 19, new DateTime(2023, 6, 15, 23, 27, 7, 95, DateTimeKind.Local).AddTicks(5835), "19" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a8c898b0-4be1-4ee3-b35c-510449f7e91e", "Pete_Lindgren46@gmail.com", "916cd8d4315173bde42534dc6e1a3aa5da0cfea5", "7798a13f-926b-4612-a4ee-da2582f6cbe1", "Pete_Lindgren46@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4352585c-1c78-4653-a8f7-d31349fb09da", "Estelle_Wolf89@gmail.com", "21322fd1c87a632cbc1383b22410fae78f61fca9", "fa9c98e6-1649-445f-997c-d38ea8a9a368", "Estelle_Wolf89@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f4463818-a98c-4be2-aafb-91a7021cfc5b", "Dwight_Nienow@hotmail.com", "c2514dc5fbf3c9d70736263ef8ddd0c9a870b13b", "89f46f34-8b40-4f4e-a1c6-324fe3269102", "Dwight_Nienow@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "498309b9-6e08-4598-8eb1-f98d2cc99b3d", "Tabitha_Herzog@yahoo.com", "dbe9cbb2d1116d5ca58fb0718aef3288de5c8e01", "098e2a13-d810-4b5e-be61-ad1c5cd9cca3", "Tabitha_Herzog@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e2f77dd4-895b-4ed0-ac1a-9c5b6b8ec4ec", "Domingo.DAmore27@gmail.com", "94db2943c54204a9193adcba1c7a4c1e62f8d58e", "1a48f6f5-6155-4669-8cb3-d3b8bd9b4872", "Domingo.DAmore27@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "91daf7a0-c8dc-465b-ad66-d9e22d5f722d", "Lula.Weimann72@gmail.com", "7b1cb069ca04bd7ec7b922caea978bce8f06474c", "dd503a49-d0fa-4074-9014-d3af3107ac2e", "Lula.Weimann72@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d6397e9f-1e6b-4c3c-91c1-bfacb2809d5d", "Lucas.Ondricka93@hotmail.com", "6834e259b2f54938abd451a53f1ff5381af24fb4", "34e2fd7f-678b-42d0-8240-148de8d3a5b6", "Lucas.Ondricka93@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cd52648a-2f1a-4336-9691-bf0517ff24de", "Victor42@yahoo.com", "6477d969cdd7ccd33c9d8e818fb97f21058f91f4", "b9ba9a36-ef2c-4fcb-abb5-d8f4bd8da036", "Victor42@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d8f6d02-34bd-4216-b1b7-ef736bd3a2ad", "Otis.Davis@yahoo.com", "754d106fad03a0e9a9499dd4ba56196e94d45102", "d7991bf2-8e3b-4f70-9f01-643fa1e23025", "Otis.Davis@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a3cbedc3-6dc7-4bd8-89f3-17049f10a02a", "Elena_Kulas56@yahoo.com", "85f6e269b4f4dd2d73e77bc1de303cc0da449043", "2be223ce-80d8-494b-a11c-ffbc5321f0fd", "Elena_Kulas56@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(8932), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(8975), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(8972) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9007), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9039), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9077), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9112), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9145), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9178), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 6, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9213), new DateTime(2023, 6, 15, 21, 43, 13, 70, DateTimeKind.Local).AddTicks(9210) });
        }
    }
}
