using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class seasonStatsAddedtoDbSets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStat_Players_PlayerId",
                table: "PlayerSeasonStat");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStat_Seasons_SeasonId",
                table: "PlayerSeasonStat");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerSeasonStat",
                table: "PlayerSeasonStat");

            migrationBuilder.RenameTable(
                name: "PlayerSeasonStat",
                newName: "PlayerSeasonStats");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerSeasonStat_SeasonId",
                table: "PlayerSeasonStats",
                newName: "IX_PlayerSeasonStats_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerSeasonStat_PlayerId",
                table: "PlayerSeasonStats",
                newName: "IX_PlayerSeasonStats_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerSeasonStats",
                table: "PlayerSeasonStats",
                column: "PlayerSeasonStatId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStats_Players_PlayerId",
                table: "PlayerSeasonStats",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStats_Players_PlayerId",
                table: "PlayerSeasonStats");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerSeasonStats_Seasons_SeasonId",
                table: "PlayerSeasonStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerSeasonStats",
                table: "PlayerSeasonStats");

            migrationBuilder.RenameTable(
                name: "PlayerSeasonStats",
                newName: "PlayerSeasonStat");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerSeasonStats_SeasonId",
                table: "PlayerSeasonStat",
                newName: "IX_PlayerSeasonStat_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerSeasonStats_PlayerId",
                table: "PlayerSeasonStat",
                newName: "IX_PlayerSeasonStat_PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerSeasonStat",
                table: "PlayerSeasonStat",
                column: "PlayerSeasonStatId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStat_Players_PlayerId",
                table: "PlayerSeasonStat",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerSeasonStat_Seasons_SeasonId",
                table: "PlayerSeasonStat",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
