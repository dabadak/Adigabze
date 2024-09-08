using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adigabze.WebUI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yetkinlikler",
                columns: table => new
                {
                    YetkinlikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    YetkinlikTanim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkinlikler", x => x.YetkinlikId);
                });

            migrationBuilder.CreateTable(
                name: "Uniteler",
                columns: table => new
                {
                    UniteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UniteTanim = table.Column<string>(nullable: true),
                    YetkinlikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uniteler", x => x.UniteId);
                    table.ForeignKey(
                        name: "FK_Uniteler_Yetkinlikler_YetkinlikId",
                        column: x => x.YetkinlikId,
                        principalTable: "Yetkinlikler",
                        principalColumn: "YetkinlikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konular",
                columns: table => new
                {
                    KonuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KonuTanim = table.Column<string>(nullable: true),
                    UniteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konular", x => x.KonuId);
                    table.ForeignKey(
                        name: "FK_Konular_Uniteler_UniteId",
                        column: x => x.UniteId,
                        principalTable: "Uniteler",
                        principalColumn: "UniteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kazanimlar",
                columns: table => new
                {
                    KazanimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KazanimTanim = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true),
                    KonuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kazanimlar", x => x.KazanimId);
                    table.ForeignKey(
                        name: "FK_Kazanimlar_Konular_KonuId",
                        column: x => x.KonuId,
                        principalTable: "Konular",
                        principalColumn: "KonuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kazanimlar_KonuId",
                table: "Kazanimlar",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_Konular_UniteId",
                table: "Konular",
                column: "UniteId");

            migrationBuilder.CreateIndex(
                name: "IX_Uniteler_YetkinlikId",
                table: "Uniteler",
                column: "YetkinlikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kazanimlar");

            migrationBuilder.DropTable(
                name: "Konular");

            migrationBuilder.DropTable(
                name: "Uniteler");

            migrationBuilder.DropTable(
                name: "Yetkinlikler");
        }
    }
}
