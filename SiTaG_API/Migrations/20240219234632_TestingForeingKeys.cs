using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiTaG_API.Migrations
{
    /// <inheritdoc />
    public partial class TestingForeingKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Application_Method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMethod", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Animal = table.Column<int>(type: "int", nullable: false),
                    Id_ServiceType = table.Column<int>(type: "int", nullable: false),
                    Id_Product = table.Column<int>(type: "int", nullable: false),
                    Application_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Dose = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Id_Application_Method = table.Column<int>(type: "int", nullable: false),
                    Observations = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatments_Animals_Id_Animal",
                        column: x => x.Id_Animal,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Treatments_ApplicationMethod_Id_Application_Method",
                        column: x => x.Id_Application_Method,
                        principalTable: "ApplicationMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Id_Animal",
                table: "Treatments",
                column: "Id_Animal");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Id_Application_Method",
                table: "Treatments",
                column: "Id_Application_Method");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "ApplicationMethod");
        }
    }
}
