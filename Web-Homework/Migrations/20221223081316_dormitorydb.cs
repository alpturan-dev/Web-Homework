using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHomework.Migrations
{
    /// <inheritdoc />
    public partial class dormitorydb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Categories_CategoryID1",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CategoryID1",
                table: "People");

            migrationBuilder.DropColumn(
                name: "CategoryID1",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "People",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Categories_CategoryID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_CategoryID",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryID",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID1",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_People_CategoryID1",
                table: "People",
                column: "CategoryID1");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Categories_CategoryID1",
                table: "People",
                column: "CategoryID1",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
