using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoftwareDevelopment2.Data.Migrations
{
    /// <inheritdoc />
    public partial class SubscriptionAndFriends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgeGroup = table.Column<int>(type: "int", nullable: false),
                    ItemsPerYear = table.Column<int>(type: "int", nullable: false),
                    ItemsAtSameTime = table.Column<int>(type: "int", nullable: false),
                    LoanPeriodInDays = table.Column<int>(type: "int", nullable: false),
                    ExtendsInARow = table.Column<int>(type: "int", nullable: false),
                    ReservationCost = table.Column<float>(type: "real", nullable: false),
                    FinePerItemPerDay = table.Column<float>(type: "real", nullable: false),
                    SubscriptionCostPerMonth = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Subscription");


        }
    }
}
