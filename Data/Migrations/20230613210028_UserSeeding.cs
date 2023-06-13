using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "4c70101d-c612-42d3-8fe6-e4e24a4dd3c1", "Robin16@gmail.com", true, false, null, null, null, "84a5ebe9818adc830cffa4e2914acc944836f380", null, false, "e4687948-2586-4024-8e0f-892a6b026dd2", false, "Robin16@gmail.com" },
                    { "10", 0, "3b039748-83f7-46fc-84b6-fc146eefe2f0", "George_Herzog90@gmail.com", true, false, null, null, null, "87162fd7dc56e637d52f9b77d53673b9c7252108", null, false, "3d1ab0ad-6cd9-4156-bc64-8694bbb81fa8", false, "George_Herzog90@gmail.com" },
                    { "100", 0, "b1365f0b-9142-4274-b907-63b119e312a7", "Teresa57@yahoo.com", true, false, null, null, null, "49ff78d0b48bbf9b740f07badaad85794cabb0c9", null, false, "79318fd9-0fb4-4111-b436-cdeff78f2f1e", false, "Teresa57@yahoo.com" },
                    { "11", 0, "f3eae39f-775d-4fd1-bbe2-446f5d196e67", "Gilberto29@gmail.com", true, false, null, null, null, "e2635b64d01852be6d856a258dce924121d60965", null, false, "2ec624a5-e91c-4361-803d-aabc507dfee6", false, "Gilberto29@gmail.com" },
                    { "12", 0, "176f724f-a73c-4165-bdeb-31a5356b5b40", "Laura_Reinger@gmail.com", true, false, null, null, null, "ccb6afa3a16ca82ddbd9a4b1a8e8de50d43e6885", null, false, "1c027f2b-a07c-4028-a8eb-2a863b7bab38", false, "Laura_Reinger@gmail.com" },
                    { "13", 0, "4c999698-25f9-41c4-a5b6-911be7cfbd51", "Dave.Stark@yahoo.com", true, false, null, null, null, "178d2e27e6768d3e6505c59e80ba4deb0119741d", null, false, "ed1c6d59-260f-4ea4-9c39-2b4e34d8f81d", false, "Dave.Stark@yahoo.com" },
                    { "14", 0, "7bb61c1a-3eff-4f21-b8d5-ad7b3e11d602", "Valerie.Hamill48@yahoo.com", true, false, null, null, null, "4bcfdffb6551c0d48ef0ca042e8dbf45de87b714", null, false, "a0313396-4b93-46d2-a0a1-7f4cce1686e4", false, "Valerie.Hamill48@yahoo.com" },
                    { "15", 0, "22446719-859a-4430-a475-28dc07fb8b95", "Floyd_Gorczany58@gmail.com", true, false, null, null, null, "108ac2665ea90f69addc0483971f9a2d6a494d80", null, false, "9b4cb9ca-e473-4eb8-8bc1-1760e93fcdf4", false, "Floyd_Gorczany58@gmail.com" },
                    { "16", 0, "c435e332-a0ab-407b-acb5-8524ab8fb6e1", "Leigh_Mayert1@hotmail.com", true, false, null, null, null, "a3cd8d30c61600cbe9d385d142d17cd8647f4aa5", null, false, "181289fd-c934-4466-9be7-c04271c2f938", false, "Leigh_Mayert1@hotmail.com" },
                    { "17", 0, "ae382df7-1e0b-4d16-b6ed-d82ca26390d5", "Lowell36@gmail.com", true, false, null, null, null, "6627c6e89ff841b0808349c79483139680d8a567", null, false, "a2763c1b-b5e3-4628-9198-7dab0e63e1b6", false, "Lowell36@gmail.com" },
                    { "18", 0, "51a0839e-fe61-45e9-9f78-c07e8932e1f3", "Max_Zulauf58@gmail.com", true, false, null, null, null, "27054d5e04061ce5c4e2cde2303ae4b54aebfc6a", null, false, "7fb88410-6c73-4832-9fe3-8125b7270e47", false, "Max_Zulauf58@gmail.com" },
                    { "19", 0, "086acedb-6df2-460c-a332-c92cd7bfae44", "Gary39@yahoo.com", true, false, null, null, null, "4af5dc0327550ac8042be9eec1a2ba7abca77fdc", null, false, "f787ac28-4ec4-4f75-a541-4b01fb40c2e3", false, "Gary39@yahoo.com" },
                    { "2", 0, "b2cc0c75-e9bf-4ce8-bc86-bc0965880464", "Stephen.Upton@yahoo.com", true, false, null, null, null, "cb1c40a1a5ba82b29ced0b2a2d965d84c5f51ba6", null, false, "6ab8e592-12f1-4e46-b4b7-2c9277b5f922", false, "Stephen.Upton@yahoo.com" },
                    { "20", 0, "59956508-ba51-40b5-b483-b615872c8011", "Celia53@gmail.com", true, false, null, null, null, "b7f3455526fb096b1833fc80303911fb5d2317eb", null, false, "ea8a7888-622d-4946-8b87-ce9bc45af404", false, "Celia53@gmail.com" },
                    { "21", 0, "720207ea-116c-4e19-bfa4-b78c54f6c3fd", "Nellie21@hotmail.com", true, false, null, null, null, "adfd04265c7da50f7e2492da00dcd4ce76b85423", null, false, "4529b989-d544-4134-8e85-ef70102076a4", false, "Nellie21@hotmail.com" },
                    { "22", 0, "f321caac-1496-4b2d-9d97-a122e25ff653", "Kerry.Wintheiser@gmail.com", true, false, null, null, null, "6ecfe6861189b97b6f075642805b06e7c0204df2", null, false, "b33f0a78-d856-4bf6-887a-b4d65e2d2f18", false, "Kerry.Wintheiser@gmail.com" },
                    { "23", 0, "1dd2eb38-a2b4-47f2-aeba-df5abffce8c0", "Erin_Kreiger76@gmail.com", true, false, null, null, null, "1112add1444635a49bbb38a26d456ea295c761ac", null, false, "41dc0c89-e9ee-492c-8e23-bc57b2b40df0", false, "Erin_Kreiger76@gmail.com" },
                    { "24", 0, "7064d36d-fbcd-41fb-91f4-f1ead01d9b55", "Amelia.Kihn15@gmail.com", true, false, null, null, null, "1db14ba131b650d3762fbe3ed27b13e2d6b14d85", null, false, "0d20190c-4a23-486a-88cb-36bd1ee795c8", false, "Amelia.Kihn15@gmail.com" },
                    { "25", 0, "6d69cf92-0ab0-4480-a1e0-52cf741bbe80", "Rudolph_Feest@gmail.com", true, false, null, null, null, "ca89f1958454e522bf57cc10958fd0a44dba7e07", null, false, "a9131293-7010-4fb7-832e-a591940e9799", false, "Rudolph_Feest@gmail.com" },
                    { "26", 0, "294996de-0ff0-4cf7-bd12-09adc566482b", "Herman44@hotmail.com", true, false, null, null, null, "ba93a2fdcbde42e6c02ccb004afc79c23c9041ac", null, false, "2cefa86a-d7dc-46bc-a8f9-5458b12ccfa2", false, "Herman44@hotmail.com" },
                    { "27", 0, "ce59c064-e847-413e-9e33-9a1869b6a7ec", "Lloyd.Murazik@yahoo.com", true, false, null, null, null, "55a016c1f594083bc39fd5c1841eb761b9a1e5e4", null, false, "0879a0a9-0f80-4029-a81c-4f136cbc29ae", false, "Lloyd.Murazik@yahoo.com" },
                    { "28", 0, "f7136d66-95c8-48a0-9fb1-727d004dcb53", "Elena46@hotmail.com", true, false, null, null, null, "3efab1429505fb957525bcebbe9e7e6ee9cc8cda", null, false, "912ec376-d219-4a60-a957-8ea0dcae21a6", false, "Elena46@hotmail.com" },
                    { "29", 0, "1ee3d734-8f05-49c1-879f-f0749b00c19f", "Nancy.Schowalter20@gmail.com", true, false, null, null, null, "76f703609f2269fe2959c90139306d882a8d9586", null, false, "fc1f5dde-39c2-486d-8424-fcdd3cadc6a4", false, "Nancy.Schowalter20@gmail.com" },
                    { "3", 0, "8b216fa4-2b12-46a9-8d2b-d9a5977b209a", "Kari.Ward@gmail.com", true, false, null, null, null, "46167986ca1517b3000a78ad8dddcda5b826f22b", null, false, "02b202cd-58d1-4c7e-8d95-34c6c6cc768b", false, "Kari.Ward@gmail.com" },
                    { "30", 0, "bbc627c5-4cb7-4e18-b5d2-2a7007eb91b9", "Jill89@hotmail.com", true, false, null, null, null, "cf2c42e9c60b6876852f30f5e56b6ffa3b711c1e", null, false, "5b097bf2-8547-4a28-b057-03de57720e91", false, "Jill89@hotmail.com" },
                    { "31", 0, "225bbfc7-d57c-4f89-a3c1-e52fe2a1e129", "Barbara27@yahoo.com", true, false, null, null, null, "dfc34a77114f27b0b59fb81b3c178bc1ea0b4d56", null, false, "c4fcb194-4333-4e9f-a752-71d2a794cf2f", false, "Barbara27@yahoo.com" },
                    { "32", 0, "cc6f44c5-3460-49e2-8530-b3574b622c8b", "Neil_Hackett70@yahoo.com", true, false, null, null, null, "e845c59d9e35e769f79d2ab74ab51edcf700521a", null, false, "cf2508e7-75b4-4b79-94b3-766bd4c4fff5", false, "Neil_Hackett70@yahoo.com" },
                    { "33", 0, "2c087e96-c956-42be-8859-c09327d4c354", "Tasha.Labadie@gmail.com", true, false, null, null, null, "6b779f6dc6d1e0d4e1d7cd48169940d7f629496d", null, false, "bf7cef19-f18c-45e1-96d0-4b8aea5d45f4", false, "Tasha.Labadie@gmail.com" },
                    { "34", 0, "1082412c-0448-4d21-811c-26384acab45c", "Ken.Sanford44@yahoo.com", true, false, null, null, null, "869b4cceadcd94dbc9f167a80cbe722e48fb6ad0", null, false, "b0c33dab-d830-4c99-a7bb-45e2940acf83", false, "Ken.Sanford44@yahoo.com" },
                    { "35", 0, "13c101b6-c261-4671-82d6-db4e160bc008", "Cora2@yahoo.com", true, false, null, null, null, "fce3f563829348635621398f4b16e3285cf67602", null, false, "4474df5b-2107-4ead-9d97-99a58ad49342", false, "Cora2@yahoo.com" },
                    { "36", 0, "53d31016-726f-4ced-a13a-afb5b216f26f", "Tommy76@yahoo.com", true, false, null, null, null, "0ecc8948c8303f23c4ef65e9a514cec78a8e068e", null, false, "67ea558b-9d25-4083-8afd-d6178bd66c95", false, "Tommy76@yahoo.com" },
                    { "37", 0, "f316d14c-4ad2-4b4b-8ad3-1bd65d1eb7b2", "Nick_Vandervort@hotmail.com", true, false, null, null, null, "fd657dfd86ba74d6c48804ca4e95147dd1ec604f", null, false, "ce6066c3-4626-4bce-a932-b148fbe8aa53", false, "Nick_Vandervort@hotmail.com" },
                    { "38", 0, "3b3b1bca-6e83-4a44-b207-86a6bbd9be72", "Allison.Reynolds40@hotmail.com", true, false, null, null, null, "5a66581649564fac012ff309b453f31ff5f27674", null, false, "0e3b1285-1cf4-40b3-89c6-89d77ce3f127", false, "Allison.Reynolds40@hotmail.com" },
                    { "39", 0, "6586d0a5-c73f-447d-9ddb-fe46ce2ca0f0", "Leah_Johns61@hotmail.com", true, false, null, null, null, "1feb77af63243736ef250fb535bd949f5a11c2c6", null, false, "5d5a0769-d65b-4b9d-958e-50a08a13029a", false, "Leah_Johns61@hotmail.com" },
                    { "4", 0, "944731ff-928e-4c40-a8ad-aab7100365fa", "Alma24@hotmail.com", true, false, null, null, null, "214aa57c93afca7478a19a186e10d9486974c6c4", null, false, "c688887b-dcce-4d9d-b212-c1b88c64e8cf", false, "Alma24@hotmail.com" },
                    { "40", 0, "8d4bf390-e857-4141-aa3f-3d4f573b617f", "Alfred.Kutch@gmail.com", true, false, null, null, null, "3449b5b623f4eb9fabed292b2c5898f23f7a5862", null, false, "3aea2ab7-6ea3-49c2-bd1b-76d88b42bf7f", false, "Alfred.Kutch@gmail.com" },
                    { "41", 0, "3eb3c589-7d72-4b4a-91b8-648c663de3d3", "Gregg.Beier31@yahoo.com", true, false, null, null, null, "516a46a83955abfbe23ab7f23a04040cf5b06549", null, false, "ff5db299-bb90-44b4-b727-46500e469f4d", false, "Gregg.Beier31@yahoo.com" },
                    { "42", 0, "ae94df9e-8ab0-42c3-90cf-ee376ed3e88e", "Cary.Cassin@gmail.com", true, false, null, null, null, "592d94bf1488a125ea2a4f4d01e8dc7c9afa09bd", null, false, "aac79f98-8207-4e5b-9a15-e4d630c834d5", false, "Cary.Cassin@gmail.com" },
                    { "43", 0, "5412b28b-9048-4b3e-a58d-156784a7c283", "Courtney.Mann12@hotmail.com", true, false, null, null, null, "15ccf8c2cee1e030dcf92333b937cbba8051feec", null, false, "45476c18-4e67-4780-80d3-4cd126037120", false, "Courtney.Mann12@hotmail.com" },
                    { "44", 0, "b3425654-be56-48a2-8ee0-bcdb3b408ad6", "Howard_Miller@gmail.com", true, false, null, null, null, "54caa15a80293a0885329d4b70fdd957e23acf9d", null, false, "ec59f056-1e22-474e-b0e0-2a218b8deb1a", false, "Howard_Miller@gmail.com" },
                    { "45", 0, "61454e6e-86f6-4408-8b0e-09b60f5df8e7", "Juana_Weissnat8@gmail.com", true, false, null, null, null, "463fc0b93063ba0ce50b001e826ce02795388407", null, false, "a53359c8-9b03-4f23-8dfa-cbe534445f2c", false, "Juana_Weissnat8@gmail.com" },
                    { "46", 0, "934639dd-f1f3-4cdc-b1de-b3a951e19598", "Joanne_Lebsack@gmail.com", true, false, null, null, null, "82a8275a0a6d3e7a3b7fa1b554cbf7329f8bc5b1", null, false, "3a019a54-0b43-4df0-85c5-2c57fd115ff0", false, "Joanne_Lebsack@gmail.com" },
                    { "47", 0, "5d2d3e16-4678-40c9-b204-9aad5af2e9ce", "Alberta_Walsh33@yahoo.com", true, false, null, null, null, "fe053136e661bac3c33f2ebf293927d22c76d264", null, false, "797aa34d-fec4-4b1c-bbdb-497a66f9731d", false, "Alberta_Walsh33@yahoo.com" },
                    { "48", 0, "a75f9118-7c12-450b-abe1-86a13c13ec50", "Gerardo_Bogan55@hotmail.com", true, false, null, null, null, "0935fac46e44026f39491115db4f16ade2e446eb", null, false, "de8cc8e6-d13c-43f0-bcdb-becb07892c9b", false, "Gerardo_Bogan55@hotmail.com" },
                    { "49", 0, "6800fa11-bf4e-4a57-a054-cc73423057a9", "Henrietta_Bergstrom@hotmail.com", true, false, null, null, null, "614e2d1707e5fc1c7fda9d5f4db6a9ccb0b99185", null, false, "b777554a-c25c-4f32-b9c9-e65361d4ae4d", false, "Henrietta_Bergstrom@hotmail.com" },
                    { "5", 0, "a68f622f-e6f3-45c9-b8d9-f41699ed86cf", "James27@hotmail.com", true, false, null, null, null, "815de5ace2ccfa1e26b7068382cd3863eb50890d", null, false, "64c91876-9ae3-46e6-bf93-e41a7ba0d6b7", false, "James27@hotmail.com" },
                    { "50", 0, "a287a4c3-2f37-454c-9b15-68cb584d0b0d", "Tiffany_Stehr@yahoo.com", true, false, null, null, null, "dab32625a2fa453b2729cb6f6f07923e70284589", null, false, "eb78da20-2244-4164-b108-6ca2ae979ba2", false, "Tiffany_Stehr@yahoo.com" },
                    { "51", 0, "a8623b53-66d9-4abc-87a3-26640bc14452", "Conrad83@gmail.com", true, false, null, null, null, "87931ba408aba12d6531091399d0d04c72d58ba0", null, false, "1474b29f-3a4a-49f5-bdd5-27210424a1e8", false, "Conrad83@gmail.com" },
                    { "52", 0, "01f82178-929c-4458-8d30-cf385cb28bdf", "Forrest5@gmail.com", true, false, null, null, null, "41062c5b6d3ce15a96bd15d3133b6740f92390f4", null, false, "d1e77467-a943-4e91-85d9-d8d4dac39f4b", false, "Forrest5@gmail.com" },
                    { "53", 0, "ee8eadc1-f20a-4645-9c8c-480e6145d358", "Jake.Ledner63@gmail.com", true, false, null, null, null, "0860735681f4f1a1ea751016bd446f19bc482f0a", null, false, "54e3de46-cf60-4d91-8f1e-4cb7ad3aad94", false, "Jake.Ledner63@gmail.com" },
                    { "54", 0, "bab9e11e-9459-4ebf-8efa-3e11af39fea3", "Pam.Dickens@yahoo.com", true, false, null, null, null, "8e48b713774ea3852f5b4ad5233a175fce14b7ea", null, false, "0de47c57-6b06-4e14-834d-04f823364a31", false, "Pam.Dickens@yahoo.com" },
                    { "55", 0, "6c010fda-c634-45a3-bfae-3f2f7d51765d", "Guy_Jones@hotmail.com", true, false, null, null, null, "03510079604a8d005b1c3632ddaf2ee20edd7fd4", null, false, "fa92f9c4-4303-4fec-ba3a-5d0d6e51dc89", false, "Guy_Jones@hotmail.com" },
                    { "56", 0, "10754c2c-c3bc-481e-a40d-58128e3366ab", "Rose.Leannon65@hotmail.com", true, false, null, null, null, "d9155bf258d1ac3caed09e4473416f64bc323ec3", null, false, "1a8eaaca-593d-4351-8b49-5a153b82c2a8", false, "Rose.Leannon65@hotmail.com" },
                    { "57", 0, "10ae0302-bdb8-40e9-9c94-cf26eda837f3", "Jean_Kohler@gmail.com", true, false, null, null, null, "5fa84c6b01174d577d474f813ae5a502d273a24f", null, false, "96cbf62f-f4cb-4349-ae83-00a89b088a81", false, "Jean_Kohler@gmail.com" },
                    { "58", 0, "bffb57c0-296d-46df-bc62-fdf76471e79b", "Johanna.Ullrich49@gmail.com", true, false, null, null, null, "803a09652a57ae2d2d2bd11b77bb7c91b7f65046", null, false, "eae408e5-e707-4f76-b15d-dec30f4c9ffb", false, "Johanna.Ullrich49@gmail.com" },
                    { "59", 0, "8787eaa5-6f2b-43e4-ba25-cdbcb9bf37f6", "Pauline.Russel86@hotmail.com", true, false, null, null, null, "c8a47a065577c8ac9820329cd58d8c73c929920e", null, false, "6f311892-c810-4070-ae33-6f4489aa129d", false, "Pauline.Russel86@hotmail.com" },
                    { "6", 0, "84aa0b9a-c038-4e5b-9369-16ff09a94202", "Tammy5@gmail.com", true, false, null, null, null, "34d9c1e791cf470c8ce71f01778573777a5126d0", null, false, "5e512438-2360-4d8c-b170-3c1651cf04b3", false, "Tammy5@gmail.com" },
                    { "60", 0, "4e9a445b-86fc-417b-84f1-fcac123eeb2f", "Dean.Marks@gmail.com", true, false, null, null, null, "a8e1bc4c0c9bd1c5dfe55af57209427b585edbde", null, false, "14b217ad-8115-46e8-9209-b96f1cbba970", false, "Dean.Marks@gmail.com" },
                    { "61", 0, "fcc7e6dd-497d-46c2-8a1c-9dcf090b92ea", "Hubert.Schultz76@gmail.com", true, false, null, null, null, "e189412378054e6bc841b4c4cbefdef4ae48db1d", null, false, "a2757bba-fa5e-4588-8f23-b35f40c9bd46", false, "Hubert.Schultz76@gmail.com" },
                    { "62", 0, "86ac0972-ca3c-4e01-968b-fce651397e7e", "Ian.Bogisich@hotmail.com", true, false, null, null, null, "3feeca092f1269d12072029048dbf8774a4f5d68", null, false, "e871f288-f139-41b3-8338-3d7a36973e1b", false, "Ian.Bogisich@hotmail.com" },
                    { "63", 0, "d76abe11-f333-4ae4-85dc-fca2bc4fe5d6", "Jana.Dickinson94@yahoo.com", true, false, null, null, null, "312a501b0d6077a2e84fddd66385b65e4bd16e60", null, false, "00119a11-b28b-43fc-9774-660a0ef10187", false, "Jana.Dickinson94@yahoo.com" },
                    { "64", 0, "fb2d869f-eedd-431a-a50f-0c9bf82ce2dd", "Darla86@yahoo.com", true, false, null, null, null, "2d286608098347dbfb6e5af2eb180406f2281d04", null, false, "d2ec05b2-a127-4e4d-910f-11cd24d2d3ae", false, "Darla86@yahoo.com" },
                    { "65", 0, "def1c2f3-fae0-4f8c-a44e-45db21f8a5f0", "Vickie.Feil31@gmail.com", true, false, null, null, null, "285c7c4f88db3ce9319207f443a36f3eca9ac468", null, false, "b3cfc005-5108-4dd4-b485-a246197c3ca1", false, "Vickie.Feil31@gmail.com" },
                    { "66", 0, "f9958d4f-9855-4813-a9ac-5f43ac30020a", "Rex45@gmail.com", true, false, null, null, null, "3bf36d8601fd512a323ea73763c1a4338f12c6e3", null, false, "d2d1167d-ea05-4011-8b53-1b628da94174", false, "Rex45@gmail.com" },
                    { "67", 0, "21da20e7-3721-4eb8-905d-3e17bd995cb4", "Angelo22@gmail.com", true, false, null, null, null, "ebfb4dfd3c91e08123f450150cdac829700b568e", null, false, "3c1655fb-3ba1-4142-be15-edf9837b09ba", false, "Angelo22@gmail.com" },
                    { "68", 0, "c85333f9-afd6-42cf-8522-a795ab202465", "Jordan_Wilderman@hotmail.com", true, false, null, null, null, "f67484bac6a54daeeb88fcfc2c0918611e3cea47", null, false, "78d7b183-3cfb-4d1e-aba3-94a3e0fd0d7e", false, "Jordan_Wilderman@hotmail.com" },
                    { "69", 0, "d6f239bc-f643-4619-8682-8274cbcfda4a", "Alison16@hotmail.com", true, false, null, null, null, "595d958a9570e2496ede65acd770bd36016872b5", null, false, "2f2a1d6c-893d-4289-9b94-53c93372abb6", false, "Alison16@hotmail.com" },
                    { "7", 0, "3a042d47-efd6-4c28-918e-682acafc067b", "Bryan_Botsford89@yahoo.com", true, false, null, null, null, "ccb48a5c8cef6a3a30e9bdcd8d81a34b0b864a7e", null, false, "9d053479-f1ba-454c-90cc-d16e325aaeb8", false, "Bryan_Botsford89@yahoo.com" },
                    { "70", 0, "ade1e16f-12cd-46ea-8c1c-12be4cf247c5", "Kayla_OKeefe40@gmail.com", true, false, null, null, null, "db33f5e73523bce6caf581baeed9929fd81e1f54", null, false, "efac4102-21b6-4b7f-8413-899b3d80c883", false, "Kayla_OKeefe40@gmail.com" },
                    { "71", 0, "c19ae8c7-20cf-42d3-9c55-b23daf2e9095", "Edwin.Brakus@hotmail.com", true, false, null, null, null, "f7813a386e1ad8c656e0698419f37cfa8589a7c9", null, false, "69941d06-3bd7-4d8b-9707-8728bc6c6b7b", false, "Edwin.Brakus@hotmail.com" },
                    { "72", 0, "296c1c6a-fb27-43a4-a8df-a70c1bb5da9d", "Dale.Rowe94@gmail.com", true, false, null, null, null, "b4a4cfdbbf209e140edd35b07f72a62fde817b17", null, false, "4c75d73d-a295-403b-900d-cea93a4ed9bd", false, "Dale.Rowe94@gmail.com" },
                    { "73", 0, "16bdd2bc-6ef4-430d-9c4d-60bb769b65e2", "Neal_Hansen11@hotmail.com", true, false, null, null, null, "18244a7bc85b4f9746c6cbdb84b311d38241aa94", null, false, "4765ca74-3cf6-4843-bf40-1adfa2696fc6", false, "Neal_Hansen11@hotmail.com" },
                    { "74", 0, "aa3bbceb-fdbc-46dc-bf0d-9286c74f8690", "Carolyn.Ebert@gmail.com", true, false, null, null, null, "6fac3dc6ca96d4cb30835f6e6c27b7b5bdfd067e", null, false, "2ec1d668-d546-4965-837f-c1bfd2634e93", false, "Carolyn.Ebert@gmail.com" },
                    { "75", 0, "aab74907-3d11-4a10-b1bf-ac95d37ed554", "Clinton99@hotmail.com", true, false, null, null, null, "0d003134627d9752788c688b5262a8123994ec92", null, false, "b0e6b08f-a31a-4013-a0a5-6c7ce44def0d", false, "Clinton99@hotmail.com" },
                    { "76", 0, "95a7eae0-b5d9-4c56-8261-f1aadbf8d3a8", "Carol.Schulist57@yahoo.com", true, false, null, null, null, "5e780c5926510bcde461b28847fd009d172fef82", null, false, "2bbfdb53-c450-4f48-a777-18d97c01c1f4", false, "Carol.Schulist57@yahoo.com" },
                    { "77", 0, "a6385eb6-2d62-4e39-a3a5-bf25d60abfe6", "Antoinette3@hotmail.com", true, false, null, null, null, "97e3819daffaff55faf05271caac5e0e51397133", null, false, "a3fddf4b-6f1f-4da3-99cc-a427e6069a2a", false, "Antoinette3@hotmail.com" },
                    { "78", 0, "d9197ea1-5020-4590-ba84-0900a065e695", "Pablo.Harvey@gmail.com", true, false, null, null, null, "bb5e4fc3ebf6a702d3f2f7a537d05af9108db872", null, false, "2509f76b-c347-4a62-8ae8-24c28b4f6974", false, "Pablo.Harvey@gmail.com" },
                    { "79", 0, "42fab95e-4f54-469a-aeb0-3517446411a9", "Melissa.Strosin@yahoo.com", true, false, null, null, null, "ae4f82e6c329c041b9e57e7a4df74c773379463a", null, false, "44f44ccd-e7d4-4469-833a-b69a1990bdc7", false, "Melissa.Strosin@yahoo.com" },
                    { "8", 0, "2e5f4b6e-39d8-4177-8613-7471e12bb504", "Lowell.Conn98@yahoo.com", true, false, null, null, null, "27b2dedf9cb57534563e059d1b624acafae4c0bf", null, false, "c3cc57ee-f0db-4234-a059-9bfe4b0af925", false, "Lowell.Conn98@yahoo.com" },
                    { "80", 0, "fae5ccb5-fc7d-45bf-9700-9669d5cab5af", "Bradley_Aufderhar78@gmail.com", true, false, null, null, null, "ed6269d637c18efdfe52df6e691bfb2481bff88a", null, false, "3017ce09-cb39-4e5a-8c56-f7ec1ccce929", false, "Bradley_Aufderhar78@gmail.com" },
                    { "81", 0, "5cf840a2-8d8d-4a0c-aeb2-f96c61f2b459", "Derrick.Murazik@yahoo.com", true, false, null, null, null, "7cee3564f429e811fc208993229e112ad2fc4840", null, false, "1e71e9ea-292c-4bea-8200-805e539f2268", false, "Derrick.Murazik@yahoo.com" },
                    { "82", 0, "db71d9c2-1786-46ec-bdb4-acb00ba15024", "Yvonne.Graham@hotmail.com", true, false, null, null, null, "cb0e52e5dd353333d7193a716d30634558b85036", null, false, "e3387712-11c5-4418-a857-a58414ab71f5", false, "Yvonne.Graham@hotmail.com" },
                    { "83", 0, "b942209e-8df3-4254-84f0-73b64caca43e", "Garry_Batz@gmail.com", true, false, null, null, null, "7e3af7f8653201a8b455bbc1382255034f2f1687", null, false, "1cbe5ec3-bc03-4526-9242-fb38a7c94325", false, "Garry_Batz@gmail.com" },
                    { "84", 0, "da4662bd-0038-47fe-b8b2-c2d05c52501d", "Gregg75@hotmail.com", true, false, null, null, null, "b1b9f7ff3e9d597bd18b02c8ab6eddd65b096312", null, false, "e7b95279-c69f-4e3a-a88d-2074ab7c9864", false, "Gregg75@hotmail.com" },
                    { "85", 0, "731da182-5091-46f0-bb37-377d690b6805", "Bradley_Goyette27@gmail.com", true, false, null, null, null, "ab1e3feccb60e47e8310e0efd0c9905755834cca", null, false, "c96132f6-d989-4871-b1aa-9c33b1935ab5", false, "Bradley_Goyette27@gmail.com" },
                    { "86", 0, "e275f7e8-2beb-48cf-b444-5c31e3096c31", "Van_Mann@hotmail.com", true, false, null, null, null, "6d1d72fadbdd9f94509d7855cb3ca8f85b01cc5a", null, false, "96c01eef-4d7f-40ef-aa9a-c0981838aa0a", false, "Van_Mann@hotmail.com" },
                    { "87", 0, "12b527d3-b78c-4b91-9ae9-28b71a9545ae", "Jennifer_Little@yahoo.com", true, false, null, null, null, "2ffde24fb0bdd6bbdd6d9008437a78d6c32bb3a4", null, false, "69afe50e-a1cd-48b9-914c-b849b7cd0549", false, "Jennifer_Little@yahoo.com" },
                    { "88", 0, "04b3ac61-baf6-4909-8706-b68311c9c5e3", "Gloria_Ebert85@hotmail.com", true, false, null, null, null, "712fbbc8ece76f86748fd5a0ee5ad7e391df3d17", null, false, "514badff-92c8-4420-82a1-a61b1fb66258", false, "Gloria_Ebert85@hotmail.com" },
                    { "89", 0, "e536f5f0-7aa0-4c85-b9be-486bb96db8c6", "Olivia_Larkin11@yahoo.com", true, false, null, null, null, "6468e252ae54096b1baf8c6125a2739b49bec576", null, false, "aa84ae52-098b-43e8-9287-080536d6b242", false, "Olivia_Larkin11@yahoo.com" },
                    { "9", 0, "d4c81314-9b81-470b-af02-6f44c7fb4cb3", "Carlos.Predovic39@hotmail.com", true, false, null, null, null, "2b4031a9d50e72d885fda7cbd57c3abc5b9c0d9d", null, false, "46ac9deb-99a1-4a51-9b96-f94c73611570", false, "Carlos.Predovic39@hotmail.com" },
                    { "90", 0, "e5302c64-c3b7-4e55-a12e-e963eebded43", "Boyd_Leffler@gmail.com", true, false, null, null, null, "47ea502f15a4ae0bb74c51d5e89df587ef69db7d", null, false, "d6608283-3d2e-446b-b70b-367927c7fd9c", false, "Boyd_Leffler@gmail.com" },
                    { "91", 0, "f700252e-5f4e-4256-93aa-3a018e854812", "Trevor.Stroman@hotmail.com", true, false, null, null, null, "48ff54016b1f3a4d733e2e87990a3f8c81aa6a91", null, false, "a10c43aa-224a-4f5c-8310-7ea4ee50777d", false, "Trevor.Stroman@hotmail.com" },
                    { "92", 0, "cc2ec3c1-1929-416f-b217-a5ee0f6f4b84", "Gary.Bins34@hotmail.com", true, false, null, null, null, "f773b129f75edeace20e8dad13302559a1790709", null, false, "adbeb3d2-b20c-4eb3-9758-291307e9a86b", false, "Gary.Bins34@hotmail.com" },
                    { "93", 0, "3906bf9d-1145-4110-98fa-9efcbc2efd02", "Marianne.Casper66@hotmail.com", true, false, null, null, null, "cb0a9a454feee5e995c6eab89942ac0ce38842fa", null, false, "dfdee749-7644-4320-8c0d-ceebe65c8595", false, "Marianne.Casper66@hotmail.com" },
                    { "94", 0, "4a17679f-544e-4f01-bcc1-162bea4b053d", "Alexander.Feeney40@hotmail.com", true, false, null, null, null, "a36eefbcbd978066f6b4819b26e2cd5f7c81f791", null, false, "bf3e2617-03ba-4551-9a69-8cf5b09f8989", false, "Alexander.Feeney40@hotmail.com" },
                    { "95", 0, "239107b2-7e23-4b1b-b4d5-0b8a9891d8e9", "Lola79@gmail.com", true, false, null, null, null, "021d46b56a50a84569c8d7b65dc916ccb485e4f1", null, false, "4235751d-9a68-4bf7-8392-19fd16249427", false, "Lola79@gmail.com" },
                    { "96", 0, "c160015d-8d1e-48f5-bfde-c3a8e3491300", "Evan22@yahoo.com", true, false, null, null, null, "829499472875e5603e7252368d5def5291b99a05", null, false, "f346bb06-a34f-4cde-ab9b-b8409a70bc5e", false, "Evan22@yahoo.com" },
                    { "97", 0, "b760286a-9b62-41f4-9e52-c2d4ac476a64", "Byron_Mayert15@yahoo.com", true, false, null, null, null, "5437a4499c99db423975a91fb21d79c1f7f14637", null, false, "1b76e42a-69d2-49bb-a338-d8814179a743", false, "Byron_Mayert15@yahoo.com" },
                    { "98", 0, "4b8829a2-a1e4-48e6-b646-5f98dc82f3a9", "Ed.Greenfelder@hotmail.com", true, false, null, null, null, "457cdcf17f27919ee4c3eb876f4e5c79335e052f", null, false, "1b15e57f-8d29-481b-b53f-6d2ef7e02a2e", false, "Ed.Greenfelder@hotmail.com" },
                    { "99", 0, "59452fc1-52f6-44d4-895b-c920cb622c7f", "Forrest88@hotmail.com", true, false, null, null, null, "ec2b915bf2d1f5e890c755c9fea7c42d772072f6", null, false, "aa20bcc1-27a6-4ce9-9608-2aea15331d03", false, "Forrest88@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "EndDate", "ItemId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4570), 1, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4525), 1 },
                    { 2, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4650), 2, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4648), 2 },
                    { 3, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4676), 3, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4674), 3 },
                    { 4, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4690), 4, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4689), 4 },
                    { 5, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4708), 5, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4706), 5 },
                    { 6, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4722), 6, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4721), 6 },
                    { 7, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4735), 7, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4734), 7 },
                    { 8, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4748), 8, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4747), 8 },
                    { 9, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4790), 9, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4788), 9 },
                    { 10, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4806), 10, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4805), 10 },
                    { 11, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4821), 11, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4820), 11 },
                    { 12, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4835), 12, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4834), 12 },
                    { 13, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4848), 13, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4847), 13 },
                    { 14, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4862), 14, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4860), 14 },
                    { 15, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4876), 15, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4875), 15 },
                    { 16, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4890), 16, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4888), 16 },
                    { 17, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4904), 17, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4902), 17 },
                    { 18, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4918), 18, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4917), 18 },
                    { 19, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4932), 19, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4930), 19 },
                    { 20, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4977), 20, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4975), 20 },
                    { 21, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4991), 21, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(4989), 21 },
                    { 22, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5004), 22, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5003), 22 },
                    { 23, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5018), 23, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5016), 23 },
                    { 24, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5043), 24, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5042), 24 },
                    { 25, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5055), 25, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5054), 25 },
                    { 26, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5066), 26, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5065), 26 },
                    { 27, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5078), 27, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5076), 27 },
                    { 28, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5089), 28, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5088), 28 },
                    { 29, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5100), 29, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5099), 29 },
                    { 30, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5112), 30, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5111), 30 },
                    { 31, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5163), 31, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5162), 31 },
                    { 32, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5177), 32, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5176), 32 },
                    { 33, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5190), 33, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5189), 33 },
                    { 34, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5203), 34, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5202), 34 },
                    { 35, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5216), 35, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5214), 35 },
                    { 36, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5228), 36, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5227), 36 },
                    { 37, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5240), 37, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5239), 37 },
                    { 38, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5252), 38, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5251), 38 },
                    { 39, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5263), 39, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5262), 39 },
                    { 40, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5274), 40, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5273), 40 },
                    { 41, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5309), 41, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5308), 41 },
                    { 42, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5322), 42, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5321), 42 },
                    { 43, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5334), 43, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5333), 43 },
                    { 44, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5346), 44, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5345), 44 },
                    { 45, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5357), 45, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5356), 45 },
                    { 46, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5369), 46, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5368), 46 },
                    { 47, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5381), 47, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5379), 47 },
                    { 48, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5392), 48, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5391), 48 },
                    { 49, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5404), 49, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5403), 49 },
                    { 50, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5416), 0, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5414), 50 },
                    { 51, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5427), 1, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5426), 51 },
                    { 52, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5463), 2, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5462), 52 },
                    { 53, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5476), 3, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5474), 53 },
                    { 54, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5488), 4, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5487), 54 },
                    { 55, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5499), 5, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5498), 55 },
                    { 56, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5511), 6, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5510), 56 },
                    { 57, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5523), 7, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5522), 57 },
                    { 58, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5534), 8, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5533), 58 },
                    { 59, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5545), 9, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5544), 59 },
                    { 60, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5556), 10, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5555), 60 },
                    { 61, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5568), 11, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5566), 61 },
                    { 62, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5579), 12, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5578), 62 },
                    { 63, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5613), 13, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5612), 63 },
                    { 64, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5625), 14, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5624), 64 },
                    { 65, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5639), 15, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5638), 65 },
                    { 66, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5651), 16, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5650), 66 },
                    { 67, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5664), 17, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5663), 67 },
                    { 68, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5676), 18, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5674), 68 },
                    { 69, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5687), 19, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5686), 69 },
                    { 70, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5698), 20, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5697), 70 },
                    { 71, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5709), 21, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5708), 71 },
                    { 72, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5742), 22, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5741), 72 },
                    { 73, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5755), 23, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5753), 73 },
                    { 74, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5766), 24, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5765), 74 },
                    { 75, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5777), 25, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5776), 75 },
                    { 76, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5788), 26, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5787), 76 },
                    { 77, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5799), 27, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5798), 77 },
                    { 78, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5810), 28, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5809), 78 },
                    { 79, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5822), 29, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5821), 79 },
                    { 80, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5833), 30, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5831), 80 },
                    { 81, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5844), 31, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5843), 81 },
                    { 82, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5855), 32, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5854), 82 },
                    { 83, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5889), 33, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5888), 83 },
                    { 84, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5900), 34, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5899), 84 },
                    { 85, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5912), 35, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5911), 85 },
                    { 86, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5923), 36, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5922), 86 },
                    { 87, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5934), 37, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5933), 87 },
                    { 88, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5945), 38, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5944), 88 },
                    { 89, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5957), 39, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5956), 89 },
                    { 90, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5968), 40, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5967), 90 },
                    { 91, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5979), 41, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5978), 91 },
                    { 92, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5991), 42, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(5990), 92 },
                    { 93, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6002), 43, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6001), 93 },
                    { 94, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6013), 44, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6012), 94 },
                    { 95, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6047), 45, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6046), 95 },
                    { 96, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6059), 46, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6058), 96 },
                    { 97, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6070), 47, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6069), 97 },
                    { 98, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6082), 48, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6081), 98 },
                    { 99, new DateTime(2023, 7, 4, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6095), 49, new DateTime(2023, 6, 13, 23, 0, 28, 448, DateTimeKind.Local).AddTicks(6094), 99 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100");

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
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

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
                keyValue: "3");

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
                keyValue: "4");

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
                keyValue: "5");

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
                keyValue: "6");

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
                keyValue: "7");

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
                keyValue: "8");

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
                keyValue: "9");

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
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 9);

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
        }
    }
}
