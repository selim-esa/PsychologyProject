using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migg4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubDescription",
                table: "aboutUs");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                table: "aboutUs");

            migrationBuilder.CreateTable(
                name: "aboutUsItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutUsItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "aboutUsItems");

            migrationBuilder.AddColumn<string>(
                name: "SubDescription",
                table: "aboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                table: "aboutUs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
