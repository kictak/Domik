using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    /// <inheritdoc />
    public partial class Checkin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIn_Guests_GuestId",
                table: "CheckIn");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckIn_Rooms_RoomId",
                table: "CheckIn");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckIn",
                table: "CheckIn");

            migrationBuilder.RenameTable(
                name: "CheckIn",
                newName: "CheckIns");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIn_RoomId",
                table: "CheckIns",
                newName: "IX_CheckIns_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIn_GuestId",
                table: "CheckIns",
                newName: "IX_CheckIns_GuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckIns",
                table: "CheckIns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Guests_GuestId",
                table: "CheckIns",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Rooms_RoomId",
                table: "CheckIns",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Guests_GuestId",
                table: "CheckIns");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Rooms_RoomId",
                table: "CheckIns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CheckIns",
                table: "CheckIns");

            migrationBuilder.RenameTable(
                name: "CheckIns",
                newName: "CheckIn");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_RoomId",
                table: "CheckIn",
                newName: "IX_CheckIn_RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_CheckIns_GuestId",
                table: "CheckIn",
                newName: "IX_CheckIn_GuestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CheckIn",
                table: "CheckIn",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIn_Guests_GuestId",
                table: "CheckIn",
                column: "GuestId",
                principalTable: "Guests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIn_Rooms_RoomId",
                table: "CheckIn",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}