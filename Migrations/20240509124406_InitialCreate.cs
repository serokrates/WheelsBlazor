using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WheelsBlazor.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WheelsTable",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandID = table.Column<int>(type: "INTEGER", nullable: false),
                    BrandType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelsTable", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Alutec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    WheelsTableID = table.Column<int>(type: "INTEGER", nullable: false),
                    Diameter = table.Column<float>(type: "REAL", nullable: false),
                    BoltCircle = table.Column<int>(type: "INTEGER", nullable: false),
                    Offset = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alutec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alutec_WheelsTable_WheelsTableID",
                        column: x => x.WheelsTableID,
                        principalTable: "WheelsTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anzio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    WheelsTableID = table.Column<int>(type: "INTEGER", nullable: false),
                    Diameter = table.Column<float>(type: "REAL", nullable: false),
                    BoltCircle = table.Column<int>(type: "INTEGER", nullable: false),
                    Offset = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anzio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Anzio_WheelsTable_WheelsTableID",
                        column: x => x.WheelsTableID,
                        principalTable: "WheelsTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    WheelsTableID = table.Column<int>(type: "INTEGER", nullable: false),
                    Diameter = table.Column<float>(type: "REAL", nullable: false),
                    BoltCircle = table.Column<int>(type: "INTEGER", nullable: false),
                    Offset = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ats_WheelsTable_WheelsTableID",
                        column: x => x.WheelsTableID,
                        principalTable: "WheelsTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rial",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    WheelsTableID = table.Column<int>(type: "INTEGER", nullable: false),
                    Diameter = table.Column<float>(type: "REAL", nullable: false),
                    BoltCircle = table.Column<int>(type: "INTEGER", nullable: false),
                    Offset = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rial", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rial_WheelsTable_WheelsTableID",
                        column: x => x.WheelsTableID,
                        principalTable: "WheelsTable",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alutec_WheelsTableID",
                table: "Alutec",
                column: "WheelsTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Anzio_WheelsTableID",
                table: "Anzio",
                column: "WheelsTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Ats_WheelsTableID",
                table: "Ats",
                column: "WheelsTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Rial_WheelsTableID",
                table: "Rial",
                column: "WheelsTableID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alutec");

            migrationBuilder.DropTable(
                name: "Anzio");

            migrationBuilder.DropTable(
                name: "Ats");

            migrationBuilder.DropTable(
                name: "Rial");

            migrationBuilder.DropTable(
                name: "WheelsTable");
        }
    }
}
