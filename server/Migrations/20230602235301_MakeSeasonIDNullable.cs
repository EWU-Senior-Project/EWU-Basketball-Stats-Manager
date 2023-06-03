using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class MakeSeasonIDNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Season",
                table: "PlayerBoxes");

            migrationBuilder.DropColumn(
                name: "SeasonType",
                table: "PlayerBoxes");

            migrationBuilder.AddColumn<int>(
                name: "SeasonId",
                table: "PlayerBoxes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isAggregated",
                table: "PlayerBoxes",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PlayerSeasonStat",
                columns: table => new
                {
                    PlayerSeasonStatId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PlayerId = table.Column<int>(type: "integer", nullable: false),
                    SeasonId = table.Column<int>(type: "integer", nullable: false),
                    GamesPlayed = table.Column<int>(type: "integer", nullable: false),
                    PlayerBoxId = table.Column<int>(type: "integer", nullable: false),
                    Minutes = table.Column<int>(type: "integer", nullable: false),
                    FieldGoalsMade = table.Column<int>(type: "integer", nullable: false),
                    FieldGoalsAttempted = table.Column<int>(type: "integer", nullable: false),
                    ThreePointFieldGoalsMade = table.Column<int>(type: "integer", nullable: false),
                    ThreePointFieldGoalsAttempted = table.Column<int>(type: "integer", nullable: false),
                    FreeThrowsMade = table.Column<int>(type: "integer", nullable: false),
                    FreeThrowsAttempted = table.Column<int>(type: "integer", nullable: false),
                    OffensiveRebounds = table.Column<int>(type: "integer", nullable: false),
                    DefensiveRebounds = table.Column<int>(type: "integer", nullable: false),
                    Rebounds = table.Column<int>(type: "integer", nullable: false),
                    Assists = table.Column<int>(type: "integer", nullable: false),
                    Steals = table.Column<int>(type: "integer", nullable: false),
                    Blocks = table.Column<int>(type: "integer", nullable: false),
                    Turnovers = table.Column<int>(type: "integer", nullable: false),
                    Fouls = table.Column<int>(type: "integer", nullable: false),
                    Points = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerSeasonStat", x => x.PlayerSeasonStatId);
                    table.ForeignKey(
                        name: "FK_PlayerSeasonStat_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerSeasonStat_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "SeasonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerBoxes_SeasonId",
                table: "PlayerBoxes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSeasonStat_PlayerId",
                table: "PlayerSeasonStat",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerSeasonStat_SeasonId",
                table: "PlayerSeasonStat",
                column: "SeasonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerBoxes_Seasons_SeasonId",
                table: "PlayerBoxes",
                column: "SeasonId",
                principalTable: "Seasons",
                principalColumn: "SeasonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerBoxes_Seasons_SeasonId",
                table: "PlayerBoxes");

            migrationBuilder.DropTable(
                name: "PlayerSeasonStat");

            migrationBuilder.DropIndex(
                name: "IX_PlayerBoxes_SeasonId",
                table: "PlayerBoxes");

            migrationBuilder.DropColumn(
                name: "SeasonId",
                table: "PlayerBoxes");

            migrationBuilder.DropColumn(
                name: "isAggregated",
                table: "PlayerBoxes");

            migrationBuilder.AddColumn<int>(
                name: "Season",
                table: "PlayerBoxes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeasonType",
                table: "PlayerBoxes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
