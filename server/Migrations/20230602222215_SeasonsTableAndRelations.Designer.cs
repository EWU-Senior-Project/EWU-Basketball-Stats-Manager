﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using server.Data;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230602222215_SeasonsTableAndRelations")]
    partial class SeasonsTableAndRelations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("server.Data.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GameId"));

                    b.Property<int>("AwayScore")
                        .HasColumnType("integer");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("GameDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("HomeScore")
                        .HasColumnType("integer");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("integer");

                    b.Property<int?>("SeasonId")
                        .HasColumnType("integer");

                    b.HasKey("GameId");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("server.Data.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlayerId"));

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HeadshotHref")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Jersey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionAbbreviation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("server.Data.PlayerBox", b =>
                {
                    b.Property<int>("PlayerBoxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PlayerBoxId"));

                    b.Property<int>("Assists")
                        .HasColumnType("integer");

                    b.Property<int>("Blocks")
                        .HasColumnType("integer");

                    b.Property<int>("DefensiveRebounds")
                        .HasColumnType("integer");

                    b.Property<bool>("DidNotPlay")
                        .HasColumnType("boolean");

                    b.Property<bool>("Ejected")
                        .HasColumnType("boolean");

                    b.Property<int>("FieldGoalsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("FieldGoalsMade")
                        .HasColumnType("integer");

                    b.Property<int>("Fouls")
                        .HasColumnType("integer");

                    b.Property<int>("FreeThrowsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("FreeThrowsMade")
                        .HasColumnType("integer");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int>("Minutes")
                        .HasColumnType("integer");

                    b.Property<int>("OffensiveRebounds")
                        .HasColumnType("integer");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int>("Rebounds")
                        .HasColumnType("integer");

                    b.Property<int>("Season")
                        .HasColumnType("integer");

                    b.Property<int>("SeasonType")
                        .HasColumnType("integer");

                    b.Property<bool>("Starter")
                        .HasColumnType("boolean");

                    b.Property<int>("Steals")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.Property<int>("ThreePointFieldGoalsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("ThreePointFieldGoalsMade")
                        .HasColumnType("integer");

                    b.Property<int>("Turnovers")
                        .HasColumnType("integer");

                    b.HasKey("PlayerBoxId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("PlayerBoxes");
                });

            modelBuilder.Entity("server.Data.Season", b =>
                {
                    b.Property<int>("SeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SeasonId"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SeasonString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("server.Data.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeamId"));

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AlternateColor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortDisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("server.Data.TeamBox", b =>
                {
                    b.Property<int>("TeamBoxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeamBoxId"));

                    b.Property<int>("Assists")
                        .HasColumnType("integer");

                    b.Property<int>("Blocks")
                        .HasColumnType("integer");

                    b.Property<int>("DefensiveRebounds")
                        .HasColumnType("integer");

                    b.Property<double>("FieldGoalPct")
                        .HasColumnType("double precision");

                    b.Property<int>("FieldGoalsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("FieldGoalsMade")
                        .HasColumnType("integer");

                    b.Property<int>("FlagrantFouls")
                        .HasColumnType("integer");

                    b.Property<int>("Fouls")
                        .HasColumnType("integer");

                    b.Property<double>("FreeThrowPct")
                        .HasColumnType("double precision");

                    b.Property<int>("FreeThrowsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("FreeThrowsMade")
                        .HasColumnType("integer");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<int>("LargestLead")
                        .HasColumnType("integer");

                    b.Property<int>("OffensiveRebounds")
                        .HasColumnType("integer");

                    b.Property<int>("Steals")
                        .HasColumnType("integer");

                    b.Property<int>("TeamId")
                        .HasColumnType("integer");

                    b.Property<int>("TeamScore")
                        .HasColumnType("integer");

                    b.Property<int>("TeamTurnovers")
                        .HasColumnType("integer");

                    b.Property<bool>("TeamWinner")
                        .HasColumnType("boolean");

                    b.Property<int>("TechnicalFouls")
                        .HasColumnType("integer");

                    b.Property<double>("ThreePointFieldGoalPct")
                        .HasColumnType("double precision");

                    b.Property<int>("ThreePointFieldGoalsAttempted")
                        .HasColumnType("integer");

                    b.Property<int>("ThreePointFieldGoalsMade")
                        .HasColumnType("integer");

                    b.Property<int>("TotalRebounds")
                        .HasColumnType("integer");

                    b.Property<int>("TotalTechnicalFouls")
                        .HasColumnType("integer");

                    b.Property<int>("TotalTurnovers")
                        .HasColumnType("integer");

                    b.Property<int>("Turnovers")
                        .HasColumnType("integer");

                    b.HasKey("TeamBoxId");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamBoxes");
                });

            modelBuilder.Entity("server.Data.Game", b =>
                {
                    b.HasOne("server.Data.Team", "AwayTeam")
                        .WithMany("AwayGames")
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("server.Data.Team", "HomeTeam")
                        .WithMany("HomeGames")
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("server.Data.Season", "Season")
                        .WithMany("Games")
                        .HasForeignKey("SeasonId");

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("Season");
                });

            modelBuilder.Entity("server.Data.Player", b =>
                {
                    b.HasOne("server.Data.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("server.Data.PlayerBox", b =>
                {
                    b.HasOne("server.Data.Game", "Game")
                        .WithMany("PlayerBoxes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Data.Player", "Player")
                        .WithMany("PlayerBoxes")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Data.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("server.Data.TeamBox", b =>
                {
                    b.HasOne("server.Data.Game", "Game")
                        .WithMany("TeamBoxes")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.Data.Team", "Team")
                        .WithMany("TeamBoxes")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("server.Data.Game", b =>
                {
                    b.Navigation("PlayerBoxes");

                    b.Navigation("TeamBoxes");
                });

            modelBuilder.Entity("server.Data.Player", b =>
                {
                    b.Navigation("PlayerBoxes");
                });

            modelBuilder.Entity("server.Data.Season", b =>
                {
                    b.Navigation("Games");
                });

            modelBuilder.Entity("server.Data.Team", b =>
                {
                    b.Navigation("AwayGames");

                    b.Navigation("HomeGames");

                    b.Navigation("Players");

                    b.Navigation("TeamBoxes");
                });
#pragma warning restore 612, 618
        }
    }
}
