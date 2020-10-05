using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore.Migrations
{
    public partial class InitHaidarieh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Ceremonies",
                table: "Tbl_Ceremonies");

            migrationBuilder.RenameTable(
                name: "Tbl_Ceremonies",
                newName: "Tbl_Ceremony");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Ceremony",
                table: "Tbl_Ceremony",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Tbl_Guest",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    GuestType = table.Column<string>(nullable: true),
                    Coordinator = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Guest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Multimedia",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    FileAddress = table.Column<string>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CeremonyId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Multimedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_Multimedia_Tbl_Ceremony_CeremonyId",
                        column: x => x.CeremonyId,
                        principalTable: "Tbl_Ceremony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CeremonyGuest",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CeremonyId = table.Column<long>(nullable: false),
                    GuestId = table.Column<long>(nullable: false),
                    CeremonyDate = table.Column<DateTime>(nullable: false),
                    Satisfication = table.Column<float>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CeremonyGuest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tbl_CeremonyGuest_Tbl_Ceremony_CeremonyId",
                        column: x => x.CeremonyId,
                        principalTable: "Tbl_Ceremony",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_CeremonyGuest_Tbl_Guest_GuestId",
                        column: x => x.GuestId,
                        principalTable: "Tbl_Guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CeremonyGuest_CeremonyId",
                table: "Tbl_CeremonyGuest",
                column: "CeremonyId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CeremonyGuest_GuestId",
                table: "Tbl_CeremonyGuest",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Multimedia_CeremonyId",
                table: "Tbl_Multimedia",
                column: "CeremonyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_CeremonyGuest");

            migrationBuilder.DropTable(
                name: "Tbl_Multimedia");

            migrationBuilder.DropTable(
                name: "Tbl_Guest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Ceremony",
                table: "Tbl_Ceremony");

            migrationBuilder.RenameTable(
                name: "Tbl_Ceremony",
                newName: "Tbl_Ceremonies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Ceremonies",
                table: "Tbl_Ceremonies",
                column: "Id");
        }
    }
}
