using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorsAndLocations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

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
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 5, 5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 6, 6 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 7, 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 8, 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 9, 9 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 11, 11 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 12, 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 13, 13 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 15, 15 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 16, 16 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 17, 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 18, 18 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "LocationId" },
                values: new object[] { 19, 19 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Authors",
                newName: "Author");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

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
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 3" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 4" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 5" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 6" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 7" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 8" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 9" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 10" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 11" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 12" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 13" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 14" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 15" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 16" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 17" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 18" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Author", "Location" },
                values: new object[] { "J.K. Rowling", "Verdieping 19" });

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
    }
}
