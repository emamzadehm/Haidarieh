using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationEFCore.Migrations
{
    public partial class AddSponsor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Tbl_Guest",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Sponsor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Tel = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Sponsor", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Sponsor");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Tbl_Guest");
        }
    }
}
