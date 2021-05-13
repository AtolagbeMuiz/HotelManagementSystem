using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagement.Migrations
{
    public partial class CreatedReservationSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    RoomisAvailable = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");
        }
    }
}
