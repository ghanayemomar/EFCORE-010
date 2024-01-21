using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORE010.Migrations
{
    /// <inheritdoc />
    public partial class TT02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Particpant");

            migrationBuilder.AddColumn<string>(
                name: "ParricipantType",
                table: "Particpant",
                type: "VARCHAR(4)",
                maxLength: 4,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParricipantType",
                table: "Particpant");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Particpant",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
