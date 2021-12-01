using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerExpertsNew.Migrations
{
    public partial class CreateInformationListAndValentineAndTransitionVideoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformationList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValentineListImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValentineListText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransitionVideo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransitionVideoImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransitionVideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransitionVideo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Valentine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValentinaTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValentineText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Valentine", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationList");

            migrationBuilder.DropTable(
                name: "TransitionVideo");

            migrationBuilder.DropTable(
                name: "Valentine");
        }
    }
}
