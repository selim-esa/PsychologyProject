using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PsychologyProject.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aboutUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HappyClient = table.Column<int>(type: "int", nullable: false),
                    YearInBusiness = table.Column<int>(type: "int", nullable: false),
                    HighScore = table.Column<int>(type: "int", nullable: false),
                    CupsOfCoffee = table.Column<int>(type: "int", nullable: false),
                    WeAreTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeArePreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeAreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamPreDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessHour = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "footers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Links = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_footers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "homes",
                columns: table => new
                {
                    HomeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BriefTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BriefDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BriefIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestPostTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestPostDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatestPostDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_homes", x => x.HomeId);
                });

            migrationBuilder.CreateTable(
                name: "navbars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyProperty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_navbars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesIcon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServicesDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sideBarCategories",
                columns: table => new
                {
                    SideBarCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideBarCategories", x => x.SideBarCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SliderTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeId = table.Column<int>(type: "int", nullable: false),
                    AboutUsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sliders", x => x.SliderId);
                    table.ForeignKey(
                        name: "FK_sliders_aboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalTable: "aboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_sliders_homes_HomeId",
                        column: x => x.HomeId,
                        principalTable: "homes",
                        principalColumn: "HomeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sideBars",
                columns: table => new
                {
                    SideBarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SideBarCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sideBars", x => x.SideBarId);
                    table.ForeignKey(
                        name: "FK_sideBars_sideBarCategories_SideBarCategoryId",
                        column: x => x.SideBarCategoryId,
                        principalTable: "sideBarCategories",
                        principalColumn: "SideBarCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_sideBars_SideBarCategoryId",
                table: "sideBars",
                column: "SideBarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_sliders_AboutUsId",
                table: "sliders",
                column: "AboutUsId");

            migrationBuilder.CreateIndex(
                name: "IX_sliders_HomeId",
                table: "sliders",
                column: "HomeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "footers");

            migrationBuilder.DropTable(
                name: "navbars");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "sideBars");

            migrationBuilder.DropTable(
                name: "sliders");

            migrationBuilder.DropTable(
                name: "sideBarCategories");

            migrationBuilder.DropTable(
                name: "aboutUs");

            migrationBuilder.DropTable(
                name: "homes");
        }
    }
}
