using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiTaG_API.Migrations
{
    /// <inheritdoc />
    public partial class UpdatingAnimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Identifier = table.Column<string>(type: "varchar(5)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Id_Race = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    BirthWeight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    CurrentWeight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Id_Mother = table.Column<int>(type: "int", nullable: true),
                    Id_Father = table.Column<int>(type: "int", nullable: true),
                    Id_status = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastUpdate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Animals_Id_Father",
                        column: x => x.Id_Father,
                        principalTable: "Animals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Animals_Animals_Id_Mother",
                        column: x => x.Id_Mother,
                        principalTable: "Animals",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Id_Father",
                table: "Animals",
                column: "Id_Father");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Id_Mother",
                table: "Animals",
                column: "Id_Mother");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
