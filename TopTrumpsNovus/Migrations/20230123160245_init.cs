using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopTrumpsNovus.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeckID = table.Column<int>(type: "int", nullable: false),
                    CardName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ImageFilePath = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StatOne = table.Column<int>(type: "int", nullable: false),
                    StatTwo = table.Column<int>(type: "int", nullable: false),
                    StatThree = table.Column<int>(type: "int", nullable: false),
                    StatFour = table.Column<int>(type: "int", nullable: false),
                    StatFive = table.Column<int>(type: "int", nullable: false),
                    StatSix = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
