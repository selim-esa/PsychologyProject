using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sliders_aboutUs_AboutUsId",
                table: "sliders");

            migrationBuilder.DropForeignKey(
                name: "FK_sliders_homes_HomeId",
                table: "sliders");

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "sliders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AboutUsId",
                table: "sliders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_sliders_aboutUs_AboutUsId",
                table: "sliders",
                column: "AboutUsId",
                principalTable: "aboutUs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sliders_homes_HomeId",
                table: "sliders",
                column: "HomeId",
                principalTable: "homes",
                principalColumn: "HomeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sliders_aboutUs_AboutUsId",
                table: "sliders");

            migrationBuilder.DropForeignKey(
                name: "FK_sliders_homes_HomeId",
                table: "sliders");

            migrationBuilder.AlterColumn<int>(
                name: "HomeId",
                table: "sliders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AboutUsId",
                table: "sliders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_sliders_aboutUs_AboutUsId",
                table: "sliders",
                column: "AboutUsId",
                principalTable: "aboutUs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sliders_homes_HomeId",
                table: "sliders",
                column: "HomeId",
                principalTable: "homes",
                principalColumn: "HomeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
