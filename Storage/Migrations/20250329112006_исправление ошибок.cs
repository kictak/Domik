using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    /// <inheritdoc />
    public partial class исправлениеошибок : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeid",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "RoomType",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RoomTypeid",
                table: "Rooms",
                newName: "RoomTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeid",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CheckIn",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms",
                column: "RoomTypeId",
                principalTable: "RoomType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeId",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RoomType",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "RoomTypeId",
                table: "Rooms",
                newName: "RoomTypeid");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomTypeId",
                table: "Rooms",
                newName: "IX_Rooms_RoomTypeid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CheckIn",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeid",
                table: "Rooms",
                column: "RoomTypeid",
                principalTable: "RoomType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
