﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerieDLLEF.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "acteur",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    prenom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__acteur__3213E83F012BD232", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "episode",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    saisonid = table.Column<int>(name: "saison_id", type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    resume = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    datepremdiff = table.Column<DateTime>(name: "date_prem_diff", type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__episode__3213E83F07132552", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "serie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    datediff = table.Column<DateTime>(name: "date_diff", type: "date", nullable: true),
                    resume = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    affiche = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    urlba = table.Column<string>(name: "url_ba", type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__serie__3213E83F1A62E8C0", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userApp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    roles = table.Column<int>(type: "int", nullable: false),
                    WatchList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__userApp__3213E83F7BE5A89E", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personnage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acteurid = table.Column<int>(name: "acteur_id", type: "int", nullable: false),
                    serieid = table.Column<int>(name: "serie_id", type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__personna__3213E83F9D3A7249", x => x.id);
                    table.ForeignKey(
                        name: "FK__personnag__acteu__38996AB5",
                        column: x => x.acteurid,
                        principalTable: "acteur",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__personnag__serie__398D8EEE",
                        column: x => x.serieid,
                        principalTable: "serie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "saison",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serieid = table.Column<int>(name: "serie_id", type: "int", nullable: false),
                    numero = table.Column<short>(type: "smallint", nullable: false),
                    nbepisode = table.Column<int>(name: "nb_episode", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__saison__3213E83FAFFCF90F", x => x.id);
                    table.ForeignKey(
                        name: "FK__saison__serie_id__3C69FB99",
                        column: x => x.serieid,
                        principalTable: "serie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "note",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serieid = table.Column<int>(name: "serie_id", type: "int", nullable: false),
                    userid = table.Column<int>(name: "user_id", type: "int", nullable: false),
                    commentaire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    note = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__note__3213E83F012BD232", x => x.id);
                    table.ForeignKey(
                        name: "FK__note__serie__38996AB5",
                        column: x => x.serieid,
                        principalTable: "serie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__note__user__231223151",
                        column: x => x.userid,
                        principalTable: "userApp",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_note_serie_id",
                table: "note",
                column: "serie_id");

            migrationBuilder.CreateIndex(
                name: "IX_note_user_id",
                table: "note",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_personnage_acteur_id",
                table: "personnage",
                column: "acteur_id");

            migrationBuilder.CreateIndex(
                name: "IX_personnage_serie_id",
                table: "personnage",
                column: "serie_id");

            migrationBuilder.CreateIndex(
                name: "IX_saison_serie_id",
                table: "saison",
                column: "serie_id");

            migrationBuilder.InsertData("userApp",
                new[] { "login", "password", "roles", "WatchList" },
                new object[,]
                {
                    {
                        "Admin",
                        "b03ddf3ca2e714a6548e7495e2a03f5e824eaac9837cd7f159c67b90fb4b7342",
                        2,
                        "{}"
                    }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "episode");

            migrationBuilder.DropTable(
                name: "note");

            migrationBuilder.DropTable(
                name: "personnage");

            migrationBuilder.DropTable(
                name: "saison");

            migrationBuilder.DropTable(
                name: "userApp");

            migrationBuilder.DropTable(
                name: "acteur");

            migrationBuilder.DropTable(
                name: "serie");
        }
    }
}
