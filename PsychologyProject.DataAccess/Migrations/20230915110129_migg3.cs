using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "serviceItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicesIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceItem", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serviceItem");
        }
    }
}
