using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorId = table.Column<int>(type: "INTEGER", nullable: false),
                    YearOfRelease = table.Column<int>(type: "INTEGER", nullable: false),
                    LocationId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true),
                    ItemId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    AgeGroup = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemsPerYear = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemsAtSameTime = table.Column<int>(type: "INTEGER", nullable: false),
                    LoanPeriodInDays = table.Column<int>(type: "INTEGER", nullable: false),
                    ExtendsInARow = table.Column<int>(type: "INTEGER", nullable: false),
                    ReservationCost = table.Column<float>(type: "REAL", nullable: false),
                    FinePerItemPerDay = table.Column<float>(type: "REAL", nullable: false),
                    CostPerMonth = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "a5514557-30be-4b88-a981-7c9c026e8d73", "Agnes.Kuhic@yahoo.com", true, false, null, null, null, "40e5e4d6c9661e021368d66a364e953b4890de7d", null, false, "1f922142-071d-49b0-93ca-9d51aad14a83", false, "Agnes.Kuhic@yahoo.com" },
                    { "10", 0, "37863f8e-4546-4f51-bb04-83e4dc8d3580", "Lee74@hotmail.com", true, false, null, null, null, "02667e136046f92ed927f65db6202b5ec7966d34", null, false, "a42c685b-39af-48da-9e02-80a8663727c6", false, "Lee74@hotmail.com" },
                    { "100", 0, "d6668884-ee31-4dc3-b4a2-a899e37e7eaa", "Lionel.Gorczany13@hotmail.com", true, false, null, null, null, "75168d85728764beeaa7ed5f3fd40476a0c65847", null, false, "cdc750aa-196e-471a-864f-38254f9eaa9a", false, "Lionel.Gorczany13@hotmail.com" },
                    { "101", 0, "cedc8f44-4bb6-443d-9a9d-af8b054bbf54", "Jodi.Rempel48@hotmail.com", true, false, null, null, null, "d0dd218376931147fdf681680d645d0f59082c98", null, false, "fdfddc7d-25d7-43b5-a305-f77812ee98f3", false, "Jodi.Rempel48@hotmail.com" },
                    { "102", 0, "72a8a5bd-3804-40cb-958c-ee3b4693ebc7", "Della_Smitham43@gmail.com", true, false, null, null, null, "f48b04d7ab77c989fca5918870d4430e2dee98f0", null, false, "00925c47-bfd7-4f6f-a197-0fc97ad83f2c", false, "Della_Smitham43@gmail.com" },
                    { "103", 0, "9f635e30-0bd8-4f34-a14c-b00f1524a0c1", "Lynne32@gmail.com", true, false, null, null, null, "92c8aacf6c62a6b70c1ff615072276ae2ba6b9fc", null, false, "6a5a55a3-fcf2-4319-b281-cbe4b9705ede", false, "Lynne32@gmail.com" },
                    { "104", 0, "0ddb9058-9e7b-451e-b25f-19838b699f9d", "Mona.Pacocha@hotmail.com", true, false, null, null, null, "0287b96e8639773745dd263ef5e4e857ece6de16", null, false, "9935e530-b4db-4c94-aece-6467df1b69a8", false, "Mona.Pacocha@hotmail.com" },
                    { "105", 0, "bb374bff-ff63-4098-9021-a01d96b97de4", "Douglas_Hilpert31@gmail.com", true, false, null, null, null, "33cbc85a5e2f6f2e54c0839eb57a7de18f10379f", null, false, "71955cf5-0a23-4a66-99d4-19bfb2082541", false, "Douglas_Hilpert31@gmail.com" },
                    { "106", 0, "d69eba51-9220-432d-93d0-24037b5a5aae", "Mike37@gmail.com", true, false, null, null, null, "56f0813b4de90d6ff24685a33b29d0bbd52bc9a3", null, false, "a7db8a87-839f-4914-b1c9-91d64bd6f82d", false, "Mike37@gmail.com" },
                    { "107", 0, "2be92eb0-03bf-4923-a40b-6850d75fd460", "Candice_Kling90@yahoo.com", true, false, null, null, null, "b02c8098b7b4030fd8df3cf78a4666025a5f9983", null, false, "2f6dfba9-9b7d-4d86-8814-0394ed750fca", false, "Candice_Kling90@yahoo.com" },
                    { "108", 0, "43fba690-620a-45b1-a42f-af8424adf51f", "Lee_Crist16@gmail.com", true, false, null, null, null, "767d89b708e01048e28e2e7715a1e2303d53d0ad", null, false, "0fbe2740-b8ab-43b0-8078-948d3469160e", false, "Lee_Crist16@gmail.com" },
                    { "109", 0, "3a53b738-d6bd-4cb8-ac44-1cc1813f8956", "Patsy_Ferry@gmail.com", true, false, null, null, null, "5bff26cbb88f970d83042950dc8f40354217f9bb", null, false, "706bdbaa-f71d-4c9e-887a-c36f810e63a4", false, "Patsy_Ferry@gmail.com" },
                    { "11", 0, "7c1ed10e-8e74-45c3-b9b1-cbc74ebdcfa0", "Kent47@gmail.com", true, false, null, null, null, "bb3517a8ceca3df3d33b8c4642f9fcbc2599579c", null, false, "adabeb95-0aff-4589-8fbe-e280d6d895a4", false, "Kent47@gmail.com" },
                    { "110", 0, "560c7ef7-ccdf-40b6-82d4-3c631e6b8835", "Marc.Leannon85@hotmail.com", true, false, null, null, null, "73a6bd9387893858cead7f8f603c2065e6786ecd", null, false, "067846bc-c43e-469e-895b-596c3fd827e2", false, "Marc.Leannon85@hotmail.com" },
                    { "111", 0, "291f51ca-b3d3-4492-9e9e-1b5ab2d86020", "Lena.Wolf@gmail.com", true, false, null, null, null, "e316f54ca9699c196f6139ed7ebb1327855a8dd0", null, false, "0152932e-e37b-4b9b-bdaf-ffcf63b68981", false, "Lena.Wolf@gmail.com" },
                    { "112", 0, "e6155319-aa08-445f-8383-5285d2a67741", "Alison.Abernathy@yahoo.com", true, false, null, null, null, "ad2f84774cc969bebbf68b69ca942b5674d07566", null, false, "7165ca4e-dc52-46cd-8656-dc00243308fc", false, "Alison.Abernathy@yahoo.com" },
                    { "113", 0, "0d6ebb8c-e579-499a-9809-eb211bf0bc66", "Randall_Grimes@hotmail.com", true, false, null, null, null, "2f722348b2307cb250dd97915317ab39715015ae", null, false, "1906f192-3300-4519-8c23-3e7ba43dac9d", false, "Randall_Grimes@hotmail.com" },
                    { "114", 0, "eac4a907-e147-467d-8958-ec64238a6f16", "Meghan_Harvey@yahoo.com", true, false, null, null, null, "7ec3f95d3c45c9ae5452ce1fab92b6d9c3f09ce7", null, false, "4a560907-331a-4d6b-8d54-aa6c6c3f2e0d", false, "Meghan_Harvey@yahoo.com" },
                    { "115", 0, "f77b6e25-883e-486e-8ebb-14ef00738bcb", "Howard_Marvin@yahoo.com", true, false, null, null, null, "7fbfdeb639ebcd7b0af30103fe704db8c3a50108", null, false, "82e9a673-b56b-41a9-a7f3-46d1dbdebd4a", false, "Howard_Marvin@yahoo.com" },
                    { "116", 0, "9296f9a9-a8af-4eb8-9275-d45a1f3115b3", "Eduardo_Thiel@hotmail.com", true, false, null, null, null, "1aa10bf56afb095eed6b41b0efa3f50446a0186d", null, false, "0a4861e5-e3d3-4f97-892d-c6bb865623e1", false, "Eduardo_Thiel@hotmail.com" },
                    { "117", 0, "3d056b45-2f73-4cbf-b9a2-b2a845396806", "Agnes20@yahoo.com", true, false, null, null, null, "d911c97cb114df06919c67110a9912a3275f8edf", null, false, "818231c9-e91e-4c0c-8e89-fa25b52fa2fc", false, "Agnes20@yahoo.com" },
                    { "118", 0, "aa991692-3ecc-4c3d-b04c-7c2df75b2800", "Esther67@hotmail.com", true, false, null, null, null, "a8f7f67dec2ad239234380955e46ac8011bff16f", null, false, "2c0cc0a1-239d-4ede-b7f9-f455e66cb3a6", false, "Esther67@hotmail.com" },
                    { "119", 0, "141abfc3-33e8-48d2-85d6-89de824655fb", "Charles54@yahoo.com", true, false, null, null, null, "f63a27cabd6bd671128015809c3bc6930c646fc4", null, false, "c9f7aea3-cabe-479e-9cba-fae78c80af52", false, "Charles54@yahoo.com" },
                    { "12", 0, "f35973f8-c40d-4682-bbe1-3689e03dbf72", "Jasmine_VonRueden6@hotmail.com", true, false, null, null, null, "0389eea4b6a3b00c9551fc68b3f429aad3133530", null, false, "74d97115-d33e-436d-99a7-5e4d0c4fa7ee", false, "Jasmine_VonRueden6@hotmail.com" },
                    { "120", 0, "828cf98d-8396-45f7-8dc7-86c9f3192b9d", "Kelly54@gmail.com", true, false, null, null, null, "abec7ea3078b88c9b66dcf8f669b15cf35f95e2e", null, false, "dd4b1daf-d802-46a7-a85f-661b3dc3ac1b", false, "Kelly54@gmail.com" },
                    { "13", 0, "be2b59e9-aa9c-47cc-a84b-8dbe40106c07", "Alfonso33@yahoo.com", true, false, null, null, null, "aad7f76eaa83e0e47c849d3a08e3ae9937d03b28", null, false, "6a0eba9b-0d5a-44a2-90ff-7e93eeeaa9be", false, "Alfonso33@yahoo.com" },
                    { "14", 0, "4b703347-fd6a-4bc6-a2c4-afd85bd02016", "Doyle_Hermiston27@gmail.com", true, false, null, null, null, "2267965c1046527ac25a5fc92376f678e1e93b77", null, false, "90674b92-8a7f-4dcc-8923-12527af2eacb", false, "Doyle_Hermiston27@gmail.com" },
                    { "15", 0, "1e87536c-bf9e-4efd-8516-0bb085395c0d", "Francis.Von@hotmail.com", true, false, null, null, null, "3f7ffda4e0526fbedaec6bc32c8a6cc15b27374c", null, false, "16da874c-79b7-45f3-b058-f695e92d4e58", false, "Francis.Von@hotmail.com" },
                    { "16", 0, "3273faff-070f-4430-8e79-400a39c81848", "Natalie_Schowalter@yahoo.com", true, false, null, null, null, "d50752991325c60271f32f675026115041f55605", null, false, "9dd806a9-4218-4e9f-a0c5-00156e28214f", false, "Natalie_Schowalter@yahoo.com" },
                    { "17", 0, "5d96cebc-9758-45fa-9d2c-502e70f0758f", "Lucille.Cronin85@hotmail.com", true, false, null, null, null, "7a07f96f6222e4a5c5b13a6dd7bfd266ba75c981", null, false, "fcc51def-29fb-4217-9f8d-4feb501a36ec", false, "Lucille.Cronin85@hotmail.com" },
                    { "18", 0, "df785626-7e0c-4597-8ac7-909d78c0e958", "Paul_Heaney17@yahoo.com", true, false, null, null, null, "de71469a2b2a6805edb23b9f28735841bce35ffa", null, false, "bfb2ee45-4e72-4f6c-b5e6-0a598b0180fe", false, "Paul_Heaney17@yahoo.com" },
                    { "19", 0, "221617b8-955b-407d-b4bd-dcde6c69ede7", "Van_Conn25@gmail.com", true, false, null, null, null, "cba6451064292f2b175d5c2eac8eaf77168e409c", null, false, "78e681d1-e6dc-48b3-9379-d79e9645e9d8", false, "Van_Conn25@gmail.com" },
                    { "2", 0, "8505cac6-50bd-4d91-a5b5-f44d18b6cbd1", "Ron.Hickle@yahoo.com", true, false, null, null, null, "722f6c30ec7e3d4beb7536e9042cf7485eecf737", null, false, "70d448d4-c828-4b15-a4e0-1f049e6e521c", false, "Ron.Hickle@yahoo.com" },
                    { "20", 0, "f1cb57af-25fb-4d3b-9d49-21732591720f", "Deanna.Emard38@yahoo.com", true, false, null, null, null, "e29ed33498f4be36a0a140591e2cd25d6746afd6", null, false, "251134b9-83e7-40ee-a969-8beb1befae4e", false, "Deanna.Emard38@yahoo.com" },
                    { "21", 0, "5e72c79a-6afd-49e4-bf3c-c63729795373", "Clay_Roob75@yahoo.com", true, false, null, null, null, "dd4b1d8f312185455ab09c6b785f725a371dc643", null, false, "d9b567b0-faf4-448b-9ad1-739e12ab9cfa", false, "Clay_Roob75@yahoo.com" },
                    { "22", 0, "b44a4cf3-4bdb-4d9a-b4c0-2b9591fdcd7e", "Bernadette_Bednar22@yahoo.com", true, false, null, null, null, "acfadbef766fd0b48d96ae0b20558eeaa4467065", null, false, "ca6e01df-32a8-45c7-8a15-29811ad04460", false, "Bernadette_Bednar22@yahoo.com" },
                    { "23", 0, "9076353a-a453-4a2b-b81c-f3d7395904b0", "Francisco31@gmail.com", true, false, null, null, null, "bebf4d504d69291c39071c6cf6533a92a3289e39", null, false, "b3e74ce0-2f3b-4c6f-bff1-60b9cc3479f4", false, "Francisco31@gmail.com" },
                    { "24", 0, "2d36cf16-37d7-4051-8227-338a1feb144f", "Cary83@gmail.com", true, false, null, null, null, "ec8097ad65c72ad0924012ad719cfc86dba954d6", null, false, "2de5375d-2a2d-4c59-9416-48b3c8d58af0", false, "Cary83@gmail.com" },
                    { "25", 0, "97d0a447-d1f7-4419-b885-403952705332", "Angie.Bergstrom@yahoo.com", true, false, null, null, null, "00bb107b7b5cf51a1d61291f5c05cbbbef2c3d97", null, false, "ec874c54-a3ef-49bb-aa22-515bfdb24267", false, "Angie.Bergstrom@yahoo.com" },
                    { "26", 0, "d55252a5-448e-4a1b-b647-5eb6280a235d", "Flora_Lueilwitz92@hotmail.com", true, false, null, null, null, "3f0900556cfb8b264fff7d2373a947646c796e6d", null, false, "eadc1673-2240-4ec1-819d-c34059d90b52", false, "Flora_Lueilwitz92@hotmail.com" },
                    { "27", 0, "42441219-c302-4751-a31b-0caa82b81dcc", "Curtis.Bahringer62@yahoo.com", true, false, null, null, null, "15f9e9a57f6b0e0220588a976c419d1b46c8b358", null, false, "76c1bee1-699e-470d-8a05-051685b0fc93", false, "Curtis.Bahringer62@yahoo.com" },
                    { "28", 0, "788580b5-cebd-45f5-bc13-444e048c518c", "Francis_Yost@gmail.com", true, false, null, null, null, "286408855b907c01461e374e4f258745999fc8d9", null, false, "7c744ee4-6124-4872-8a50-42638ba71866", false, "Francis_Yost@gmail.com" },
                    { "29", 0, "23c36328-972f-47b4-a24e-6656d53ba72d", "Brittany_Will@hotmail.com", true, false, null, null, null, "8dcaab90657b0791f49ffcc70d1db9010a5e6e29", null, false, "a34c550a-89e8-4914-b7a0-573a09f3260d", false, "Brittany_Will@hotmail.com" },
                    { "3", 0, "4871ae4f-4860-457a-a692-76a1343850d0", "Stacey80@gmail.com", true, false, null, null, null, "befe50822286ea388ef732c90c43ff8538d974bf", null, false, "925bc133-f5be-4cb7-8dd4-91572165b4e3", false, "Stacey80@gmail.com" },
                    { "30", 0, "2dd5569b-f8f1-4de5-84b9-5896661296e0", "Jackie_Senger31@gmail.com", true, false, null, null, null, "dc5880f7d370b2d2c1448e961829de27b51c9163", null, false, "bc8315d0-9582-4024-ba0c-914a97a3d6c3", false, "Jackie_Senger31@gmail.com" },
                    { "31", 0, "70d7c1ea-cd6c-4ba0-8c44-21beb3034a8f", "Regina.Cummerata21@gmail.com", true, false, null, null, null, "5f4034b0b17ea6beb7d4dffaa1c63efac1f68897", null, false, "2a7111ce-5d61-46d9-aac4-d1f151b22cba", false, "Regina.Cummerata21@gmail.com" },
                    { "32", 0, "2c5c502e-7143-4fb6-bf78-6f37c077d701", "Robin59@yahoo.com", true, false, null, null, null, "437e94f19f0d4bd21a8eb554f30ab812df34e8e4", null, false, "6780bd30-9ece-435f-b9b4-d0348f9db353", false, "Robin59@yahoo.com" },
                    { "33", 0, "b75e9a46-c37c-4a46-b1d5-b3edcaef5818", "Rafael97@gmail.com", true, false, null, null, null, "43c2fd819e4c92775af262fbdcc8f9b25025e4aa", null, false, "cab92a3e-c7b1-44be-b499-23fd030a7b0a", false, "Rafael97@gmail.com" },
                    { "34", 0, "c32df7d7-9ed4-40e8-82ee-334f481cbbe3", "Raquel.Christiansen81@hotmail.com", true, false, null, null, null, "0d7a83878344e0c62dc38fe9f9e799d538547ed3", null, false, "b2c93828-426c-4ace-a7a2-c01528922786", false, "Raquel.Christiansen81@hotmail.com" },
                    { "35", 0, "5d6b8d51-5ee3-435c-9544-927abb48ce08", "Joyce41@yahoo.com", true, false, null, null, null, "d8b35e3b74baf3211b6c7bcbc0212adbc369fb03", null, false, "3043b839-c10a-4db1-bc8b-95a68074541a", false, "Joyce41@yahoo.com" },
                    { "36", 0, "1cfb562c-13a3-404f-87a2-2cfbd885516a", "Elias74@gmail.com", true, false, null, null, null, "cbdaab55a102e1e9ef78786b0b67c142374e20af", null, false, "96ca80df-15bf-49aa-bd60-a18e6a60b027", false, "Elias74@gmail.com" },
                    { "37", 0, "2b039f6b-f1a1-44eb-ba0f-33ab3da3cf71", "Mathew_Purdy94@gmail.com", true, false, null, null, null, "2e163849e43a9f16651fdadad8dca13bad9db7a1", null, false, "b83be362-70e8-4b54-a4c4-353d96d7805f", false, "Mathew_Purdy94@gmail.com" },
                    { "38", 0, "7a06c8d4-d3db-4b2d-bc7c-751d5c2ded82", "Marsha.Wilderman@gmail.com", true, false, null, null, null, "4ca6670d60782c9c0a7b6e2f6b4903ea55db1420", null, false, "53a13d1f-c568-462e-b2b1-04cf30c4f44e", false, "Marsha.Wilderman@gmail.com" },
                    { "39", 0, "4052632a-cbc5-4dc9-9b8c-4f000a032cdb", "Stella_Hudson29@yahoo.com", true, false, null, null, null, "16796685f1a4e5fa45afe9d3a47d6f1574c2873f", null, false, "55511f5f-2fd0-4b57-80bf-566efe239276", false, "Stella_Hudson29@yahoo.com" },
                    { "4", 0, "3c7dd053-18c4-4083-a475-83e52a51bbfe", "Daisy.Smitham24@yahoo.com", true, false, null, null, null, "9623abd1fee1b5083e6804527bafb388cc7202e4", null, false, "560de276-fe08-48be-b486-6a00a129e628", false, "Daisy.Smitham24@yahoo.com" },
                    { "40", 0, "6725e945-bff4-4e0e-a52c-e6ffa8faa05f", "Russell_Brown@gmail.com", true, false, null, null, null, "6561e5534e510c51f13d2a87ce26a1643d91adac", null, false, "dc55f7f2-b17e-43d0-875e-aea66da245e5", false, "Russell_Brown@gmail.com" },
                    { "41", 0, "9aa4bba3-4b67-44e0-bc83-1429349cce07", "Lucy6@gmail.com", true, false, null, null, null, "d16be10c867fac7736fb2452337134002d80edca", null, false, "cdcd3b2e-6b53-4228-b3e7-947bb0e7e62a", false, "Lucy6@gmail.com" },
                    { "42", 0, "9dc85c6d-4437-4aaf-a11e-661efbb6f911", "Eula.Kris53@hotmail.com", true, false, null, null, null, "c6b0c7bb98f9962bdb547add06e957e2f2b074cc", null, false, "e5e7f436-6709-4f0f-b21e-e992cf81d7fc", false, "Eula.Kris53@hotmail.com" },
                    { "43", 0, "ab5b9375-7d53-4a22-b768-9fef2a14d3e5", "Paul.Kozey@gmail.com", true, false, null, null, null, "7899677370203df8950959c0bb8f71dfd1aae5c8", null, false, "5da57390-c3bb-4752-b107-405a5017f5a4", false, "Paul.Kozey@gmail.com" },
                    { "44", 0, "b06f2298-4ccc-45d1-bad2-f1c7198abc5f", "Lora68@hotmail.com", true, false, null, null, null, "1b4e501ee4d6be93d22f2026d266422003927f95", null, false, "51ceaa1a-82aa-48cd-956b-4a7e17261058", false, "Lora68@hotmail.com" },
                    { "45", 0, "a4e52cfd-8c1f-4941-a4b1-51bb903b3331", "Beatrice_Lockman51@hotmail.com", true, false, null, null, null, "de567821585f9ffdbd608dffd74956a964dd2fa1", null, false, "18224dd1-a1c1-4fe6-9d44-ad912908011b", false, "Beatrice_Lockman51@hotmail.com" },
                    { "46", 0, "efb3c174-343f-49a8-a447-bccec0e40436", "Jonathon_Robel@yahoo.com", true, false, null, null, null, "cac0e23d465604b68faa7c13d35b3ba71d95e466", null, false, "5ef7ad0d-e968-4ff7-a254-5f5a58c7ea4f", false, "Jonathon_Robel@yahoo.com" },
                    { "47", 0, "5a8445ab-6e2e-44f2-9b01-540c224cebf4", "Tony_Rogahn@gmail.com", true, false, null, null, null, "55a52d9cff6468463fb0e88a1e3c4e3b6b06c8b9", null, false, "46a7cbc8-2c44-4f23-a9d2-ddcb1b1c776c", false, "Tony_Rogahn@gmail.com" },
                    { "48", 0, "7521c1da-5a34-4162-8a60-9c6ea45ac684", "Santos71@yahoo.com", true, false, null, null, null, "effa396b0e0c44184861c8dabd186be7f1e16823", null, false, "e44983d5-811e-4ec5-888f-b4050b5599cb", false, "Santos71@yahoo.com" },
                    { "49", 0, "b4ac8726-7e4b-4e20-bca7-63f86d444866", "Tiffany83@yahoo.com", true, false, null, null, null, "6c0f3877711c44be6364d173e699e4334dc9b6b3", null, false, "63b5a05d-e4c6-4782-9487-c322e7bc2f90", false, "Tiffany83@yahoo.com" },
                    { "5", 0, "21839adb-4d2e-465c-9f07-4ab84ce9c150", "Amelia_OConner89@yahoo.com", true, false, null, null, null, "c429db2173ef00898951f97edac37c378b847de2", null, false, "b3ca905d-7746-42be-ad74-dbf260ced830", false, "Amelia_OConner89@yahoo.com" },
                    { "50", 0, "8013fa8b-737c-4833-a691-bc9d14a984d3", "Monica16@gmail.com", true, false, null, null, null, "90434aee56feacf040910bcfd704b382ecf478e9", null, false, "8827e50c-52b8-45ea-bfa6-33078fc00947", false, "Monica16@gmail.com" },
                    { "51", 0, "5b2815ba-5de3-4a11-aa45-2c2ea26e64ad", "Christopher_Durgan@gmail.com", true, false, null, null, null, "57f09b22ce44fe9ee11f64680e286f9d4d20e96b", null, false, "e9924d70-066b-467b-b501-739791a6e1da", false, "Christopher_Durgan@gmail.com" },
                    { "52", 0, "90ff1e32-d165-4706-93cc-fafa003a1a3c", "Myra.Lang@hotmail.com", true, false, null, null, null, "4de9cb9afbf679f824865b29f0a060836dd9dd3c", null, false, "8c09abc2-6d64-4af4-a28c-b07588d159aa", false, "Myra.Lang@hotmail.com" },
                    { "53", 0, "4d4536a2-0b14-479b-a454-6b98cf3681a0", "Herman.Larkin57@gmail.com", true, false, null, null, null, "31508492d48d6e1327ab61ecf6a9048fea1d8f26", null, false, "1193ee4d-e28f-4176-81ab-d66e6eb5dd9c", false, "Herman.Larkin57@gmail.com" },
                    { "54", 0, "bf23bb96-273d-437c-a92a-612824100f0d", "Alice_Hodkiewicz@hotmail.com", true, false, null, null, null, "5ba002f4da0bd68e78a997d7360fe15827c73470", null, false, "e0280d74-9834-46eb-b191-a35eca67aa65", false, "Alice_Hodkiewicz@hotmail.com" },
                    { "55", 0, "4a0a143d-90b9-4ca1-b686-5a9c3a063e87", "Orlando_Toy@yahoo.com", true, false, null, null, null, "7b7a0661514fa5116601b40effb645ca7f6eb7ce", null, false, "f415afd9-04fb-4b6c-bc92-87eaf52dd482", false, "Orlando_Toy@yahoo.com" },
                    { "56", 0, "c37c5916-75a3-4b5f-bdfd-ae1faef66832", "Hector93@yahoo.com", true, false, null, null, null, "3f4cd36848083ebc0137b64bf662de8c8d24814a", null, false, "26d355bc-a337-425b-9377-66022380bb83", false, "Hector93@yahoo.com" },
                    { "57", 0, "7dc4642d-269f-4665-9949-ddb6ef037a02", "Betsy.Swaniawski65@gmail.com", true, false, null, null, null, "ecb2ecf1a5145869df96e5fcafc59dcf8701bed1", null, false, "78f412e6-ffbc-4748-a912-822197bb5a17", false, "Betsy.Swaniawski65@gmail.com" },
                    { "58", 0, "d50b1c7e-8524-4582-9125-884afdc267d1", "Vicki6@hotmail.com", true, false, null, null, null, "a3bb2c496bb6a713e5fc89ba73ab49ef774768a9", null, false, "0f3f69ac-c472-49d0-a358-52f67f0ab4f3", false, "Vicki6@hotmail.com" },
                    { "59", 0, "bd56c83c-53a8-4e0d-b746-93cab0b5df1f", "Mack92@yahoo.com", true, false, null, null, null, "1104157d48e6d048605d4f8014dc261f5a3ac50c", null, false, "9d88e876-babc-43b6-9a0c-d79ff817365f", false, "Mack92@yahoo.com" },
                    { "6", 0, "f19ed12e-cc48-4c68-b8be-c8ff4492e50a", "Tammy_Hoeger36@yahoo.com", true, false, null, null, null, "04f983243d067b0289bfffc12f89a864c565f9e0", null, false, "b9c2ab8f-e175-4167-bd8e-a893a089dbf5", false, "Tammy_Hoeger36@yahoo.com" },
                    { "60", 0, "9720924b-f209-4137-bb73-155043ef9c49", "Caroline38@yahoo.com", true, false, null, null, null, "d06d4282bb8ff806cfaec008808cd1cc3e5ffadc", null, false, "1d974cd9-9bd8-4e11-8208-a20dbb26395e", false, "Caroline38@yahoo.com" },
                    { "61", 0, "7c2c5262-1ce0-4713-977c-399c06b48067", "Jessie12@hotmail.com", true, false, null, null, null, "eef3eb7a7f5accc0260c0432e021155ef7bafdbe", null, false, "ce2f116c-a49c-4f0c-96b7-caca11aa2131", false, "Jessie12@hotmail.com" },
                    { "62", 0, "6209bc6e-0be8-40b3-b4e2-b718509631da", "Nicole52@hotmail.com", true, false, null, null, null, "5fea3e833a23a51e476893f4681beed62d6bbac3", null, false, "f173980c-2ab8-43c5-941b-b7e4491d3ab9", false, "Nicole52@hotmail.com" },
                    { "63", 0, "3fe6d24a-0bd4-434d-bee3-c9e341e28af1", "Darnell.Rowe41@yahoo.com", true, false, null, null, null, "93b2bb5e9ecd2050fbe0e7ccd6e4d704777bf600", null, false, "33337262-87ab-4006-a965-111d441d4874", false, "Darnell.Rowe41@yahoo.com" },
                    { "64", 0, "63e1d40c-d0fb-4337-9f0a-1e730f9e63f9", "Courtney.Grimes55@yahoo.com", true, false, null, null, null, "02c5fd5818a36058cb5e10c36a56e32318a89ea6", null, false, "e577e7ae-65dc-425a-aea3-0c25a3f8b0b5", false, "Courtney.Grimes55@yahoo.com" },
                    { "65", 0, "dd3bbc25-6b7e-4e5b-8a8f-821fef63d6ce", "Emanuel_Raynor10@yahoo.com", true, false, null, null, null, "04d85ba383b0574e31d181a1625a23e7da64e59d", null, false, "55f47abb-5815-435f-8be0-364d494612b5", false, "Emanuel_Raynor10@yahoo.com" },
                    { "66", 0, "ed8f343c-1b3e-479a-8289-6928e6303f45", "Lucas.Reichert@yahoo.com", true, false, null, null, null, "f829534efa68e911aca1e1f796642a5009cfe054", null, false, "68488eae-26f3-4bc5-803d-93bb28311997", false, "Lucas.Reichert@yahoo.com" },
                    { "67", 0, "9c86c495-cf83-434c-a177-176ab79e6ade", "Enrique.McCullough54@gmail.com", true, false, null, null, null, "3f45fc9bfe0f2486992efc0cc885e79d082c3707", null, false, "d8393747-25c3-4905-92c4-550e8c05d053", false, "Enrique.McCullough54@gmail.com" },
                    { "68", 0, "2bd40143-d1f8-417e-b08a-268397e56f83", "Freda22@yahoo.com", true, false, null, null, null, "8920c64190ff5f7c90ba3a2047ea8d9713b12b54", null, false, "574fc8fd-0d6d-496b-a176-9bcefd8b7e18", false, "Freda22@yahoo.com" },
                    { "69", 0, "9d406597-254f-4d13-b929-d427cf9de982", "Shane_Heaney33@yahoo.com", true, false, null, null, null, "8258e21287e4c2a1a4c20a7ee5cf730b488abd84", null, false, "5550be9f-7494-446c-8d1a-3733efc60d9e", false, "Shane_Heaney33@yahoo.com" },
                    { "7", 0, "1efe3a34-539f-4e47-99ec-ca51f4529a19", "Terri8@yahoo.com", true, false, null, null, null, "0667b87dcb6338705f21da2cc97fc55a6e374895", null, false, "5f5ddaaa-616b-4444-a8e2-03e7620db3b7", false, "Terri8@yahoo.com" },
                    { "70", 0, "4b284149-b810-4aae-ab86-ba44c407a6fc", "Beatrice19@yahoo.com", true, false, null, null, null, "62610b3fa08d7c94c931dcaccee9452681a7c628", null, false, "3e8cb99e-bda3-4534-8897-c8c48a1da75d", false, "Beatrice19@yahoo.com" },
                    { "71", 0, "3ec8c129-252b-4f82-9dcb-8eacbb8474e4", "Eric11@yahoo.com", true, false, null, null, null, "975e029fd76ce7041aefdd4347aa5ad8587cb21c", null, false, "3ec05524-84b4-4bba-a96e-315d5ebf55dd", false, "Eric11@yahoo.com" },
                    { "72", 0, "114edc90-a4ef-4ed3-a1f2-fd8f88c9b7dc", "Jeremiah_Lubowitz41@hotmail.com", true, false, null, null, null, "5df510740a71b6d4be98436f7db25dd3a95e7c1d", null, false, "63b5bc7c-cc82-4742-bfe9-486e9df56191", false, "Jeremiah_Lubowitz41@hotmail.com" },
                    { "73", 0, "5916cb85-0f3c-4363-b07b-793ea6ebf93b", "Lowell.Smith@hotmail.com", true, false, null, null, null, "133d9d8d6d5a30f426f916b68a1fcf0b162fa755", null, false, "e2abf49a-f5c6-4d0d-b60f-96a2aea552da", false, "Lowell.Smith@hotmail.com" },
                    { "74", 0, "0b07f0f7-0ae1-41de-b5c9-00841981ab89", "Robin.Nitzsche41@gmail.com", true, false, null, null, null, "988bf42849e71a82ba59f51a39f7a67a2c5f29f7", null, false, "22df04fc-2361-43d7-b2c7-06ae98c0112b", false, "Robin.Nitzsche41@gmail.com" },
                    { "75", 0, "5dc1db1d-3009-4737-adb2-73d4d4012720", "Gilbert6@gmail.com", true, false, null, null, null, "949586d516f9a59ae0c3df64a1a4b36c4307243b", null, false, "e5cc3327-8f1b-4399-a3b8-35a6b878b6cc", false, "Gilbert6@gmail.com" },
                    { "76", 0, "f38bb641-fe84-4940-bbda-30e2bfcb4295", "Sarah_Daniel@hotmail.com", true, false, null, null, null, "0e0a1521ccb6cfbab53bffda44cebdcfb0cc575a", null, false, "145c92b3-dd35-4305-a0c9-b10aa6b3493a", false, "Sarah_Daniel@hotmail.com" },
                    { "77", 0, "a608ec65-aad1-4f12-bb6e-53b5332bd68b", "Steve14@yahoo.com", true, false, null, null, null, "9fbf3cd68689c134a36435d3073b3312eae9f80b", null, false, "e0de1e9b-fcf4-409e-bc53-9df56c0da1a2", false, "Steve14@yahoo.com" },
                    { "78", 0, "af2ed226-5370-4c3f-9c1c-7399b256f475", "Ada.Blanda@gmail.com", true, false, null, null, null, "0b78a2dcae24a525cf3264ecea6a0225b502c854", null, false, "ca41ce99-57a1-4b79-af6b-368b4bb0e193", false, "Ada.Blanda@gmail.com" },
                    { "79", 0, "ae4b6d2e-f872-4d09-bd5c-14894d30993d", "Leah67@yahoo.com", true, false, null, null, null, "d4c8db1a03c87346d67da359a76ef20582fde27e", null, false, "9e44bc5a-1541-4907-b9e2-fcde17199570", false, "Leah67@yahoo.com" },
                    { "8", 0, "9e294167-1167-483c-bcaa-67e389fdd14f", "Crystal_Denesik69@hotmail.com", true, false, null, null, null, "f6203d197cafc0c41d98f6adc50c969ed6f2e047", null, false, "9fb856b2-0259-4d2d-94e3-1bde7a52d0ef", false, "Crystal_Denesik69@hotmail.com" },
                    { "80", 0, "918a1eb9-7184-4111-9365-af6be6b8e9d0", "Emmett90@yahoo.com", true, false, null, null, null, "a5dc0076c725440313c4aac582a848f8aa14b9b6", null, false, "5be6f8a6-8a23-4ada-8c0d-0eb058a0c81f", false, "Emmett90@yahoo.com" },
                    { "81", 0, "391fc0bc-27cc-4eab-a7f2-84d8073837b8", "Rosa73@hotmail.com", true, false, null, null, null, "60cb76fe0666d97c4ce9a4a92e8223429aa1a7ad", null, false, "9b432351-c06f-4541-9253-558db4ce5c7b", false, "Rosa73@hotmail.com" },
                    { "82", 0, "a8d29da4-49da-4066-b837-9766e67610e5", "Gilberto97@gmail.com", true, false, null, null, null, "f4aa4d212b06ce8ac4ad6716dd4dcffe10006f32", null, false, "cfeba04e-ec16-475b-b555-68f19021a27c", false, "Gilberto97@gmail.com" },
                    { "83", 0, "523eaeef-fc75-4460-a566-2b7dfb44a7a8", "Clark_Torphy@hotmail.com", true, false, null, null, null, "fea4c425a1ee10d661c46f7755d8876ecbc43d85", null, false, "eb16c461-9e5b-43f4-8de0-bff752b35f03", false, "Clark_Torphy@hotmail.com" },
                    { "84", 0, "845c1d40-a576-4fb7-8061-ec00f121f80e", "Justin29@yahoo.com", true, false, null, null, null, "9aebe95245da91f65bc33e90af6a2a64ede4d8e4", null, false, "2d3f39f4-d01f-4a4f-affa-31ec7b7f66ac", false, "Justin29@yahoo.com" },
                    { "85", 0, "bf343d10-c8d8-4770-b7ec-e60054e56398", "Bruce8@gmail.com", true, false, null, null, null, "5d9748d9fd761cdfa8224cd3b02cd8033940b34b", null, false, "f5426613-20f5-4c4d-b648-e8111b363f0c", false, "Bruce8@gmail.com" },
                    { "86", 0, "5a8be769-4836-46f9-a51c-14e4383c27cd", "Gwendolyn_Schaden7@gmail.com", true, false, null, null, null, "25f308781e1f1947c2431a1220f1b38a32f751a3", null, false, "a8f6e8ae-44bb-48e4-ac35-8f19d174a649", false, "Gwendolyn_Schaden7@gmail.com" },
                    { "87", 0, "55fd3479-e72d-4394-9264-f2c80dc49b80", "Jimmie.Wisoky68@yahoo.com", true, false, null, null, null, "f399b978804e623d4209e300d9d9d1a319647317", null, false, "6c550911-601a-4ee8-a373-f5561971aea1", false, "Jimmie.Wisoky68@yahoo.com" },
                    { "88", 0, "108ab7cc-962c-47d7-90c9-b08dec848090", "Cheryl_Daugherty@yahoo.com", true, false, null, null, null, "ebc773e90e8c3caaaceeaebe6b6705b3f44086f4", null, false, "a488b128-1734-4272-a696-e430596fd6c0", false, "Cheryl_Daugherty@yahoo.com" },
                    { "89", 0, "776bb00c-e235-4a64-b81f-4fdfc676cb55", "Natasha.Simonis@gmail.com", true, false, null, null, null, "30d9a95f3245e3e8b558b521fbfc927a1e7281c7", null, false, "9be83da6-7853-4483-8f0a-aa602bcfc2c3", false, "Natasha.Simonis@gmail.com" },
                    { "9", 0, "6d4bc521-6ab4-4148-a9ed-3a8d4bfdb633", "William.Homenick@yahoo.com", true, false, null, null, null, "c90b7eebbfe46bf6acbe61f4a9a6b00ab5216cad", null, false, "649c0ebc-dedd-462c-a352-3c675b99a9b7", false, "William.Homenick@yahoo.com" },
                    { "90", 0, "7a716d46-d992-48eb-bb8f-74b58c770f22", "Noah.Mueller@hotmail.com", true, false, null, null, null, "afbc9759b09e499d525c2194d8e63545467a2c33", null, false, "4efe5883-92b5-494d-b522-48847788636a", false, "Noah.Mueller@hotmail.com" },
                    { "91", 0, "d44a668b-58b5-4394-a5bb-12389ccff426", "Carolyn_Green@gmail.com", true, false, null, null, null, "eca1f4645e3ee9238f38e7638adbdd7141396f80", null, false, "19135525-4312-41ad-9ae5-4db550a26175", false, "Carolyn_Green@gmail.com" },
                    { "92", 0, "4659bf21-7630-4dea-ae6c-ce917316314a", "Edmond.Beahan19@yahoo.com", true, false, null, null, null, "a867cbe84ece2aa4ac0fed43b227755b6febb7b9", null, false, "220fd4f7-ce7c-4631-ab50-f71a0d92fc0e", false, "Edmond.Beahan19@yahoo.com" },
                    { "93", 0, "e3a28e8c-7e50-4e73-9f95-13180ac4bafe", "Wallace56@gmail.com", true, false, null, null, null, "64917f1fd9a9db17e5b84c0e2ea8efbf67775cf0", null, false, "952532d4-6714-4170-a2cf-2547d6ed0151", false, "Wallace56@gmail.com" },
                    { "94", 0, "bd195088-7a31-434b-bccc-5a5a8de20d0d", "Matt90@gmail.com", true, false, null, null, null, "c691938f168841fa5761a07abed7aecc0b7b1345", null, false, "d6b66748-2c89-4cbc-95b6-f2016752473e", false, "Matt90@gmail.com" },
                    { "95", 0, "e3bbe787-2e09-45ff-b4e9-9aff17c20b6a", "Angelo.Conroy@hotmail.com", true, false, null, null, null, "908edbcf9fd46de1b0ae405473cfb7110d49ae19", null, false, "c6c322d4-6470-4eb5-b796-e518bfd5a3da", false, "Angelo.Conroy@hotmail.com" },
                    { "96", 0, "861c5f90-26ca-4626-a9d2-2f8278dacc0c", "Ron.Kunze@gmail.com", true, false, null, null, null, "725ebcd99f44eb33b34d82e4bb982eefd81909e5", null, false, "66c4f412-018e-484c-8a92-8c8a8802c6c6", false, "Ron.Kunze@gmail.com" },
                    { "97", 0, "518008ba-ed81-4e5f-a99a-1f2ec7d36185", "Judith_Grady@yahoo.com", true, false, null, null, null, "09eab7b4fa8af7eefc2beccaabee7c3439967cfe", null, false, "c3397921-62dd-464f-9f71-6769595dc5b7", false, "Judith_Grady@yahoo.com" },
                    { "98", 0, "9320b5d6-bff3-4749-a5ec-e84457225315", "Gary_Zboncak36@yahoo.com", true, false, null, null, null, "1046328c7063a8ce0e3952fff994aec66b77da70", null, false, "32cb8572-0a09-4621-8628-aa502a9ae718", false, "Gary_Zboncak36@yahoo.com" },
                    { "99", 0, "47cb2df3-9d5a-4803-b55f-dece00e7307d", "Jim_McDermott81@gmail.com", true, false, null, null, null, "186ef81d065f6998c7d0e4453d046da16843dc97", null, false, "9279b673-9833-4a12-b55c-f2348a3b827a", false, "Jim_McDermott81@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 50, "Monica Rippin" },
                    { 2, 50, "Melba Gerhold" },
                    { 3, 50, "Myrtle Hudson" },
                    { 4, 50, "Douglas MacGyver" },
                    { 5, 50, "Brittany Barrows" },
                    { 6, 50, "Willie Gibson" },
                    { 7, 50, "Irvin Huels" },
                    { 8, 50, "Shelley Kuphal" },
                    { 9, 50, "Loretta Kozey" },
                    { 10, 50, "Krystal DuBuque" },
                    { 11, 50, "Darrell Schuppe" },
                    { 12, 50, "Joann Buckridge" },
                    { 13, 50, "Winston Rosenbaum" },
                    { 14, 50, "Elisa Schaden" },
                    { 15, 50, "Kristy Cremin" },
                    { 16, 50, "Nadine Crona" },
                    { 17, 50, "Madeline O'Keefe" },
                    { 18, 50, "Terrell Denesik" },
                    { 19, 50, "Kent Pollich" },
                    { 20, 50, "Lorraine Ernser" },
                    { 21, 50, "Lynn Haley" },
                    { 22, 50, "Eloise Spinka" },
                    { 23, 50, "Lila McCullough" },
                    { 24, 50, "Kelli Waelchi" },
                    { 25, 50, "Mildred Gulgowski" },
                    { 26, 50, "Roderick Berge" },
                    { 27, 50, "Olive Graham" },
                    { 28, 50, "Wilma Block" },
                    { 29, 50, "Edna Bradtke" },
                    { 30, 50, "Johnny Gorczany" },
                    { 31, 50, "Anne Pacocha" },
                    { 32, 50, "Lynette Lind" },
                    { 33, 50, "Debbie Pouros" },
                    { 34, 50, "Dana Hettinger" },
                    { 35, 50, "Christina Greenfelder" },
                    { 36, 50, "Jeffery Graham" },
                    { 37, 50, "Amelia Durgan" },
                    { 38, 50, "Pam Langworth" },
                    { 39, 50, "Devin Carroll" },
                    { 40, 50, "Beulah Schmitt" },
                    { 41, 50, "Amy Mann" },
                    { 42, 50, "Sonia King" },
                    { 43, 50, "Charlie Mertz" },
                    { 44, 50, "Santos Labadie" },
                    { 45, 50, "Casey Schuppe" },
                    { 46, 50, "Nina Reilly" },
                    { 47, 50, "April Boyer" },
                    { 48, 50, "Ellen Cormier" },
                    { 49, 50, "Misty Franecki" },
                    { 50, 50, "Sean Klocko" },
                    { 51, 50, "Lee Kertzmann" },
                    { 52, 50, "Karla Stroman" },
                    { 53, 50, "Sylvester Cummerata" },
                    { 54, 50, "Lloyd Witting" },
                    { 55, 50, "Miguel White" },
                    { 56, 50, "Troy Gorczany" },
                    { 57, 50, "Casey Romaguera" },
                    { 58, 50, "Deborah Denesik" },
                    { 59, 50, "Jesus O'Keefe" },
                    { 60, 50, "Teresa Hermann" },
                    { 61, 50, "Robin Orn" },
                    { 62, 50, "Elias Roberts" },
                    { 63, 50, "Ruby Nolan" },
                    { 64, 50, "Chad Goldner" },
                    { 65, 50, "Becky Konopelski" },
                    { 66, 50, "Steven Anderson" },
                    { 67, 50, "Forrest Lindgren" },
                    { 68, 50, "Becky Wolf" },
                    { 69, 50, "Freddie Armstrong" },
                    { 70, 50, "Kristie Casper" },
                    { 71, 50, "Margaret Hamill" },
                    { 72, 50, "Beulah McClure" },
                    { 73, 50, "Grady Leuschke" },
                    { 74, 50, "Melvin Hartmann" },
                    { 75, 50, "Cecelia Kuhic" },
                    { 76, 50, "Erma Cremin" },
                    { 77, 50, "Lela Runolfsson" },
                    { 78, 50, "Alex Waelchi" },
                    { 79, 50, "Johanna Hammes" },
                    { 80, 50, "Spencer Cole" },
                    { 81, 50, "Maggie Gleichner" },
                    { 82, 50, "Johnnie Koepp" },
                    { 83, 50, "Rafael Kuhn" },
                    { 84, 50, "Lynette Kertzmann" },
                    { 85, 50, "Dustin Ferry" },
                    { 86, 50, "Robert Will" },
                    { 87, 50, "Gina Fritsch" },
                    { 88, 50, "Joanna Aufderhar" },
                    { 89, 50, "Irene Trantow" },
                    { 90, 50, "Deborah Daniel" },
                    { 91, 50, "Ramon Ernser" },
                    { 92, 50, "Albert Haag" },
                    { 93, 50, "Vicky Hodkiewicz" },
                    { 94, 50, "Jennie Thompson" },
                    { 95, 50, "Sylvester Hilpert" },
                    { 96, 50, "Courtney Hettinger" },
                    { 97, 50, "Randal Moen" },
                    { 98, 50, "Pedro Gutkowski" },
                    { 99, 50, "Estelle Pagac" },
                    { 100, 50, "Kelvin Bogisich" },
                    { 101, 50, "Sherri Hahn" },
                    { 102, 50, "Blanche Harber" },
                    { 103, 50, "Angelina Bednar" },
                    { 104, 50, "Agnes Hand" },
                    { 105, 50, "Rufus Larson" },
                    { 106, 50, "Russell Kemmer" },
                    { 107, 50, "Jamie Ziemann" },
                    { 108, 50, "Vernon Mraz" },
                    { 109, 50, "Ernest Mills" },
                    { 110, 50, "Marcella Ortiz" },
                    { 111, 50, "Fernando Tromp" },
                    { 112, 50, "Rolando Bosco" },
                    { 113, 50, "Leo Borer" },
                    { 114, 50, "Donna Sauer" },
                    { 115, 50, "Gertrude Auer" },
                    { 116, 50, "Kenny Bogan" },
                    { 117, 50, "Maurice Thompson" },
                    { 118, 50, "Eleanor Will" },
                    { 119, 50, "Irvin Schultz" },
                    { 120, 50, "Crystal Feest" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "LocationId", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 1, 1, "Harry Potter: 1", 1998 },
                    { 2, 2, 2, "Harry Potter: 2", 1999 },
                    { 3, 3, 3, "Harry Potter: 3", 2000 },
                    { 4, 4, 4, "Harry Potter: 4", 2001 },
                    { 5, 5, 5, "Harry Potter: 5", 2002 },
                    { 6, 6, 6, "Harry Potter: 6", 2003 },
                    { 7, 7, 7, "Harry Potter: 7", 2004 },
                    { 8, 8, 8, "Harry Potter: 8", 2005 },
                    { 9, 9, 9, "Harry Potter: 9", 2006 },
                    { 10, 10, 10, "Harry Potter: 10", 2007 },
                    { 11, 11, 11, "Harry Potter: 11", 2008 },
                    { 12, 12, 12, "Harry Potter: 12", 2009 },
                    { 13, 13, 13, "Harry Potter: 13", 2010 },
                    { 14, 14, 14, "Harry Potter: 14", 2011 },
                    { 15, 15, 15, "Harry Potter: 15", 2012 },
                    { 16, 16, 16, "Harry Potter: 16", 2013 },
                    { 17, 17, 17, "Harry Potter: 17", 2014 },
                    { 18, 18, 18, "Harry Potter: 18", 2015 },
                    { 19, 19, 19, "Harry Potter: 19", 2016 },
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

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "EndDate", "ItemId", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7406), 1, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7300), "1" },
                    { 2, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7519), 2, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7516), "2" },
                    { 3, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7584), 3, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7581), "3" },
                    { 4, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7852), 4, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7848), "4" },
                    { 5, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7929), 5, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(7926), "5" },
                    { 6, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8065), 6, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8061), "6" },
                    { 7, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8137), 7, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8133), "7" },
                    { 8, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8200), 8, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8196), "8" },
                    { 9, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8263), 9, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8259), "9" },
                    { 10, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8329), 10, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8326), "0" },
                    { 11, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8388), 11, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8384), "1" },
                    { 12, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8445), 12, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8442), "2" },
                    { 13, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8566), 13, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8562), "3" },
                    { 14, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8628), 14, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8624), "4" },
                    { 15, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8686), 15, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8683), "5" },
                    { 16, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8745), 16, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8741), "6" },
                    { 17, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8805), 17, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8802), "7" },
                    { 18, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8872), 18, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8868), "8" },
                    { 19, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8994), 19, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(8991), "9" },
                    { 20, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9053), 20, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9050), "0" },
                    { 21, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9111), 21, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9107), "1" },
                    { 22, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9169), 22, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9165), "2" },
                    { 23, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9225), 23, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9221), "3" },
                    { 24, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9283), 24, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9280), "4" },
                    { 25, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9415), 25, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9412), "5" },
                    { 26, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9478), 26, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9475), "6" },
                    { 27, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9534), 27, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9531), "7" },
                    { 28, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9595), 28, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9592), "8" },
                    { 29, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9652), 29, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9649), "9" },
                    { 30, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9712), 30, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9709), "0" },
                    { 31, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9766), 31, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9763), "1" },
                    { 32, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9894), 32, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9890), "2" },
                    { 33, new DateTime(2025, 2, 4, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9958), 33, new DateTime(2025, 1, 14, 21, 8, 33, 510, DateTimeKind.Local).AddTicks(9953), "3" },
                    { 34, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(21), 34, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(18), "4" },
                    { 35, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(79), 35, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(76), "5" },
                    { 36, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(134), 36, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(131), "6" },
                    { 37, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(277), 37, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(273), "7" },
                    { 38, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(337), 38, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(334), "8" },
                    { 39, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(392), 39, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(388), "9" },
                    { 40, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(447), 40, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(443), "0" },
                    { 41, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(503), 41, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(499), "1" },
                    { 42, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(556), 42, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(552), "2" },
                    { 43, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(609), 43, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(606), "3" },
                    { 44, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(722), 44, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(718), "4" },
                    { 45, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(783), 45, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(779), "5" },
                    { 46, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(842), 46, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(838), "6" },
                    { 47, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(898), 47, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(895), "7" },
                    { 48, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(954), 48, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(951), "8" },
                    { 49, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1011), 49, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1007), "9" },
                    { 50, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1065), 50, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1062), "0" },
                    { 51, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1178), 51, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1174), "1" },
                    { 52, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1233), 52, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1230), "2" },
                    { 53, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1287), 53, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1283), "3" },
                    { 54, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1344), 54, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1341), "4" },
                    { 55, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1399), 55, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1395), "5" },
                    { 56, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1536), 56, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1533), "6" },
                    { 57, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1654), 57, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1649), "7" },
                    { 58, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1711), 58, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1708), "8" },
                    { 59, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1766), 59, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1763), "9" },
                    { 60, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1821), 60, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1818), "0" },
                    { 61, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1873), 61, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1870), "1" },
                    { 62, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1929), 62, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1926), "2" },
                    { 63, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1983), 63, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(1979), "3" },
                    { 64, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2104), 64, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2100), "4" },
                    { 65, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2168), 65, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2165), "5" },
                    { 66, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2232), 66, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2229), "6" },
                    { 67, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2344), 67, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2339), "7" },
                    { 68, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2402), 68, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2399), "8" },
                    { 69, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2460), 69, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2457), "9" },
                    { 70, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2516), 70, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2511), "0" },
                    { 71, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2572), 71, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2569), "1" },
                    { 72, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2625), 72, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2621), "2" },
                    { 73, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2678), 73, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2675), "3" },
                    { 74, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2793), 74, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2790), "4" },
                    { 75, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2852), 75, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2849), "5" },
                    { 76, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2910), 76, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2906), "6" },
                    { 77, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2965), 77, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(2961), "7" },
                    { 78, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3020), 78, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3017), "8" },
                    { 79, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3072), 79, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3068), "9" },
                    { 80, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3126), 80, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3123), "0" },
                    { 81, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3245), 81, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3241), "1" },
                    { 82, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3301), 82, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3298), "2" },
                    { 83, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3358), 83, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3354), "3" },
                    { 84, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3412), 84, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3408), "4" },
                    { 85, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3467), 85, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3464), "5" },
                    { 86, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3520), 86, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3516), "6" },
                    { 87, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3653), 87, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3649), "7" },
                    { 88, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3712), 88, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3708), "8" },
                    { 89, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3767), 89, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3764), "9" },
                    { 90, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3823), 90, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3819), "0" },
                    { 91, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3882), 91, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3879), "1" },
                    { 92, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3938), 92, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3935), "2" },
                    { 93, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3994), 93, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(3991), "3" },
                    { 94, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4109), 94, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4105), "4" },
                    { 95, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4167), 95, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4164), "5" },
                    { 96, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4221), 96, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4218), "6" },
                    { 97, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4279), 97, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4275), "7" },
                    { 98, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4333), 98, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4329), "8" },
                    { 99, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4389), 99, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4386), "9" },
                    { 100, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4444), 100, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4441), "0" },
                    { 101, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4565), 101, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4561), "1" },
                    { 102, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4623), 102, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4619), "2" },
                    { 103, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4678), 103, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4675), "3" },
                    { 104, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4733), 104, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4730), "4" },
                    { 105, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4787), 105, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4784), "5" },
                    { 106, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4844), 106, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4841), "6" },
                    { 107, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4950), 107, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(4946), "7" },
                    { 108, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5011), 108, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5008), "8" },
                    { 109, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5069), 109, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5065), "9" },
                    { 110, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5125), 110, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5122), "0" },
                    { 111, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5178), 111, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5175), "1" },
                    { 112, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5232), 112, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5229), "2" },
                    { 113, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5289), 113, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5286), "3" },
                    { 114, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5403), 114, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5398), "4" },
                    { 115, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5462), 115, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5458), "5" },
                    { 116, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5518), 116, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5515), "6" },
                    { 117, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5573), 117, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5570), "7" },
                    { 118, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5626), 118, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5623), "8" },
                    { 119, new DateTime(2025, 2, 4, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5681), 119, new DateTime(2025, 1, 14, 21, 8, 33, 511, DateTimeKind.Local).AddTicks(5678), "9" }
                });

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
                    { 19, "Verdieping 19" },
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
