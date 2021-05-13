using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagement.Migrations
{
    public partial class UpdatedGuestTablewithRoomAvaiability : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RoomisAvailable",
                table: "Guest",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomisAvailable",
                table: "Guest");
        }
    }
}
