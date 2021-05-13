using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelManagement.Migrations
{
    public partial class UpdatedReservationSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "GuestID",
                table: "Reservation",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "RoomName",
                table: "Reservation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomName",
                table: "Reservation");

            migrationBuilder.AlterColumn<int>(
                name: "GuestID",
                table: "Reservation",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
