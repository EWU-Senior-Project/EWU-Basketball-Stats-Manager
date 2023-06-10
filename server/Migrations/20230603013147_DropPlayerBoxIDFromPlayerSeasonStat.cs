using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class DropPlayerBoxIDFromPlayerSeasonStat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats");

            migrationBuilder.DropColumn(
                name: "PlayerBoxId",
                table: "PlayerSeasonStats");

            migrationBuilder.AlterColumn<int>(
                name: "SeasonId",
                table: "PlayerSeasonStats",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats");

            migrationBuilder.AlterColumn<int>(
                name: "SeasonId",
                table: "PlayerSeasonStats",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerBoxId",
                table: "PlayerSeasonStats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
