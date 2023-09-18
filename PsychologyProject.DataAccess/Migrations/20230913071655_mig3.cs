using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BriefDescription",
                table: "homes");

            migrationBuilder.DropColumn(
                name: "BriefIcon",
                table: "homes");

            migrationBuilder.DropColumn(
                name: "BriefTitle",
                table: "homes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BriefDescription",
                table: "homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BriefIcon",
                table: "homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BriefTitle",
                table: "homes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
