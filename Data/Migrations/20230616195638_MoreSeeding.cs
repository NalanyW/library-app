using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "a81115d5-ba55-491d-b539-6f93e31df7d1", "Milton.Larson@hotmail.com", "f10df3d061e75745a66815354dd1d9ba2553b693", "c030d5e1-26dd-4ed0-b745-d0b26901707a", "Milton.Larson@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "48a37d7a-24df-4bab-8b09-4c459945dd8e", "Alberto_Barton@gmail.com", "37960582a3ceb9d40edc3fbebed7d06ff2a4fa73", "9b0de37b-3553-428b-a71e-449ab0446681", "Alberto_Barton@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5a09b854-0886-469d-9ba0-4b2f335b150d", "Megan_Bayer69@hotmail.com", "10aeddf9a9431996130c4cff5f87925afea47990", "38cbc5cf-99bb-4da9-b1af-42212dd2e3fd", "Megan_Bayer69@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ee1aa107-fc82-453c-a074-896df25c8a16", "Gerardo_Murphy@yahoo.com", "40e255cd19a4866d33846646773606426cb8d718", "6d2da827-8fcd-4cf9-84d3-5f96b837807e", "Gerardo_Murphy@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "58d0a670-6c74-4236-8b66-fef1d16163b7", "Bernard.Wuckert19@hotmail.com", "6ff34567a14469576f903ce6f9c93855beca58ec", "6f4ab276-991b-4f8e-a40d-d6785e4e5de0", "Bernard.Wuckert19@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8810b7a7-7541-4c24-8cfa-34774df72e9c", "Myrtle59@yahoo.com", "98b8bd29388218321571e4d6d67ca16dd5c5b39e", "372e421c-9c0a-4006-b030-b53818ff2d04", "Myrtle59@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fc094ba4-55ac-496c-a507-1b8b983a00f9", "Guadalupe_Dibbert@gmail.com", "07a5ba33d8a7a75efb1df3ee0d413aaea646d2bc", "aa643743-b86d-45c6-82d7-68a0cc1bbfcf", "Guadalupe_Dibbert@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6d449585-7b38-4ddf-9f0c-08d98ddcaeee", "Israel.Olson2@hotmail.com", "8ebf5fb87c4d5b66e21b48bb4ebda84df1505be3", "94b21a93-0e5f-48f0-a49a-2b79bc692b87", "Israel.Olson2@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2af06523-434c-42e9-acf0-19960ddf8775", "Elmer43@gmail.com", "477914407f0183d418fb8c250172913fa3b70c98", "0c495ab5-9e39-433f-a23b-49d0bd1fe78d", "Elmer43@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "57669d87-023c-437e-931b-7f884c64cc3c", "Rosemary_Powlowski89@yahoo.com", "a5ceb0815876d345508a1e807c6d2f40950af1b4", "d0b69724-57ff-4bde-9edf-6100e4244cc5", "Rosemary_Powlowski89@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c67d2dad-6735-4b06-903e-252bf9635a63", "Omar_Swift17@gmail.com", "b3a3b1c9b5707270beb4845ae191f062a9e4c203", "908e6b9b-4b6e-4746-ae73-8c5bab5b4726", "Omar_Swift17@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "084decb5-5886-4b66-aa2b-6c4d74ff3b61", "Angela.Boyle2@yahoo.com", "cf52529443e188fbf62f969b9720602074f92cae", "573d0bf1-6b07-4288-8be2-fe20c04736af", "Angela.Boyle2@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ca823392-eb3a-4a19-bd94-77c8f0581559", "Ashley90@gmail.com", "78dac202defd5af6eaa1817a49159898ed47a078", "506336d5-bf2a-4eb7-8d03-be186eb6c73c", "Ashley90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f050aeff-d290-44cc-bcbc-7f5ab10ecbca", "Dennis21@hotmail.com", "3b5e178e34211bb3e38e1baf49d3ea07d37448e3", "72879dc8-57cc-4ff1-890d-65d82e12f9a2", "Dennis21@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aeb31eeb-687c-4d03-8851-c13424071ca6", "Steve88@yahoo.com", "e81eef053e66170db204e19d9e1d7c860d1ddcfa", "e8fcc3a5-192d-4727-a5be-41644f967bc1", "Steve88@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d1aa2cbc-d57c-4732-b53c-7024ee70f644", "Irene42@gmail.com", "099d7ce3f30730c09d83d546e4721812bdadcd50", "094792bd-5ac5-43ca-b3e4-de4880c32ae0", "Irene42@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4b72f50c-a781-4f96-88d5-a9411d666559", "Hannah_Casper62@hotmail.com", "3c7eb9d0b540d01bc6d2d83f609e7545ad81f841", "1a2b3918-b54e-4e0d-bb72-a97dc10da8d0", "Hannah_Casper62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c8dfa0ae-b04a-4cef-b4fb-886637f4aa0e", "Sherry_Wolf2@yahoo.com", "905487c826871359784ccf4ae15f84981a7b8ae0", "0667e801-76b5-474d-ae56-55eef09edb3a", "Sherry_Wolf2@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "07256bb5-df77-4633-80e2-8f964aef13a8", "Louise83@yahoo.com", "ea4072947542eb30590140bb1bf7a74a363dc7d4", "2aeeed58-4d5f-432f-8623-3d98bf2e69b3", "Louise83@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a6e13fb3-a661-40d4-aa11-7983fa1d1426", "Dana.Schultz21@hotmail.com", "16068687c39661cd3f3cc23a82fc5dd278f05f8a", "fcccbac7-3ff7-4a98-874b-69a31fda4d88", "Dana.Schultz21@hotmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "100", 0, "d9a8e2bb-7976-4069-bf26-e3674536a137", "Loretta5@yahoo.com", true, false, null, null, null, "0cc0912fb13b73cd1631c032a81d05f299ec960a", null, false, "69a407be-976b-43df-9be0-00d67491f82d", false, "Loretta5@yahoo.com" },
                    { "101", 0, "d6ad5c8b-c5f5-46a8-b242-534e7ada31d7", "Gerard44@hotmail.com", true, false, null, null, null, "612021d13fbae23deb63078b205c6c1dd1fe422e", null, false, "845d8d01-e21d-495f-9ee8-fd7523e7b373", false, "Gerard44@hotmail.com" },
                    { "102", 0, "60d40d24-c80f-4d7b-b7c7-c7beb4b604df", "Myra_Berge71@gmail.com", true, false, null, null, null, "9b8c427d410e693dbdddeb4dedbce3ba676cc11e", null, false, "9d802f20-5c3f-4052-8306-508fa5235c70", false, "Myra_Berge71@gmail.com" },
                    { "103", 0, "88e66709-898a-4f8c-8d11-08daeff567f4", "Alicia89@yahoo.com", true, false, null, null, null, "2f5cce9a72315b0df717fd589f45a4d75830340d", null, false, "2098a217-66ee-458e-8de2-14242c80e18b", false, "Alicia89@yahoo.com" },
                    { "104", 0, "2f768e2f-da39-456a-b474-0a61703c61a4", "Lionel.Bechtelar19@hotmail.com", true, false, null, null, null, "b3eb921ae6bcf72c3c3a0a343bb04814efba0e52", null, false, "0fea26e5-76b5-4fb4-b2c7-774d29edc775", false, "Lionel.Bechtelar19@hotmail.com" },
                    { "105", 0, "0c46ac98-604f-4018-afef-4cbb3672c0e9", "Shane_Christiansen@hotmail.com", true, false, null, null, null, "08a6dc4d183fc1234b05385e0ae0cd2ee072a5dc", null, false, "2144e7da-c448-4dd3-a5da-143f6a02922a", false, "Shane_Christiansen@hotmail.com" },
                    { "106", 0, "a3453dad-725f-498f-b1a7-4f85dc536236", "Tricia_Ortiz5@yahoo.com", true, false, null, null, null, "ffb198b1d47653b209449ea31bccaf1b1f8fc3ea", null, false, "e00fdc94-3190-41c8-ba36-6498a5c5f82a", false, "Tricia_Ortiz5@yahoo.com" },
                    { "107", 0, "14cac219-148c-4d97-ac91-935e928faad2", "Robin.Jaskolski@yahoo.com", true, false, null, null, null, "08af8e3fabe43dd64e276ae588576ba02dfdd32a", null, false, "82f9785f-2f9e-4306-af0b-eaeb9de92854", false, "Robin.Jaskolski@yahoo.com" },
                    { "108", 0, "8bb1f168-cd15-4c06-8f5d-ebbf5f7c1aa4", "Frances.Rempel49@gmail.com", true, false, null, null, null, "a9b2d7dac8513c8e1abfce1fb10b707c5e475d79", null, false, "8672c81a-e00e-434a-9ab2-f0926385aa88", false, "Frances.Rempel49@gmail.com" },
                    { "109", 0, "466742d8-e129-4b1d-a800-cd25206797d2", "Perry89@gmail.com", true, false, null, null, null, "6f932cff09f895253315f26279fbd955dfe5dfa7", null, false, "49ef684a-c0e4-46e2-afd2-c278b64c484b", false, "Perry89@gmail.com" },
                    { "110", 0, "8a65db14-96e2-4f9c-9d97-304730d9a530", "Pedro.Cormier@hotmail.com", true, false, null, null, null, "bf5e4c5207f64f4069a5c80f5c624d6acef6277c", null, false, "02756733-9fea-4764-8443-8d9d858d7675", false, "Pedro.Cormier@hotmail.com" },
                    { "111", 0, "725e289f-c386-46b8-b44a-9b676759d514", "Paul.Bauch92@yahoo.com", true, false, null, null, null, "05c3a81160aa5153a7bf69fce564d37b31a6e36b", null, false, "95fe81c1-ea08-40a9-8c0d-0509e6aceeb9", false, "Paul.Bauch92@yahoo.com" },
                    { "112", 0, "f0eaf969-2c6a-4bfe-8578-cd312813c0f0", "Katherine.Brown@yahoo.com", true, false, null, null, null, "c503aa12b66ff316ce5fc0a30876ea6fe14e1c21", null, false, "0f704fd3-cb33-4b4b-aa4e-6305f6c206f2", false, "Katherine.Brown@yahoo.com" },
                    { "113", 0, "b059297a-a348-4864-95a7-4f264491912a", "Blanche38@hotmail.com", true, false, null, null, null, "6e1722b10da322b30d0139d62674cec5f23293eb", null, false, "fa99077f-5324-4f5d-9b01-d32683f261c4", false, "Blanche38@hotmail.com" },
                    { "114", 0, "4098d7d7-1df6-4e19-938b-bc643a5aa339", "Edwin_Gibson@yahoo.com", true, false, null, null, null, "e71f07d38eff4d6a870739abe8e81c63acebce65", null, false, "084df153-4f60-4368-9299-41ec140105d5", false, "Edwin_Gibson@yahoo.com" },
                    { "115", 0, "2635e4d5-ab48-4ef0-90a7-bf6fc3dfd8d0", "Ollie.Willms@hotmail.com", true, false, null, null, null, "eeba4771d53c1c8743bbe93437788ee095a7ef64", null, false, "6c5f244f-6139-4b53-8233-423e0036ee8e", false, "Ollie.Willms@hotmail.com" },
                    { "116", 0, "8ac7c651-78ac-4bf9-b021-b21212859c5a", "Marian.Lehner96@gmail.com", true, false, null, null, null, "24b4d3146563049360ca9deb46ebe7fa2be786fb", null, false, "1282be02-1179-471f-8eb2-eb9a7fab3355", false, "Marian.Lehner96@gmail.com" },
                    { "117", 0, "da3c3bd9-5ae3-4a8d-8782-974683ac3c64", "Gloria_Walsh22@gmail.com", true, false, null, null, null, "e09e77e397848465463329324e398d2092ec3dfb", null, false, "8c8bbe43-7525-433e-a65b-bd1ac0de9ca9", false, "Gloria_Walsh22@gmail.com" },
                    { "118", 0, "f536cc08-90c8-4bdc-905d-aa13fc2367c6", "Cedric88@gmail.com", true, false, null, null, null, "64791915252fa3b05a62c10d0425c3ad8bbbceb3", null, false, "4570b57f-2d16-4be7-90a6-b69904e51525", false, "Cedric88@gmail.com" },
                    { "119", 0, "f2d647ef-58f5-4364-b457-7e375ec6dafa", "Tommie_Huels@gmail.com", true, false, null, null, null, "7a1326eb7ccc7765050f142546564cb071d0a237", null, false, "0bdc5e38-a6ae-45fd-ba19-1950044f49b1", false, "Tommie_Huels@gmail.com" },
                    { "120", 0, "1750b015-2f23-4f4f-9c66-a4357cd5b28f", "Noah.Kuhn@hotmail.com", true, false, null, null, null, "9978e46b52d4b33fc3d8f5c5bd8d4bde56fffcf3", null, false, "40ca1491-4cc8-4a9c-b194-053444cba81d", false, "Noah.Kuhn@hotmail.com" },
                    { "21", 0, "d1e14115-7884-4979-b2e0-909c7169fe1d", "Grant.Von14@gmail.com", true, false, null, null, null, "70d9e9d2456aa8a22c8e18dd1684d67e24b45fff", null, false, "12fa84f0-f601-43b8-bd68-54a6b9d7110e", false, "Grant.Von14@gmail.com" },
                    { "22", 0, "1393eb8a-9aed-418c-858d-25fee0cb92ba", "Raul.Klocko17@gmail.com", true, false, null, null, null, "86dfe5d745cf3bb3375b059dbb7c6d39556ea444", null, false, "7561dc4e-9890-46de-bb2f-74ec40a14b12", false, "Raul.Klocko17@gmail.com" },
                    { "23", 0, "4c653a9a-1783-4d48-9471-279a9a843aba", "Jeremiah_Casper67@yahoo.com", true, false, null, null, null, "b800f764cf6db9ced88dbd4e29600abb6a3ac0e2", null, false, "643b6ecc-ee4a-4e56-9e54-60273743005b", false, "Jeremiah_Casper67@yahoo.com" },
                    { "24", 0, "bc145d19-5fef-4ca1-a1f5-23ef1a6f3575", "Mildred80@hotmail.com", true, false, null, null, null, "e6a234830d19178985b19cd1d0a5ba052d0a536f", null, false, "e0c098fc-3edb-4fe8-a98d-66826a0c12f2", false, "Mildred80@hotmail.com" },
                    { "25", 0, "18b1b918-9460-49b4-b9ee-ef2a5f9efcc5", "Leslie3@hotmail.com", true, false, null, null, null, "74bed51ae9e0357a54bbb0244d1f93e4c1bd0916", null, false, "240b86ca-cf90-486b-bbb5-f7c1665a1c9f", false, "Leslie3@hotmail.com" },
                    { "26", 0, "515f2269-f146-4f63-abcf-95bb8fb8be9d", "Kristy_Trantow22@yahoo.com", true, false, null, null, null, "a9251a6e538084a3fdbb736fc266fc5a54d0f69d", null, false, "aa73b6ab-1fe5-4771-b632-1f2837773ab0", false, "Kristy_Trantow22@yahoo.com" },
                    { "27", 0, "8685653e-cc09-4cb1-8b8e-fbc238099534", "Ron_Koepp@hotmail.com", true, false, null, null, null, "1b03be1eb3a2698ba3d3975104240232300afd83", null, false, "7aed8026-2b21-4d47-ad14-7994d7d423fa", false, "Ron_Koepp@hotmail.com" },
                    { "28", 0, "5e84d785-7c7c-4884-b8e7-2e88ecc657fd", "Leo_Kihn@gmail.com", true, false, null, null, null, "34f27774f2fa1dfbb1d89b0123a9840a0dbf9bab", null, false, "f7e7810b-72e2-4748-aa90-2704c9b6d360", false, "Leo_Kihn@gmail.com" },
                    { "29", 0, "2f65f939-8105-4899-8e46-5ef483e186bb", "Virgil72@yahoo.com", true, false, null, null, null, "7a9db69193e619b271f3c90bc56bee75f2ba031e", null, false, "6b882178-3bf6-4868-8e66-139d106cf9b3", false, "Virgil72@yahoo.com" },
                    { "30", 0, "6ed5d1f3-e1ce-4a87-9807-0fadd9769d0a", "Ada43@hotmail.com", true, false, null, null, null, "a8d38bf8ab2ae0f0bddd1cee07e6e832f3226003", null, false, "a9929e0b-c0ec-4cc6-be6c-0829c7201535", false, "Ada43@hotmail.com" },
                    { "31", 0, "f4985b39-748a-4bfd-b2e8-5960db5dfa36", "Darla33@hotmail.com", true, false, null, null, null, "b94bbb3799735d63bc87f02bb1fe3a40762d8ff5", null, false, "e20b3490-fc99-4f45-83e1-9dfc2db3f8cb", false, "Darla33@hotmail.com" },
                    { "32", 0, "4f737d31-a2a0-4790-a2d3-bdab27400bca", "Jenny_Ankunding80@yahoo.com", true, false, null, null, null, "90be8f5d23a486d64af1e98674edbe1dbebc04c1", null, false, "30b7a070-1522-47a6-925c-9ba40ada94c8", false, "Jenny_Ankunding80@yahoo.com" },
                    { "33", 0, "3dc9fd53-d527-46b0-931e-103fdcf75f97", "Kayla_Kutch46@hotmail.com", true, false, null, null, null, "34339ce29673c3b7e4171b33a5fe4b9bb74249b7", null, false, "4f86635d-c0cc-4483-83d9-f6533e84fdb5", false, "Kayla_Kutch46@hotmail.com" },
                    { "34", 0, "bc991901-7f78-482f-bc54-15dc968aebaa", "Geoffrey30@yahoo.com", true, false, null, null, null, "aa06a34fdfb4d06c710c57d51bd180674bcbb57b", null, false, "872eb410-24d8-46b1-8334-7893d782b1fb", false, "Geoffrey30@yahoo.com" },
                    { "35", 0, "5a7e1dfa-10bb-488e-b9a3-af283f0aeaf9", "Jane3@gmail.com", true, false, null, null, null, "1298212f5d9556e514224418ed4e864fa6858b97", null, false, "0e379733-0411-4017-91bb-dc7305f550b2", false, "Jane3@gmail.com" },
                    { "36", 0, "8caf30da-0584-4011-bdca-fbee501adb1e", "Andrew_Mraz83@hotmail.com", true, false, null, null, null, "ec16fe9f899bd537293c30c7b9326ad1822ffde2", null, false, "eb30769d-14d8-43d5-8482-cbb6d2a2ad0d", false, "Andrew_Mraz83@hotmail.com" },
                    { "37", 0, "3ca3a986-ae45-44a9-8f8b-f1a7d221a1c1", "Melba_Orn49@gmail.com", true, false, null, null, null, "f492f520df2f9e5ad982d688d5bc55a114876779", null, false, "a2a9ca07-f6a9-4527-b3fe-121627712035", false, "Melba_Orn49@gmail.com" },
                    { "38", 0, "52f07734-f858-4b48-af3d-519b4a5f686b", "Amanda_Morar@yahoo.com", true, false, null, null, null, "868e1f9c6c8f7fdcc3c0bb46a80140929e29e442", null, false, "032c0e94-b441-4c55-be1b-3bdeeee64669", false, "Amanda_Morar@yahoo.com" },
                    { "39", 0, "6aa0bd63-8bd4-40c8-bcfb-9a78bda185cb", "Tomas_Cole@hotmail.com", true, false, null, null, null, "541dd33673066bdf125f532c64d033c5f7d68380", null, false, "4f0e3e78-bbdd-4097-8de4-f465ae2c9b5a", false, "Tomas_Cole@hotmail.com" },
                    { "40", 0, "5ae39b4d-2c47-46a9-8105-d75e41391816", "Julio.Greenholt62@yahoo.com", true, false, null, null, null, "895f1976fa6e567098905956c0ceb939fe82e84f", null, false, "48beb856-9ce0-44e0-81c2-72643e8d3d01", false, "Julio.Greenholt62@yahoo.com" },
                    { "41", 0, "33845e75-4594-4d3b-8961-dfbd507afd34", "Sadie.Sauer36@gmail.com", true, false, null, null, null, "67f9071e2740091289ae5fe87541da7ed482f992", null, false, "181bd5ff-e9b6-4695-9d17-45114099bbc3", false, "Sadie.Sauer36@gmail.com" },
                    { "42", 0, "e124a893-cd40-4276-ade7-2e8f4a915ee2", "Mike.Farrell@hotmail.com", true, false, null, null, null, "47fdbdc04d4cf84b73d47b74aaaac72bc622888b", null, false, "3af265c8-4670-494d-87ca-f9addc1f5cb3", false, "Mike.Farrell@hotmail.com" },
                    { "43", 0, "596b6b01-69f0-4747-8138-1fa7e1bb4da2", "Adrian_Breitenberg31@hotmail.com", true, false, null, null, null, "6387e7122146e59b0afcec526bd5b9c914af55e7", null, false, "c56110f8-3500-4f4d-a3f7-07a17203c28f", false, "Adrian_Breitenberg31@hotmail.com" },
                    { "44", 0, "fd88cb7f-6819-43f0-9e8a-821a4408eff4", "Daisy.Hahn13@yahoo.com", true, false, null, null, null, "8aedf0acc4cda5a4b5e6dbce8b7e389ba5b13979", null, false, "e5d401d8-4725-4590-900d-9806ff8a5b47", false, "Daisy.Hahn13@yahoo.com" },
                    { "45", 0, "7fbffedd-b407-43bc-a853-2500cfc73fc8", "Erin.OHara13@yahoo.com", true, false, null, null, null, "cab2c4bb184b05c5eeb110accddeea7c6b1b3d80", null, false, "937b2d06-0f45-40c2-84c4-1ac1e6a532a7", false, "Erin.OHara13@yahoo.com" },
                    { "46", 0, "8b7f219e-2ecf-4fe3-bd8e-34f24fe0edce", "Erica80@hotmail.com", true, false, null, null, null, "d4731286da6136ad6cdbd8a56db124e82097e311", null, false, "118920f8-89ac-4f22-aea3-4fe7e468b7b4", false, "Erica80@hotmail.com" },
                    { "47", 0, "52877223-5ab1-47ad-80e3-8bfc68c059e0", "Donna.Rau@gmail.com", true, false, null, null, null, "32a6c770a648eb0e91695478c4073c469deb0b80", null, false, "e8dcfcb2-2387-42bc-8788-8435f1e007d3", false, "Donna.Rau@gmail.com" },
                    { "48", 0, "d8bf03c5-fc5e-4d94-a6ab-fe61da6ddbcd", "Wanda.Nitzsche@gmail.com", true, false, null, null, null, "c617296c7e1befe057a5a7593600fa7f517ccd7a", null, false, "db4adfd1-0f9f-4350-81b4-80a9fc3a12ba", false, "Wanda.Nitzsche@gmail.com" },
                    { "49", 0, "098180e2-a50d-4722-a20f-859665ab9881", "Carl_VonRueden91@gmail.com", true, false, null, null, null, "a2eca2ec20d44abf6e028cc9952fc35e8d55d592", null, false, "91e9042c-d153-460d-8273-5dcd67420c94", false, "Carl_VonRueden91@gmail.com" },
                    { "50", 0, "ff0c0d8f-2538-4dc7-a357-cb0c6f014d7f", "Arturo99@yahoo.com", true, false, null, null, null, "3d6051f75618f4eb92a76bcbd0a1919b12df7d91", null, false, "0b5108f0-c9ca-42f0-bfe0-2cce69b92fc5", false, "Arturo99@yahoo.com" },
                    { "51", 0, "3bd5ff14-d8e3-44f8-aaa4-e00fa5cd1fb6", "Carrie55@hotmail.com", true, false, null, null, null, "3521681581299fc8e60c5054e1e0c5f3f8ecd9eb", null, false, "99476e99-2e88-4a66-8166-331ebb1bdd92", false, "Carrie55@hotmail.com" },
                    { "52", 0, "cf75fae6-1913-4d91-9ae8-71058dd937a1", "Tricia_Schulist30@yahoo.com", true, false, null, null, null, "e6606f0c7502ea1acc89163232982167f0d049db", null, false, "a3b66d83-79b6-4d72-985b-aa1cb5f9d4a2", false, "Tricia_Schulist30@yahoo.com" },
                    { "53", 0, "096a5c38-b16f-4776-a23f-c07f56196f8b", "Ben.Batz@yahoo.com", true, false, null, null, null, "75de4f120df7dd6f0e1d4086907596cf157c0262", null, false, "0ed684ea-2fff-4509-aa50-436df6d41477", false, "Ben.Batz@yahoo.com" },
                    { "54", 0, "e8111671-be7e-45ae-b02a-f94bebb36aaa", "Jeffery_Kautzer90@yahoo.com", true, false, null, null, null, "491ee7f9b685f9241444ca1d1a0c20da0f5d9a89", null, false, "dafabe05-070e-45f4-9764-4e4707e6c981", false, "Jeffery_Kautzer90@yahoo.com" },
                    { "55", 0, "31ee1c16-2a69-45b6-9abe-482a307bdbf2", "Alan_Batz@yahoo.com", true, false, null, null, null, "169662a516110059fdcc03811d1bc08e7da7f1df", null, false, "d473385f-9be9-4914-94f1-2ec3753b7ca0", false, "Alan_Batz@yahoo.com" },
                    { "56", 0, "de9984cf-f87d-4cc4-b70c-bf66082ba667", "Cody57@yahoo.com", true, false, null, null, null, "11f53155190fbaf7cf805810a58e86d9c0cf3ad2", null, false, "544f699d-2ab5-447e-828d-f9fccf3485e7", false, "Cody57@yahoo.com" },
                    { "57", 0, "6a3a7c11-3d2e-41d6-bb2e-9468478be734", "Shelley59@hotmail.com", true, false, null, null, null, "f72e324befa9853b54c72c442d70a910a0395c35", null, false, "79466864-86f6-456c-820d-328ff8628a4d", false, "Shelley59@hotmail.com" },
                    { "58", 0, "2526be30-8f7b-41e6-b817-bdad3b8af2ba", "Andy.Boyer@hotmail.com", true, false, null, null, null, "5ae1bbf157775b1143a6cc30ed8ad313a968ff94", null, false, "de6eb48d-9034-4705-956f-e0b2eac9db27", false, "Andy.Boyer@hotmail.com" },
                    { "59", 0, "8c09af6b-d6f1-4f4c-820f-74301ed25ae1", "Traci25@hotmail.com", true, false, null, null, null, "ab56cd4da7e7b1a5a726de27731f159a547f109e", null, false, "992c03ee-c012-43dd-859f-2d06016e37df", false, "Traci25@hotmail.com" },
                    { "60", 0, "06c92385-48da-41b2-868b-afbfacc3ee51", "Marcia0@hotmail.com", true, false, null, null, null, "59f45f6f743c0b9ff145fa454f23653fa4690585", null, false, "042b1e60-f233-4d65-9d0d-a8d1a2c0f5ec", false, "Marcia0@hotmail.com" },
                    { "61", 0, "52d29c96-1364-4ba9-9b4d-424f8d46f11e", "Donna36@yahoo.com", true, false, null, null, null, "b52cbf0c9b3136f1b308e5f719a5128d6592d110", null, false, "12fd3843-636f-44d3-9538-d93c5483f3d6", false, "Donna36@yahoo.com" },
                    { "62", 0, "3f1e44dd-852a-45af-8009-01e6b25544e0", "Freda86@yahoo.com", true, false, null, null, null, "d7156b824f4ac55df8be0e8319aaac0dcdba86a3", null, false, "7dacb6b2-129c-4909-a22a-6b4b667403fa", false, "Freda86@yahoo.com" },
                    { "63", 0, "c5f7308d-7f11-4f31-a726-1a83416f6675", "Ernestine36@yahoo.com", true, false, null, null, null, "dea817943e772faae847f042a84fafbcbbf6a6a2", null, false, "3898ad36-aaff-4168-aac3-1efd15190cbd", false, "Ernestine36@yahoo.com" },
                    { "64", 0, "43f53dcf-43c4-49ec-81bf-3b0571f22264", "Everett.Kunze@hotmail.com", true, false, null, null, null, "007baae538fdae09f3e8df84e4a19221a2a6f572", null, false, "a1ecb638-ab65-4e90-92d1-bab233890ca6", false, "Everett.Kunze@hotmail.com" },
                    { "65", 0, "84f8ee36-592d-47dd-b59c-5688f43a1c0a", "Mandy7@gmail.com", true, false, null, null, null, "7ca94b15dcf3ed4af7116e44888d92be39a9c037", null, false, "f95ad8c6-c883-41d8-ac9a-bbd0f9543f3c", false, "Mandy7@gmail.com" },
                    { "66", 0, "7a2c5659-9e7e-44dc-baf5-eaa82f889046", "Candice.Jaskolski@hotmail.com", true, false, null, null, null, "581089e7ef6621e4412c59dff8d6c36e25840dc2", null, false, "fdc5469c-e24e-4042-954b-de81b597d3b2", false, "Candice.Jaskolski@hotmail.com" },
                    { "67", 0, "429ae696-b4f8-4eab-823f-14599e5006d1", "Candace90@hotmail.com", true, false, null, null, null, "56fb1dcae46cd3d3d82f7f997bfd87ad42309093", null, false, "7148709b-e759-46a2-b829-ff2d5f8fd722", false, "Candace90@hotmail.com" },
                    { "68", 0, "75bc913b-15f2-4c20-ba93-d3b960b5d5d8", "Herbert_Sauer90@yahoo.com", true, false, null, null, null, "01546125914507206c461a6bde3132f1e0a297b1", null, false, "8fc655fc-d198-4eae-a49b-997a6e7c5096", false, "Herbert_Sauer90@yahoo.com" },
                    { "69", 0, "44f9a6ff-398f-4e08-bc62-c7573bb6c6b0", "Beulah.Goyette71@yahoo.com", true, false, null, null, null, "d7bd2d4f4987c42fa1aaa323d5d00318c5988388", null, false, "cd84a544-9ec0-4fa2-ac68-e290eb91ce2a", false, "Beulah.Goyette71@yahoo.com" },
                    { "70", 0, "999a6b19-3375-44c3-9b43-0280f09e3065", "Kirk.Greenholt40@hotmail.com", true, false, null, null, null, "53d6ddc8d976fabad0627007949353256ee554ca", null, false, "ed20d56a-5b18-4b85-b332-d1df25a80270", false, "Kirk.Greenholt40@hotmail.com" },
                    { "71", 0, "f999d1bd-1a5b-485c-8608-fe45b5f9560a", "Curtis_Kuhn8@yahoo.com", true, false, null, null, null, "fa2d86121c2bd581e7c2fee6dd66c03755b2dfe4", null, false, "4395ea81-b364-4ba3-a338-d1515284ed63", false, "Curtis_Kuhn8@yahoo.com" },
                    { "72", 0, "f82d51ad-3896-4e99-9a84-bb3a312613df", "Cesar_McKenzie@gmail.com", true, false, null, null, null, "30881320d81edbddd0275e10823c2e8ff614380c", null, false, "58092fec-b8dc-4d0f-a7b8-0a0dc0bb1241", false, "Cesar_McKenzie@gmail.com" },
                    { "73", 0, "d592b05a-50e3-4c65-91fa-c02daef986e0", "Ethel_Considine57@hotmail.com", true, false, null, null, null, "641530314a893a30830a07e2f27440bf444a23b3", null, false, "847a4651-6a14-41c0-b3f4-2f919318346b", false, "Ethel_Considine57@hotmail.com" },
                    { "74", 0, "2e898e93-dc59-4eae-ac56-a24c6dd61128", "Cristina.Tremblay@yahoo.com", true, false, null, null, null, "4304e13751c94be9fb0ae993cdca67e0dd8476a1", null, false, "8236d14a-6e9d-4eae-a571-5456d21fd358", false, "Cristina.Tremblay@yahoo.com" },
                    { "75", 0, "b8dbfdee-b0c4-48b6-bb4c-136f4ed1155d", "Fannie.Kuhn96@gmail.com", true, false, null, null, null, "e7c649231356669d3d2834640efc3a06251ff480", null, false, "dd917b11-5a9f-4774-b90a-10e19dd096da", false, "Fannie.Kuhn96@gmail.com" },
                    { "76", 0, "00de8e32-d0bf-4dc1-8e6b-f6cbd472c5e7", "Courtney.Mohr17@gmail.com", true, false, null, null, null, "35eff1217f5ca948309f4adf1041a9276cc4701a", null, false, "77d5a5ea-f131-492e-a197-eea500a32da2", false, "Courtney.Mohr17@gmail.com" },
                    { "77", 0, "740748fb-65f0-49d2-86a6-c7724be6c25b", "Kevin59@yahoo.com", true, false, null, null, null, "abf723f2ca9a21c4756022a79da7b44f37c97e2d", null, false, "23c0da1d-0e19-480e-aafd-ea54256362e3", false, "Kevin59@yahoo.com" },
                    { "78", 0, "cf30e0ca-2236-405b-9e28-0ff03ba193c5", "Sally_Lockman87@hotmail.com", true, false, null, null, null, "a8cb04845d7e13dbfcfd655936370c2ab2913b02", null, false, "dd7b1035-1d53-4975-8826-00bd81704a0b", false, "Sally_Lockman87@hotmail.com" },
                    { "79", 0, "ede4e6d6-0f5f-4c8c-927b-e0149683eb95", "Monica.Steuber24@hotmail.com", true, false, null, null, null, "f97a7994c6e7629e3a988e162d7aced3c96dcb76", null, false, "f230e41b-5b90-411d-a53a-ed3e221bcb7a", false, "Monica.Steuber24@hotmail.com" },
                    { "80", 0, "912ec5d9-79e6-4730-93dc-8ed1155bbfca", "Fernando_Rippin97@gmail.com", true, false, null, null, null, "8922ca2a9a5aec40096486f60cc72d6e08311db8", null, false, "59535cdd-d32d-42d1-8fd2-407dad7b8b31", false, "Fernando_Rippin97@gmail.com" },
                    { "81", 0, "48c1626e-9260-4553-b549-a9a0538adfe6", "Elmer99@hotmail.com", true, false, null, null, null, "f98bf849a7a8a7d68b38b035a5650943afd3c190", null, false, "67c12659-b900-4bdf-bb7b-c887d6fd329b", false, "Elmer99@hotmail.com" },
                    { "82", 0, "caad986f-baee-47a7-b03a-498779791b0c", "Charlie.Koepp@yahoo.com", true, false, null, null, null, "8c5ab060dc238924b28cdd683575f5243361ef2a", null, false, "db935243-6b6b-49ce-bff5-524c1da2396f", false, "Charlie.Koepp@yahoo.com" },
                    { "83", 0, "35f705c9-8a38-42a8-9df4-1969a7f978f5", "Angie.Welch@hotmail.com", true, false, null, null, null, "bbe2aa26358cee85615212f54cabff3f4ae31941", null, false, "1b016a05-dc06-45af-9a7e-7aa7d64445ff", false, "Angie.Welch@hotmail.com" },
                    { "84", 0, "340b8788-613c-4c68-ae5e-8b6d74744766", "Ginger_Muller73@hotmail.com", true, false, null, null, null, "f9e991ff7481b4039f2584aa0b8296f66dec1b32", null, false, "17cad958-356c-4fc5-ac0b-634813e73a11", false, "Ginger_Muller73@hotmail.com" },
                    { "85", 0, "5fa4f840-44f3-4d20-83e3-c73207bec5b0", "Desiree_Sanford@gmail.com", true, false, null, null, null, "d2b7a20659f779f6967c8f00b2fd8b6f0038cacd", null, false, "4fc35e19-e225-4cb9-9d5f-37dc13bb200f", false, "Desiree_Sanford@gmail.com" },
                    { "86", 0, "9e05cdc4-e7e9-430d-8821-1e2bfd2a7e05", "Stacy83@gmail.com", true, false, null, null, null, "11648d3a4a611a96b1a2f31540f4537bfead4427", null, false, "1d485a07-6086-4017-be5d-9b2dd9d72741", false, "Stacy83@gmail.com" },
                    { "87", 0, "0106344d-2b7c-40a5-a12a-21aac3a9b1aa", "Van_Wisoky41@gmail.com", true, false, null, null, null, "88825182a59e2361db7bf73ca9bd2f97a36b9897", null, false, "2ef82ed3-77a9-4225-80bd-b133cb7df19e", false, "Van_Wisoky41@gmail.com" },
                    { "88", 0, "ce67f924-cdeb-43df-b78b-356a73a51c42", "Terry47@hotmail.com", true, false, null, null, null, "4b10c2c7575d3e46ef5682f2b14d0e66b08314ba", null, false, "212f0ddb-b95c-488e-879f-157bc0dd6dee", false, "Terry47@hotmail.com" },
                    { "89", 0, "113a115e-4ccf-486e-bd10-95c9a72f3598", "Ramon17@yahoo.com", true, false, null, null, null, "6698c82dad63693c394a987376e09b537e4d1b76", null, false, "0186b94d-690c-440a-9c44-cdc2a49e1124", false, "Ramon17@yahoo.com" },
                    { "90", 0, "ec2751fc-b38f-422a-ae29-d40b0f082da6", "Nick87@hotmail.com", true, false, null, null, null, "b66448d46c91739afb1214402d48b671da25df77", null, false, "eed92f51-1b65-4c20-b960-fd7295b0f5d0", false, "Nick87@hotmail.com" },
                    { "91", 0, "2d61b6b4-31ad-4109-b2c2-19ce6dedfa03", "Darnell11@hotmail.com", true, false, null, null, null, "d99c45bfd040c1092a1bf60b23a68d789369df29", null, false, "43039465-9f39-466c-830c-30b1e2bf7b4b", false, "Darnell11@hotmail.com" },
                    { "92", 0, "5742b884-522d-433b-8e33-4b20efcbae9f", "Marcia.Barrows28@hotmail.com", true, false, null, null, null, "52fd5026076af97abfaffe4eb8d118070b67e96f", null, false, "b61fe9b6-785b-4509-96b2-e8623b220a29", false, "Marcia.Barrows28@hotmail.com" },
                    { "93", 0, "9022baf4-e800-4795-a97f-1f3c55ad5a47", "Jessica_Bernhard@gmail.com", true, false, null, null, null, "14dd8cd906b9d69244ff6f2b7c73567260340773", null, false, "beffe991-32c4-4c59-aac5-71eb4412f5b4", false, "Jessica_Bernhard@gmail.com" },
                    { "94", 0, "cbb81058-67a8-4e99-b7a1-3661af4636e5", "Paul4@yahoo.com", true, false, null, null, null, "116ca640183759e9264f29cf86a7e9520c282282", null, false, "a49869ea-9adf-4fae-b145-cdd61df2a62c", false, "Paul4@yahoo.com" },
                    { "95", 0, "379954c1-683f-4bc5-a89d-9fb79f41e334", "Rufus96@yahoo.com", true, false, null, null, null, "1c645f5768479cbc4350f246f07d4864dd351ba3", null, false, "4dc91e20-dc39-4599-a2c2-3b6f6c2b70ec", false, "Rufus96@yahoo.com" },
                    { "96", 0, "83986bdd-b019-49ea-9cb2-23739c2c4045", "Jody.Witting60@yahoo.com", true, false, null, null, null, "f46563f8ca0fce1cdc9c9a43f9ffc844928cef15", null, false, "63193657-503a-44b4-a90b-14d55775a191", false, "Jody.Witting60@yahoo.com" },
                    { "97", 0, "876c5783-e203-45ba-be43-90be0fa3c613", "Rufus.Hilll@hotmail.com", true, false, null, null, null, "47995af63e9aecd155612320682d5e44a4682b99", null, false, "6d82e8d5-f8aa-4b1e-b3eb-1d539f5445f8", false, "Rufus.Hilll@hotmail.com" },
                    { "98", 0, "fdd7ba36-3f46-45fc-945a-0a2afa9abb9c", "Rex68@gmail.com", true, false, null, null, null, "1fc2dc8bca5406cecfd0a2cfde5cee94025c61ec", null, false, "8cf5b1d2-9209-45bf-99c2-574fed07b25c", false, "Rex68@gmail.com" },
                    { "99", 0, "e89e3a54-acea-46a8-a0e5-3302c31ab8f6", "Kerry_Swift10@gmail.com", true, false, null, null, null, "2c949df5a09ea56eeeebc3729427d554a8d4b228", null, false, "55468b48-5b8b-46cf-aaa2-92eaf04753df", false, "Kerry_Swift10@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ian Blanda");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Robin Batz");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Lynda Bernier");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Dwayne Berge");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Olive Daugherty");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Floyd Lindgren");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Minnie Corkery");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Leonard Rolfson");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Sophia Jacobs");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Kara Mertz");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Amanda Bauch");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Linda Price");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Penny Morissette");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Marianne Gibson");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Bessie Boyle");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Ralph Fahey");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Rick Muller");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Winifred Rempel");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Ray Schmidt");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Lula Stoltenberg");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 21, 50, "Angelica Tillman" },
                    { 22, 50, "Amy Heidenreich" },
                    { 23, 50, "Jean Walker" },
                    { 24, 50, "Thomas Borer" },
                    { 25, 50, "Sylvester Konopelski" },
                    { 26, 50, "Guadalupe Bayer" },
                    { 27, 50, "Cecil Considine" },
                    { 28, 50, "Nicole Haley" },
                    { 29, 50, "Clifford Moen" },
                    { 30, 50, "Tina Stoltenberg" },
                    { 31, 50, "Allan Littel" },
                    { 32, 50, "Billy Champlin" },
                    { 33, 50, "Grady Kuvalis" },
                    { 34, 50, "Vicki Strosin" },
                    { 35, 50, "Myra Swaniawski" },
                    { 36, 50, "Maggie Medhurst" },
                    { 37, 50, "Kara Nader" },
                    { 38, 50, "Archie Beer" },
                    { 39, 50, "Van Hauck" },
                    { 40, 50, "Leland Spencer" },
                    { 41, 50, "Alberta Dickinson" },
                    { 42, 50, "Lola Cruickshank" },
                    { 43, 50, "Jeanette Schultz" },
                    { 44, 50, "Marta West" },
                    { 45, 50, "Terence Olson" },
                    { 46, 50, "Jorge Treutel" },
                    { 47, 50, "Rodolfo Stamm" },
                    { 48, 50, "Myrtle Swaniawski" },
                    { 49, 50, "Bonnie Mosciski" },
                    { 50, 50, "Elvira Huel" },
                    { 51, 50, "Heidi Hickle" },
                    { 52, 50, "Wayne Jacobs" },
                    { 53, 50, "Lori Nolan" },
                    { 54, 50, "Eloise Anderson" },
                    { 55, 50, "Sarah Nicolas" },
                    { 56, 50, "Fernando Marks" },
                    { 57, 50, "Noel Mosciski" },
                    { 58, 50, "Roderick Adams" },
                    { 59, 50, "Sherri Senger" },
                    { 60, 50, "Darrell Fritsch" },
                    { 61, 50, "Aubrey Ziemann" },
                    { 62, 50, "Alexis Cummerata" },
                    { 63, 50, "Wm O'Keefe" },
                    { 64, 50, "Lana Schaefer" },
                    { 65, 50, "Rogelio Kunze" },
                    { 66, 50, "Ellis Cartwright" },
                    { 67, 50, "Dwayne Toy" },
                    { 68, 50, "Clayton Welch" },
                    { 69, 50, "Rex Fadel" },
                    { 70, 50, "Laverne Willms" },
                    { 71, 50, "Hannah Tromp" },
                    { 72, 50, "Jerome Hackett" },
                    { 73, 50, "Shelia Collins" },
                    { 74, 50, "Mandy Feeney" },
                    { 75, 50, "Tommie Johnson" },
                    { 76, 50, "Wade Goldner" },
                    { 77, 50, "Sylvester Larkin" },
                    { 78, 50, "Margaret Rice" },
                    { 79, 50, "Kim Kreiger" },
                    { 80, 50, "Mabel Wunsch" },
                    { 81, 50, "Ernesto Stokes" },
                    { 82, 50, "Christy Rolfson" },
                    { 83, 50, "Pablo Walter" },
                    { 84, 50, "Kenneth Hayes" },
                    { 85, 50, "Levi Huel" },
                    { 86, 50, "Mathew Hickle" },
                    { 87, 50, "Juanita Schaden" },
                    { 88, 50, "Brenda Kerluke" },
                    { 89, 50, "Cora Mraz" },
                    { 90, 50, "Kerry Murray" },
                    { 91, 50, "Calvin Tromp" },
                    { 92, 50, "Dustin Donnelly" },
                    { 93, 50, "Felicia Schaden" },
                    { 94, 50, "Freddie Casper" },
                    { 95, 50, "Ruby Prohaska" },
                    { 96, 50, "Virgil Sawayn" },
                    { 97, 50, "Woodrow Kozey" },
                    { 98, 50, "Joshua Stehr" },
                    { 99, 50, "Chris Bailey" },
                    { 100, 50, "Esther Bahringer" },
                    { 101, 50, "Vickie Gibson" },
                    { 102, 50, "Tracey Denesik" },
                    { 103, 50, "Rosalie Bernier" },
                    { 104, 50, "Ronnie Lehner" },
                    { 105, 50, "Delbert Rutherford" },
                    { 106, 50, "Dominick Osinski" },
                    { 107, 50, "Casey Prohaska" },
                    { 108, 50, "Bryant Smith" },
                    { 109, 50, "Fannie King" },
                    { 110, 50, "Hilda Dicki" },
                    { 111, 50, "Kenneth Grady" },
                    { 112, 50, "Patti Schmidt" },
                    { 113, 50, "Joe Jacobi" },
                    { 114, 50, "Johnnie Fisher" },
                    { 115, 50, "Arnold Emmerich" },
                    { 116, 50, "Horace Schulist" },
                    { 117, 50, "Lois Goldner" },
                    { 118, 50, "Maureen Grimes" },
                    { 119, 50, "Harold Ortiz" },
                    { 120, 50, "Derrick Brown" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "LocationId", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 20, 20, 20, "Harry Potter: 20", 2017 },
                    { 21, 21, 21, "Harry Potter: 21", 2018 },
                    { 22, 22, 22, "Harry Potter: 22", 2019 },
                    { 23, 23, 23, "Harry Potter: 23", 2020 },
                    { 24, 24, 24, "Harry Potter: 24", 2021 },
                    { 25, 25, 25, "Harry Potter: 25", 2022 },
                    { 26, 26, 26, "Harry Potter: 26", 2023 },
                    { 27, 27, 27, "Harry Potter: 27", 2024 },
                    { 28, 28, 28, "Harry Potter: 28", 2025 },
                    { 29, 29, 29, "Harry Potter: 29", 2026 },
                    { 30, 30, 30, "Harry Potter: 30", 2027 },
                    { 31, 31, 31, "Harry Potter: 31", 2028 },
                    { 32, 32, 32, "Harry Potter: 32", 2029 },
                    { 33, 33, 33, "Harry Potter: 33", 2030 },
                    { 34, 34, 34, "Harry Potter: 34", 2031 },
                    { 35, 35, 35, "Harry Potter: 35", 2032 },
                    { 36, 36, 36, "Harry Potter: 36", 2033 },
                    { 37, 37, 37, "Harry Potter: 37", 2034 },
                    { 38, 38, 38, "Harry Potter: 38", 2035 },
                    { 39, 39, 39, "Harry Potter: 39", 2036 },
                    { 40, 40, 40, "Harry Potter: 40", 2037 },
                    { 41, 41, 41, "Harry Potter: 41", 2038 },
                    { 42, 42, 42, "Harry Potter: 42", 2039 },
                    { 43, 43, 43, "Harry Potter: 43", 2040 },
                    { 44, 44, 44, "Harry Potter: 44", 2041 },
                    { 45, 45, 45, "Harry Potter: 45", 2042 },
                    { 46, 46, 46, "Harry Potter: 46", 2043 },
                    { 47, 47, 47, "Harry Potter: 47", 2044 },
                    { 48, 48, 48, "Harry Potter: 48", 2045 },
                    { 49, 49, 49, "Harry Potter: 49", 2046 },
                    { 50, 50, 50, "Harry Potter: 50", 2047 },
                    { 51, 51, 51, "Harry Potter: 51", 2048 },
                    { 52, 52, 52, "Harry Potter: 52", 2049 },
                    { 53, 53, 53, "Harry Potter: 53", 2050 },
                    { 54, 54, 54, "Harry Potter: 54", 2051 },
                    { 55, 55, 55, "Harry Potter: 55", 2052 },
                    { 56, 56, 56, "Harry Potter: 56", 2053 },
                    { 57, 57, 57, "Harry Potter: 57", 2054 },
                    { 58, 58, 58, "Harry Potter: 58", 2055 },
                    { 59, 59, 59, "Harry Potter: 59", 2056 },
                    { 60, 60, 60, "Harry Potter: 60", 2057 },
                    { 61, 61, 61, "Harry Potter: 61", 2058 },
                    { 62, 62, 62, "Harry Potter: 62", 2059 },
                    { 63, 63, 63, "Harry Potter: 63", 2060 },
                    { 64, 64, 64, "Harry Potter: 64", 2061 },
                    { 65, 65, 65, "Harry Potter: 65", 2062 },
                    { 66, 66, 66, "Harry Potter: 66", 2063 },
                    { 67, 67, 67, "Harry Potter: 67", 2064 },
                    { 68, 68, 68, "Harry Potter: 68", 2065 },
                    { 69, 69, 69, "Harry Potter: 69", 2066 },
                    { 70, 70, 70, "Harry Potter: 70", 2067 },
                    { 71, 71, 71, "Harry Potter: 71", 2068 },
                    { 72, 72, 72, "Harry Potter: 72", 2069 },
                    { 73, 73, 73, "Harry Potter: 73", 2070 },
                    { 74, 74, 74, "Harry Potter: 74", 2071 },
                    { 75, 75, 75, "Harry Potter: 75", 2072 },
                    { 76, 76, 76, "Harry Potter: 76", 2073 },
                    { 77, 77, 77, "Harry Potter: 77", 2074 },
                    { 78, 78, 78, "Harry Potter: 78", 2075 },
                    { 79, 79, 79, "Harry Potter: 79", 2076 },
                    { 80, 80, 80, "Harry Potter: 80", 2077 },
                    { 81, 81, 81, "Harry Potter: 81", 2078 },
                    { 82, 82, 82, "Harry Potter: 82", 2079 },
                    { 83, 83, 83, "Harry Potter: 83", 2080 },
                    { 84, 84, 84, "Harry Potter: 84", 2081 },
                    { 85, 85, 85, "Harry Potter: 85", 2082 },
                    { 86, 86, 86, "Harry Potter: 86", 2083 },
                    { 87, 87, 87, "Harry Potter: 87", 2084 },
                    { 88, 88, 88, "Harry Potter: 88", 2085 },
                    { 89, 89, 89, "Harry Potter: 89", 2086 },
                    { 90, 90, 90, "Harry Potter: 90", 2087 },
                    { 91, 91, 91, "Harry Potter: 91", 2088 },
                    { 92, 92, 92, "Harry Potter: 92", 2089 },
                    { 93, 93, 93, "Harry Potter: 93", 2090 },
                    { 94, 94, 94, "Harry Potter: 94", 2091 },
                    { 95, 95, 95, "Harry Potter: 95", 2092 },
                    { 96, 96, 96, "Harry Potter: 96", 2093 },
                    { 97, 97, 97, "Harry Potter: 97", 2094 },
                    { 98, 98, 98, "Harry Potter: 98", 2095 },
                    { 99, 99, 99, "Harry Potter: 99", 2096 },
                    { 100, 100, 100, "Harry Potter: 100", 2097 },
                    { 101, 101, 101, "Harry Potter: 101", 2098 },
                    { 102, 102, 102, "Harry Potter: 102", 2099 },
                    { 103, 103, 103, "Harry Potter: 103", 2100 },
                    { 104, 104, 104, "Harry Potter: 104", 2101 },
                    { 105, 105, 105, "Harry Potter: 105", 2102 },
                    { 106, 106, 106, "Harry Potter: 106", 2103 },
                    { 107, 107, 107, "Harry Potter: 107", 2104 },
                    { 108, 108, 108, "Harry Potter: 108", 2105 },
                    { 109, 109, 109, "Harry Potter: 109", 2106 },
                    { 110, 110, 110, "Harry Potter: 110", 2107 },
                    { 111, 111, 111, "Harry Potter: 111", 2108 },
                    { 112, 112, 112, "Harry Potter: 112", 2109 },
                    { 113, 113, 113, "Harry Potter: 113", 2110 },
                    { 114, 114, 114, "Harry Potter: 114", 2111 },
                    { 115, 115, 115, "Harry Potter: 115", 2112 },
                    { 116, 116, 116, "Harry Potter: 116", 2113 },
                    { 117, 117, 117, "Harry Potter: 117", 2114 },
                    { 118, 118, 118, "Harry Potter: 118", 2115 },
                    { 119, 119, 119, "Harry Potter: 119", 2116 }
                });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3068), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3091), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3113), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3136), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3156), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3177), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3233), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3259), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3280), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3299), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3321), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3339), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3359), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3414), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3437), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3460), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3481), new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3479) });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "EndDate", "ItemId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 20, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3501), 20, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3499), "0" },
                    { 21, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3520), 21, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3519), "1" },
                    { 22, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3571), 22, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3569), "2" },
                    { 23, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3592), 23, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3590), "3" },
                    { 24, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3612), 24, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3611), "4" },
                    { 25, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3631), 25, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3630), "5" },
                    { 26, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3651), 26, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3649), "6" },
                    { 27, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3671), 27, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3669), "7" },
                    { 28, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3721), 28, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3719), "8" },
                    { 29, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3744), 29, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3743), "9" },
                    { 30, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3765), 30, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3763), "0" },
                    { 31, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3785), 31, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3784), "1" },
                    { 32, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3805), 32, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3803), "2" },
                    { 33, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3827), 33, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3825), "3" },
                    { 34, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3890), 34, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3888), "4" },
                    { 35, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3909), 35, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3907), "5" },
                    { 36, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3928), 36, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3927), "6" },
                    { 37, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3948), 37, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3947), "7" },
                    { 38, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3967), 38, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3966), "8" },
                    { 39, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3989), 39, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(3988), "9" },
                    { 40, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4033), 40, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4032), "0" },
                    { 41, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4054), 41, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4052), "1" },
                    { 42, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4072), 42, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4071), "2" },
                    { 43, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4093), 43, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4091), "3" },
                    { 44, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4112), 44, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4110), "4" },
                    { 45, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4131), 45, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4130), "5" },
                    { 46, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4151), 46, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4150), "6" },
                    { 47, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4229), 47, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4228), "7" },
                    { 48, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4250), 48, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4248), "8" },
                    { 49, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4269), 49, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4268), "9" },
                    { 50, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4289), 50, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4287), "0" },
                    { 51, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4308), 51, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4307), "1" },
                    { 52, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4329), 52, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4328), "2" },
                    { 53, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4372), 53, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4371), "3" },
                    { 54, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4394), 54, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4393), "4" },
                    { 55, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4415), 55, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4413), "5" },
                    { 56, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4435), 56, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4434), "6" },
                    { 57, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4455), 57, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4454), "7" },
                    { 58, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4474), 58, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4473), "8" },
                    { 59, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4493), 59, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4492), "9" },
                    { 60, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4536), 60, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4534), "0" },
                    { 61, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4557), 61, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4556), "1" },
                    { 62, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4577), 62, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4575), "2" },
                    { 63, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4598), 63, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4597), "3" },
                    { 64, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4618), 64, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4616), "4" },
                    { 65, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4641), 65, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4640), "5" },
                    { 66, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4690), 66, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4689), "6" },
                    { 67, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4710), 67, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4709), "7" },
                    { 68, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4731), 68, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4730), "8" },
                    { 69, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4750), 69, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4749), "9" },
                    { 70, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4792), 70, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4791), "0" },
                    { 71, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4813), 71, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4812), "1" },
                    { 72, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4832), 72, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4831), "2" },
                    { 73, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4852), 73, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4851), "3" },
                    { 74, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4871), 74, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4870), "4" },
                    { 75, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4891), 75, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4890), "5" },
                    { 76, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4912), 76, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4911), "6" },
                    { 77, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4955), 77, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4954), "7" },
                    { 78, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4976), 78, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4975), "8" },
                    { 79, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4995), 79, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(4993), "9" },
                    { 80, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5014), 80, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5013), "0" },
                    { 81, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5033), 81, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5032), "1" },
                    { 82, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5052), 82, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5051), "2" },
                    { 83, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5101), 83, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5100), "3" },
                    { 84, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5124), 84, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5123), "4" },
                    { 85, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5142), 85, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5141), "5" },
                    { 86, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5161), 86, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5160), "6" },
                    { 87, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5180), 87, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5179), "7" },
                    { 88, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5199), 88, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5198), "8" },
                    { 89, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5219), 89, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5218), "9" },
                    { 90, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5258), 90, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5257), "0" },
                    { 91, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5279), 91, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5278), "1" },
                    { 92, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5298), 92, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5297), "2" },
                    { 93, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5316), 93, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5315), "3" },
                    { 94, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5335), 94, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5334), "4" },
                    { 95, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5354), 95, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5353), "5" },
                    { 96, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5374), 96, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5373), "6" },
                    { 97, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5412), 97, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5411), "7" },
                    { 98, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5431), 98, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5430), "8" },
                    { 99, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5450), 99, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5449), "9" },
                    { 100, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5470), 100, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5469), "0" },
                    { 101, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5489), 101, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5487), "1" },
                    { 102, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5508), 102, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5506), "2" },
                    { 103, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5527), 103, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5526), "3" },
                    { 104, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5569), 104, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5568), "4" },
                    { 105, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5589), 105, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5588), "5" },
                    { 106, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5608), 106, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5607), "6" },
                    { 107, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5628), 107, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5627), "7" },
                    { 108, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5647), 108, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5646), "8" },
                    { 109, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5666), 109, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5665), "9" },
                    { 110, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5707), 110, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5706), "0" },
                    { 111, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5728), 111, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5727), "1" },
                    { 112, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5747), 112, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5746), "2" },
                    { 113, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5767), 113, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5766), "3" },
                    { 114, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5786), 114, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5785), "4" },
                    { 115, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5806), 115, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5805), "5" },
                    { 116, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5826), 116, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5825), "6" },
                    { 117, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5867), 117, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5866), "7" },
                    { 118, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5887), 118, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5886), "8" },
                    { 119, new DateTime(2023, 7, 7, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5906), 119, new DateTime(2023, 6, 16, 21, 56, 38, 266, DateTimeKind.Local).AddTicks(5905), "9" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 20, "Verdieping 20" },
                    { 21, "Verdieping 21" },
                    { 22, "Verdieping 22" },
                    { 23, "Verdieping 23" },
                    { 24, "Verdieping 24" },
                    { 25, "Verdieping 25" },
                    { 26, "Verdieping 26" },
                    { 27, "Verdieping 27" },
                    { 28, "Verdieping 28" },
                    { 29, "Verdieping 29" },
                    { 30, "Verdieping 30" },
                    { 31, "Verdieping 31" },
                    { 32, "Verdieping 32" },
                    { 33, "Verdieping 33" },
                    { 34, "Verdieping 34" },
                    { 35, "Verdieping 35" },
                    { 36, "Verdieping 36" },
                    { 37, "Verdieping 37" },
                    { 38, "Verdieping 38" },
                    { 39, "Verdieping 39" },
                    { 40, "Verdieping 40" },
                    { 41, "Verdieping 41" },
                    { 42, "Verdieping 42" },
                    { 43, "Verdieping 43" },
                    { 44, "Verdieping 44" },
                    { 45, "Verdieping 45" },
                    { 46, "Verdieping 46" },
                    { 47, "Verdieping 47" },
                    { 48, "Verdieping 48" },
                    { 49, "Verdieping 49" },
                    { 50, "Verdieping 50" },
                    { 51, "Verdieping 51" },
                    { 52, "Verdieping 52" },
                    { 53, "Verdieping 53" },
                    { 54, "Verdieping 54" },
                    { 55, "Verdieping 55" },
                    { 56, "Verdieping 56" },
                    { 57, "Verdieping 57" },
                    { 58, "Verdieping 58" },
                    { 59, "Verdieping 59" },
                    { 60, "Verdieping 60" },
                    { 61, "Verdieping 61" },
                    { 62, "Verdieping 62" },
                    { 63, "Verdieping 63" },
                    { 64, "Verdieping 64" },
                    { 65, "Verdieping 65" },
                    { 66, "Verdieping 66" },
                    { 67, "Verdieping 67" },
                    { 68, "Verdieping 68" },
                    { 69, "Verdieping 69" },
                    { 70, "Verdieping 70" },
                    { 71, "Verdieping 71" },
                    { 72, "Verdieping 72" },
                    { 73, "Verdieping 73" },
                    { 74, "Verdieping 74" },
                    { 75, "Verdieping 75" },
                    { 76, "Verdieping 76" },
                    { 77, "Verdieping 77" },
                    { 78, "Verdieping 78" },
                    { 79, "Verdieping 79" },
                    { 80, "Verdieping 80" },
                    { 81, "Verdieping 81" },
                    { 82, "Verdieping 82" },
                    { 83, "Verdieping 83" },
                    { 84, "Verdieping 84" },
                    { 85, "Verdieping 85" },
                    { 86, "Verdieping 86" },
                    { 87, "Verdieping 87" },
                    { 88, "Verdieping 88" },
                    { 89, "Verdieping 89" },
                    { 90, "Verdieping 90" },
                    { 91, "Verdieping 91" },
                    { 92, "Verdieping 92" },
                    { 93, "Verdieping 93" },
                    { 94, "Verdieping 94" },
                    { 95, "Verdieping 95" },
                    { 96, "Verdieping 96" },
                    { 97, "Verdieping 97" },
                    { 98, "Verdieping 98" },
                    { 99, "Verdieping 99" },
                    { 100, "Verdieping 100" },
                    { 101, "Verdieping 101" },
                    { 102, "Verdieping 102" },
                    { 103, "Verdieping 103" },
                    { 104, "Verdieping 104" },
                    { 105, "Verdieping 105" },
                    { 106, "Verdieping 106" },
                    { 107, "Verdieping 107" },
                    { 108, "Verdieping 108" },
                    { 109, "Verdieping 109" },
                    { 110, "Verdieping 110" },
                    { 111, "Verdieping 111" },
                    { 112, "Verdieping 112" },
                    { 113, "Verdieping 113" },
                    { 114, "Verdieping 114" },
                    { 115, "Verdieping 115" },
                    { 116, "Verdieping 116" },
                    { 117, "Verdieping 117" },
                    { 118, "Verdieping 118" },
                    { 119, "Verdieping 119" }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 100, 1, "1" },
                    { 200, 2, "2" },
                    { 300, 3, "3" },
                    { 400, 4, "4" },
                    { 500, 5, "5" },
                    { 600, 6, "6" },
                    { 700, 7, "7" },
                    { 800, 8, "8" },
                    { 900, 9, "9" },
                    { 1000, 10, "0" },
                    { 1100, 11, "1" },
                    { 1200, 12, "2" },
                    { 1300, 13, "3" },
                    { 1400, 14, "4" },
                    { 1500, 15, "5" },
                    { 1600, 16, "6" },
                    { 1700, 17, "7" },
                    { 1800, 18, "8" },
                    { 1900, 19, "9" },
                    { 2000, 20, "0" },
                    { 2100, 21, "1" },
                    { 2200, 22, "2" },
                    { 2300, 23, "3" },
                    { 2400, 24, "4" },
                    { 2500, 25, "5" },
                    { 2600, 26, "6" },
                    { 2700, 27, "7" },
                    { 2800, 28, "8" },
                    { 2900, 29, "9" },
                    { 3000, 30, "0" },
                    { 3100, 31, "1" },
                    { 3200, 32, "2" },
                    { 3300, 33, "3" },
                    { 3400, 34, "4" },
                    { 3500, 35, "5" },
                    { 3600, 36, "6" },
                    { 3700, 37, "7" },
                    { 3800, 38, "8" },
                    { 3900, 39, "9" },
                    { 4000, 40, "0" },
                    { 4100, 41, "1" },
                    { 4200, 42, "2" },
                    { 4300, 43, "3" },
                    { 4400, 44, "4" },
                    { 4500, 45, "5" },
                    { 4600, 46, "6" },
                    { 4700, 47, "7" },
                    { 4800, 48, "8" },
                    { 4900, 49, "9" },
                    { 5000, 50, "0" },
                    { 5100, 51, "1" },
                    { 5200, 52, "2" },
                    { 5300, 53, "3" },
                    { 5400, 54, "4" },
                    { 5500, 55, "5" },
                    { 5600, 56, "6" },
                    { 5700, 57, "7" },
                    { 5800, 58, "8" },
                    { 5900, 59, "9" },
                    { 6000, 60, "0" },
                    { 6100, 61, "1" },
                    { 6200, 62, "2" },
                    { 6300, 63, "3" },
                    { 6400, 64, "4" },
                    { 6500, 65, "5" },
                    { 6600, 66, "6" },
                    { 6700, 67, "7" },
                    { 6800, 68, "8" },
                    { 6900, 69, "9" },
                    { 7000, 70, "0" },
                    { 7100, 71, "1" },
                    { 7200, 72, "2" },
                    { 7300, 73, "3" },
                    { 7400, 74, "4" },
                    { 7500, 75, "5" },
                    { 7600, 76, "6" },
                    { 7700, 77, "7" },
                    { 7800, 78, "8" },
                    { 7900, 79, "9" },
                    { 8000, 80, "0" },
                    { 8100, 81, "1" },
                    { 8200, 82, "2" },
                    { 8300, 83, "3" },
                    { 8400, 84, "4" },
                    { 8500, 85, "5" },
                    { 8600, 86, "6" },
                    { 8700, 87, "7" },
                    { 8800, 88, "8" },
                    { 8900, 89, "9" },
                    { 9000, 90, "0" },
                    { 9100, 91, "1" },
                    { 9200, 92, "2" },
                    { 9300, 93, "3" },
                    { 9400, 94, "4" },
                    { 9500, 95, "5" },
                    { 9600, 96, "6" },
                    { 9700, 97, "7" },
                    { 9800, 98, "8" },
                    { 9900, 99, "9" },
                    { 10000, 100, "0" },
                    { 10100, 101, "1" },
                    { 10200, 102, "2" },
                    { 10300, 103, "3" },
                    { 10400, 104, "4" },
                    { 10500, 105, "5" },
                    { 10600, 106, "6" },
                    { 10700, 107, "7" },
                    { 10800, 108, "8" },
                    { 10900, 109, "9" },
                    { 11000, 110, "0" },
                    { 11100, 111, "1" },
                    { 11200, 112, "2" },
                    { 11300, 113, "3" },
                    { 11400, 114, "4" },
                    { 11500, 115, "5" },
                    { 11600, 116, "6" },
                    { 11700, 117, "7" },
                    { 11800, 118, "8" },
                    { 11900, 119, "9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "103");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "105");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "106");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "107");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "108");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "113");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "116");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "117");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "118");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "120");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10900);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11000);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11100);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11200);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11300);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11400);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11500);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11600);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11700);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11800);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11900);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bf1278c2-5f81-45e0-9376-76f79cec1e13", "Tony_Davis53@hotmail.com", "b75f7f42958908caa2f44c56299d2543538243b1", "0f2484da-ee7c-40ce-8303-7468765ba877", "Tony_Davis53@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c3fd6361-af0b-4ab0-8036-ff405ce03f45", "Blanca_Collins1@hotmail.com", "fb20f60e8624f0e6b3a01bfb84da4fd5ae2f1661", "e15035be-105c-4b87-ba0b-3d2936be93d4", "Blanca_Collins1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "604564f4-4b99-46a8-aaca-145ee1465e64", "Bertha_Hermiston71@hotmail.com", "ef9e03945a9dcf7e9114cce8470097843abfacf3", "fe4aa36e-bf39-4d75-8b40-3b41bd94c823", "Bertha_Hermiston71@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "43f5e101-036e-49a3-b245-9fd93a19860b", "Desiree_Brakus@hotmail.com", "26e57c47b21b33b53afcbb76d61075b76a795fa1", "55fd9807-b8f9-4d39-9efe-12d7c32e2f5a", "Desiree_Brakus@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "aa0b83c6-58e5-49be-aa99-0a3338a12b9d", "Ruth.Senger36@yahoo.com", "524e46c4208fe0da4420d0f14246d33bfeb3de31", "9256d631-62b3-4a41-834d-9a8dc3024446", "Ruth.Senger36@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f56a8b71-e70f-43ef-b121-5a15bf0ddf8f", "Eloise.Funk@gmail.com", "2343821ad907109342a45ac0dbe1b993146590c8", "40c0941f-9427-47c7-9c44-2edb0dd3510b", "Eloise.Funk@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "68760529-5c0f-4bf7-8bb7-071ccb103a33", "Nettie.Hermann@yahoo.com", "046427e1202616d6a02c6b544578e0ec6636b3dc", "d462ffe6-b1a1-4835-8087-71380d45d9e3", "Nettie.Hermann@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "128aca33-2d7e-427e-b284-79fbd01a022e", "Deborah90@gmail.com", "0cbe28fed0ed7e6ad41adf766fbacf19f612be54", "f3f43c9d-1cc0-4060-ad36-77301de02517", "Deborah90@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e79312cc-2d2c-4b1e-98c6-0c550b45e05f", "Andy43@gmail.com", "33915f1145a39a4c3e91d55ddd22d74b63a12907", "0b3036e5-397f-482d-b0b9-0bc7d6450b2b", "Andy43@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05eb9c52-3642-468d-a2a6-45248c056a2c", "Sara.Stamm62@hotmail.com", "c353a89bf03f5ed000370279d77431296f927e1e", "efa0fe13-36eb-4807-8045-effa9994736d", "Sara.Stamm62@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d92ce7e4-c037-4831-bf05-dfb729a79774", "Aaron.Kuphal@hotmail.com", "67f0b0bb7b499271fd93d4a65054e845d20176a5", "6f7e0a9f-67a9-4485-927a-95f8470a154a", "Aaron.Kuphal@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a784bba6-057c-4301-b171-aa0351694199", "Danny40@hotmail.com", "e1f8e2da6fd89e433622654288c17b5b0c9a45a2", "23938475-9538-434f-8ca4-1a4870d25cd0", "Danny40@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6af8b126-d5bb-4c65-bf00-46d7efe9115e", "Roman.Spencer79@hotmail.com", "163ef2b8fed0f780c6096cfb2ed1ce329e9337f5", "3bd664df-212d-4ede-b568-d146b3a2a501", "Roman.Spencer79@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "64689127-02d9-4d1b-a606-67c10951f331", "Horace24@yahoo.com", "4482c75c373c8d73407fe4284cfdebbbf02dbdae", "e3493a5c-aee0-4b0c-bd54-3c69add96e9d", "Horace24@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "adb744a4-f256-4e6d-a937-3eb1b5f456c1", "Amanda.Barton41@gmail.com", "6a8e501caddda9bb9c298155621216a094cd7679", "e139645e-1431-4b02-a487-75f961ffb714", "Amanda.Barton41@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8a141628-527f-47ac-93dc-fd2fd4ea3409", "Robert.Jenkins@gmail.com", "d8c5e8dfb4955858f749992fd59bf95ced9013ba", "b23a696f-09b3-43b0-b0e6-d863452a6cd2", "Robert.Jenkins@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5bbd1594-77a0-4a56-b538-4b6335834d21", "Bernadette87@yahoo.com", "65d632e6e151cdc930aa30d979d5f18d29e20b99", "10578a2c-e1ba-40c1-a0ca-f0b2a7b32aed", "Bernadette87@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "1176ba41-e47a-4f86-ac82-c0338fb7b449", "Kurt29@hotmail.com", "5df4157405eba5cae8ae74030e7dd96ea4e3ba80", "6edc2ee3-65f6-4410-bc56-f510abd9ff25", "Kurt29@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "387ac031-75bb-408c-b2be-523f5a2fedf5", "Jeremiah_Conroy@yahoo.com", "3c9d97ad5ec9bd0990acc4a978f9ac093bb8d3c8", "43333c2c-fa21-4441-bfe4-895bdbfd5007", "Jeremiah_Conroy@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "ConcurrencyStamp", "Email", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "86db1ccf-f886-4dbb-8df3-8a151a910147", "Domingo5@hotmail.com", "e8d32c13b08f8077fa5aa9dda2bdca15e3273fa0", "2d8ff71a-4ef6-4f5f-9700-fd8a94d8d27e", "Domingo5@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Harold Sporer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Lydia Lockman");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Abraham Pfeffer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Kim Mertz");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Rodolfo Gislason");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Marianne Crona");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Noah Stiedemann");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Willis Padberg");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Blanche Beer");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Jack Gutmann");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Guadalupe Huel");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Kristina Renner");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Darnell Crist");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Cary Wyman");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Daniel Pacocha");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Tommie Lockman");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Roger Dicki");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "Dianna Schroeder");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "Darnell Rolfson");

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "Hilda Dooley");

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8257), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8319), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8318) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8344), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8368), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8434), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8486), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8594), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8623), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8670), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8692) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8715), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8781), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8888), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8945), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8999), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(9025), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 7, 7, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(9049), new DateTime(2023, 6, 16, 19, 23, 45, 422, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "ItemId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "1" },
                    { 2, 2, "2" },
                    { 3, 3, "3" },
                    { 4, 4, "4" },
                    { 5, 5, "5" },
                    { 6, 6, "6" },
                    { 7, 7, "7" },
                    { 8, 8, "8" },
                    { 9, 9, "9" },
                    { 10, 10, "0" },
                    { 11, 11, "1" },
                    { 12, 12, "2" },
                    { 13, 13, "3" },
                    { 14, 14, "4" },
                    { 15, 15, "5" },
                    { 16, 16, "6" },
                    { 17, 17, "7" },
                    { 18, 18, "8" },
                    { 19, 19, "9" }
                });
        }
    }
}
