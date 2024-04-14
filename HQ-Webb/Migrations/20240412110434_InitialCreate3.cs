using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HQ_Webb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WeaponDescription",
                table: "Item",
                newName: "ItemDescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemDescription",
                table: "Item",
                newName: "WeaponDescription");
        }
    }
}
