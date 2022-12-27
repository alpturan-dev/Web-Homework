using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebHomework.Migrations
{
    /// <inheritdoc />
    public partial class dormitoryupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "People");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
