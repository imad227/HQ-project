using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HQ_Webb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Wizard_PlayerName",
                table: "Heroes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Wizard_SpellCaster",
                table: "Heroes",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wizard_PlayerName",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "Wizard_SpellCaster",
                table: "Heroes");
        }
    }
}
