using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HQ_Webb.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CharacterName = table.Column<string>(type: "TEXT", nullable: false),
                    Attack = table.Column<int>(type: "INTEGER", nullable: false),
                    Defence = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxBody = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMind = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentBody = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentMind = table.Column<int>(type: "INTEGER", nullable: false),
                    Gold = table.Column<double>(type: "REAL", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    Barbarian_PlayerName = table.Column<string>(type: "TEXT", nullable: true),
                    Barbarian_SpellCaster = table.Column<bool>(type: "INTEGER", nullable: true),
                    Dwarf_PlayerName = table.Column<string>(type: "TEXT", nullable: true),
                    Dwarf_SpellCaster = table.Column<bool>(type: "INTEGER", nullable: true),
                    PlayerName = table.Column<string>(type: "TEXT", nullable: true),
                    SpellCaster = table.Column<bool>(type: "INTEGER", nullable: true),
                    Rough_PlayerName = table.Column<string>(type: "TEXT", nullable: true),
                    Rough_SpellCaster = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IsSpell = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AttackModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    DefenceModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxBodyModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentBodyModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxMindModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentMindModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    GoldModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    Isequibt = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    WeaponDescription = table.Column<string>(type: "TEXT", nullable: false),
                    HeroesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Heroes_HeroesId",
                        column: x => x.HeroesId,
                        principalTable: "Heroes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AttackModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    DefenceModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    BodyModifier = table.Column<int>(type: "INTEGER", nullable: false),
                    Isequibt = table.Column<bool>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false),
                    WeaponDescription = table.Column<string>(type: "TEXT", nullable: false),
                    HeroesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapon_Heroes_HeroesId",
                        column: x => x.HeroesId,
                        principalTable: "Heroes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_HeroesId",
                table: "Item",
                column: "HeroesId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapon_HeroesId",
                table: "Weapon",
                column: "HeroesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
