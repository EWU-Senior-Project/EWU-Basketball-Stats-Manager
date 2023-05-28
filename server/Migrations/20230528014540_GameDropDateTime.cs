using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class GameDropDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameDate",
                table: "Games");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "PlayerBoxes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBoxes_TeamId",
                table: "PlayerBoxes",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerBoxes_Teams_TeamId",
                table: "PlayerBoxes",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerBoxes_Teams_TeamId",
                table: "PlayerBoxes");

            migrationBuilder.DropIndex(
                name: "IX_PlayerBoxes_TeamId",
                table: "PlayerBoxes");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "PlayerBoxes");

            migrationBuilder.AddColumn<DateTime>(
                name: "GameDate",
                table: "Games",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
