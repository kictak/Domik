using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Storage.Migrations
{
    /// <inheritdoc />
    public partial class Добавлениегендера : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableSeats",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomType",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Guests");

            migrationBuilder.RenameColumn(
                name: "TotalSeats",
                table: "Rooms",
                newName: "RoomTypeid");

            migrationBuilder.RenameColumn(
                name: "Coast",
                table: "Rooms",
                newName: "DayPrice");

            migrationBuilder.AddColumn<int>(
                name: "DocumentTypeId",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Guests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CheckIn",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enter = table.Column<DateOnly>(type: "date", nullable: false),
                    Exit = table.Column<DateOnly>(type: "date", nullable: false),
                    GuestId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckIn", x => x.id);
                    table.ForeignKey(
                        name: "FK_CheckIn_Guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Guests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIn_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomStuff",
                columns: table => new
                {
                    RoomsId = table.Column<int>(type: "int", nullable: false),
                    StuffsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomStuff", x => new { x.RoomsId, x.StuffsId });
                    table.ForeignKey(
                        name: "FK_RoomStuff_Rooms_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoomStuff_Stuffs_StuffsId",
                        column: x => x.StuffsId,
                        principalTable: "Stuffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Places = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomTypeid",
                table: "Rooms",
                column: "RoomTypeid");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_DocumentTypeId",
                table: "Guests",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_GenderId",
                table: "Guests",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_GuestId",
                table: "CheckIn",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_RoomId",
                table: "CheckIn",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomStuff_StuffsId",
                table: "RoomStuff",
                column: "StuffsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_DocumentType_DocumentTypeId",
                table: "Guests",
                column: "DocumentTypeId",
                principalTable: "DocumentType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Genders_GenderId",
                table: "Guests",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeid",
                table: "Rooms",
                column: "RoomTypeid",
                principalTable: "RoomType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_DocumentType_DocumentTypeId",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Genders_GenderId",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomType_RoomTypeid",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "CheckIn");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "RoomStuff");

            migrationBuilder.DropTable(
                name: "RoomType");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomTypeid",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Guests_DocumentTypeId",
                table: "Guests");

            migrationBuilder.DropIndex(
                name: "IX_Guests_GenderId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "DocumentTypeId",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Guests");

            migrationBuilder.RenameColumn(
                name: "RoomTypeid",
                table: "Rooms",
                newName: "TotalSeats");

            migrationBuilder.RenameColumn(
                name: "DayPrice",
                table: "Rooms",
                newName: "Coast");

            migrationBuilder.AddColumn<int>(
                name: "AvailableSeats",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoomType",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Guests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
