using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apkbackend.Migrations
{
    /// <inheritdoc />
    public partial class Opiekun : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opiekun",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opiekun",
                table: "Project");
        }
    }
}
