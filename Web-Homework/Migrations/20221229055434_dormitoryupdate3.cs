using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHomework.Migrations
{
    /// <inheritdoc />
    public partial class dormitoryupdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonCategories_PersonCategoryID",
                table: "People");

            migrationBuilder.DropTable(
                name: "PersonCategories");

            migrationBuilder.RenameColumn(
                name: "PersonCategoryID",
                table: "People",
                newName: "RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_People_PersonCategoryID",
                table: "People",
                newName: "IX_People_RoleID");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_People_Roles_RoleID",
                table: "People",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Roles_RoleID",
                table: "People");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.RenameColumn(
                name: "RoleID",
                table: "People",
                newName: "PersonCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_People_RoleID",
                table: "People",
                newName: "IX_People_PersonCategoryID");

            migrationBuilder.CreateTable(
                name: "PersonCategories",
                columns: table => new
                {
                    PersonCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonCategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonCategories", x => x.PersonCategoryID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonCategories_PersonCategoryID",
                table: "People",
                column: "PersonCategoryID",
                principalTable: "PersonCategories",
                principalColumn: "PersonCategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
