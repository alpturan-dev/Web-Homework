using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHomework.Migrations
{
    /// <inheritdoc />
    public partial class dormitoryupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Categories_CategoryID",
                table: "People");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_People_CategoryID",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "PersonCategoryID",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PersonCategories",
                columns: table => new
                {
                    PersonCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonCategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PersonCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCategories", x => x.PersonCategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_PersonCategoryID",
                table: "People",
                column: "PersonCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonCategories_PersonCategoryID",
                table: "People",
                column: "PersonCategoryID",
                principalTable: "PersonCategories",
                principalColumn: "PersonCategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonCategories_PersonCategoryID",
                table: "People");

            migrationBuilder.DropTable(
                name: "PersonCategories");

            migrationBuilder.DropIndex(
                name: "IX_People_PersonCategoryID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "PersonCategoryID",
                table: "People");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_People_CategoryID",
                table: "People",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Categories_CategoryID",
                table: "People",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
