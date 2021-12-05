using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieInformationRepository.Migrations
{
    public partial class movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "ActorsMovies",
                columns: table => new
                {
                    ActorsListActorId = table.Column<long>(type: "bigint", nullable: false),
                    MoviesListMovieId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsMovies", x => new { x.ActorsListActorId, x.MoviesListMovieId });
                    table.ForeignKey(
                        name: "FK_ActorsMovies_Actors_ActorsListActorId",
                        column: x => x.ActorsListActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionHouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActorId = table.Column<long>(type: "bigint", nullable: true),
                    ActorIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerId1 = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Movies_Producers_ProducerId1",
                        column: x => x.ProducerId1,
                        principalTable: "Producers",
                        principalColumn: "ProducerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsMovies_MoviesListMovieId",
                table: "ActorsMovies",
                column: "MoviesListMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ProducerId1",
                table: "Movies",
                column: "ProducerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_MovieId1",
                table: "Producers",
                column: "MovieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsMovies_Movies_MoviesListMovieId",
                table: "ActorsMovies",
                column: "MoviesListMovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Movies_MovieId1",
                table: "Producers",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Movies_MovieId1",
                table: "Producers");

            migrationBuilder.DropTable(
                name: "ActorsMovies");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
