using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adigabze.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diller",
                columns: table => new
                {
                    DilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DilAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diller", x => x.DilId);
                });

            migrationBuilder.CreateTable(
                name: "Dizin",
                columns: table => new
                {
                    AnahtarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sozcuk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dizin", x => x.AnahtarId);
                });

            migrationBuilder.CreateTable(
                name: "Ekler",
                columns: table => new
                {
                    SozcukEkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EkTipi = table.Column<int>(type: "int", nullable: false),
                    EkTuru = table.Column<int>(type: "int", nullable: false),
                    Ek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UstId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ekler", x => x.SozcukEkId);
                    table.ForeignKey(
                        name: "FK_Ekler_Ekler_UstId",
                        column: x => x.UstId,
                        principalTable: "Ekler",
                        principalColumn: "SozcukEkId");
                });

            migrationBuilder.CreateTable(
                name: "Yetkinlikler",
                columns: table => new
                {
                    YetkinlikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YetkinlikTanim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkinlikler", x => x.YetkinlikId);
                });

            migrationBuilder.CreateTable(
                name: "Alfabe",
                columns: table => new
                {
                    HarfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyukHarf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KucukHarf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alfabe", x => x.HarfId);
                    table.ForeignKey(
                        name: "FK_Alfabe_Diller_DilId",
                        column: x => x.DilId,
                        principalTable: "Diller",
                        principalColumn: "DilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boy",
                columns: table => new
                {
                    BoyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoyAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boy", x => x.BoyId);
                    table.ForeignKey(
                        name: "FK_Boy_Diller_DilId",
                        column: x => x.DilId,
                        principalTable: "Diller",
                        principalColumn: "DilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lehce",
                columns: table => new
                {
                    LehceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LehceAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lehce", x => x.LehceId);
                    table.ForeignKey(
                        name: "FK_Lehce_Diller_DilId",
                        column: x => x.DilId,
                        principalTable: "Diller",
                        principalColumn: "DilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sozluk",
                columns: table => new
                {
                    SozcukId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnahtarId = table.Column<int>(type: "int", nullable: false),
                    Anlam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SozcukTuru = table.Column<int>(type: "int", nullable: false),
                    YetkinlikID = table.Column<int>(type: "int", nullable: true),
                    KokId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sozluk", x => x.SozcukId);
                    table.ForeignKey(
                        name: "FK_Sozluk_Dizin_AnahtarId",
                        column: x => x.AnahtarId,
                        principalTable: "Dizin",
                        principalColumn: "AnahtarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sozluk_Dizin_KokId",
                        column: x => x.KokId,
                        principalTable: "Dizin",
                        principalColumn: "AnahtarId");
                    table.ForeignKey(
                        name: "FK_Sozluk_Yetkinlikler_YetkinlikID",
                        column: x => x.YetkinlikID,
                        principalTable: "Yetkinlikler",
                        principalColumn: "YetkinlikId");
                });

            migrationBuilder.CreateTable(
                name: "Uniteler",
                columns: table => new
                {
                    UniteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniteTanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YetkinlikId = table.Column<int>(type: "int", nullable: false)
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
                name: "Sulaleler",
                columns: table => new
                {
                    SulaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SulaleAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sulaleler", x => x.SulaleId);
                    table.ForeignKey(
                        name: "FK_Sulaleler_Boy_BoyId",
                        column: x => x.BoyId,
                        principalTable: "Boy",
                        principalColumn: "BoyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Konular",
                columns: table => new
                {
                    KonuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonuTanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniteId = table.Column<int>(type: "int", nullable: false)
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
                    KazanimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KazanimTanim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KonuId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_Alfabe_DilId",
                table: "Alfabe",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Boy_DilId",
                table: "Boy",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Ekler_UstId",
                table: "Ekler",
                column: "UstId");

            migrationBuilder.CreateIndex(
                name: "IX_Kazanimlar_KonuId",
                table: "Kazanimlar",
                column: "KonuId");

            migrationBuilder.CreateIndex(
                name: "IX_Konular_UniteId",
                table: "Konular",
                column: "UniteId");

            migrationBuilder.CreateIndex(
                name: "IX_Lehce_DilId",
                table: "Lehce",
                column: "DilId");

            migrationBuilder.CreateIndex(
                name: "IX_Sozluk_AnahtarId",
                table: "Sozluk",
                column: "AnahtarId");

            migrationBuilder.CreateIndex(
                name: "IX_Sozluk_KokId",
                table: "Sozluk",
                column: "KokId");

            migrationBuilder.CreateIndex(
                name: "IX_Sozluk_YetkinlikID",
                table: "Sozluk",
                column: "YetkinlikID");

            migrationBuilder.CreateIndex(
                name: "IX_Sulaleler_BoyId",
                table: "Sulaleler",
                column: "BoyId");

            migrationBuilder.CreateIndex(
                name: "IX_Uniteler_YetkinlikId",
                table: "Uniteler",
                column: "YetkinlikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alfabe");

            migrationBuilder.DropTable(
                name: "Ekler");

            migrationBuilder.DropTable(
                name: "Kazanimlar");

            migrationBuilder.DropTable(
                name: "Lehce");

            migrationBuilder.DropTable(
                name: "Sozluk");

            migrationBuilder.DropTable(
                name: "Sulaleler");

            migrationBuilder.DropTable(
                name: "Konular");

            migrationBuilder.DropTable(
                name: "Dizin");

            migrationBuilder.DropTable(
                name: "Boy");

            migrationBuilder.DropTable(
                name: "Uniteler");

            migrationBuilder.DropTable(
                name: "Diller");

            migrationBuilder.DropTable(
                name: "Yetkinlikler");
        }
    }
}
