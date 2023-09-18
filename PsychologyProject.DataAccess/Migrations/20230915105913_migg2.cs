using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServicesDescription",
                table: "services");

            migrationBuilder.DropColumn(
                name: "ServicesIcon",
                table: "services");

            migrationBuilder.DropColumn(
                name: "ServicesTitle",
                table: "services");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServicesDescription",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServicesIcon",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServicesTitle",
                table: "services",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
