using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiTaG_API.Migrations
{
    /// <inheritdoc />
    public partial class Sitag_test_10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_ApplicationMethod_Id_Application_Method",
                table: "Treatments");

            migrationBuilder.DropTable(
                name: "ApplicationMethod");

            migrationBuilder.DropColumn(
                name: "BirthWeight",
                table: "Animals");

            migrationBuilder.AddColumn<int>(
                name: "Id_Health_Status",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_Stage",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ApplicationMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Application_Method = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMethods", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BirthServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Service_Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthServices", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cattles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cattle_Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cattles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Division_Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HealthStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Health_Status = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthStatuses", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Lots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Lot_Name = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lot_Area = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lots", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Product_Type = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Service = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Stage_Name = table.Column<string>(type: "varchar(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Births",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Id_Animal = table.Column<int>(type: "int", nullable: false),
                    Expected_Birth_Date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Birth_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Service_Date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Id_Birth_Service = table.Column<int>(type: "int", nullable: false),
                    Birth_Weight = table.Column<decimal>(type: "decimal(65,30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Births", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Births_Animals_Id_Animal",
                        column: x => x.Id_Animal,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Births_BirthServices_Id_Birth_Service",
                        column: x => x.Id_Birth_Service,
                        principalTable: "BirthServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AnimalsxCattles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Animal_Id = table.Column<int>(type: "int", nullable: false),
                    Cattle_Id = table.Column<int>(type: "int", nullable: false),
                    Start_Date = table.Column<DateOnly>(type: "date", nullable: false),
                    End_Date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalsxCattles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalsxCattles_Animals_Animal_Id",
                        column: x => x.Animal_Id,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnimalsxCattles_Cattles_Cattle_Id",
                        column: x => x.Cattle_Id,
                        principalTable: "Cattles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CattlesxDivision",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cattle_Id = table.Column<int>(type: "int", nullable: false),
                    Division_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CattlesxDivision", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CattlesxDivision_Cattles_Cattle_Id",
                        column: x => x.Cattle_Id,
                        principalTable: "Cattles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CattlesxDivision_Divisions_Division_Id",
                        column: x => x.Division_Id,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DivisionxLots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Division_Id = table.Column<int>(type: "int", nullable: false),
                    Lot_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivisionxLots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DivisionxLots_Divisions_Division_Id",
                        column: x => x.Division_Id,
                        principalTable: "Divisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DivisionxLots_Lots_Lot_Id",
                        column: x => x.Lot_Id,
                        principalTable: "Lots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Product_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product_Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Product_Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Id_Product_Type = table.Column<int>(type: "int", nullable: false),
                    Product_Image = table.Column<string>(type: "text", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_Id_Product_Type",
                        column: x => x.Id_Product_Type,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Id_Product",
                table: "Treatments",
                column: "Id_Product");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_Id_ServiceType",
                table: "Treatments",
                column: "Id_ServiceType");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Id_Health_Status",
                table: "Animals",
                column: "Id_Health_Status");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_Id_Stage",
                table: "Animals",
                column: "Id_Stage");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsxCattles_Animal_Id",
                table: "AnimalsxCattles",
                column: "Animal_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalsxCattles_Cattle_Id",
                table: "AnimalsxCattles",
                column: "Cattle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Births_Id_Animal",
                table: "Births",
                column: "Id_Animal");

            migrationBuilder.CreateIndex(
                name: "IX_Births_Id_Birth_Service",
                table: "Births",
                column: "Id_Birth_Service");

            migrationBuilder.CreateIndex(
                name: "IX_CattlesxDivision_Cattle_Id",
                table: "CattlesxDivision",
                column: "Cattle_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CattlesxDivision_Division_Id",
                table: "CattlesxDivision",
                column: "Division_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DivisionxLots_Division_Id",
                table: "DivisionxLots",
                column: "Division_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DivisionxLots_Lot_Id",
                table: "DivisionxLots",
                column: "Lot_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id_Product_Type",
                table: "Products",
                column: "Id_Product_Type");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_HealthStatuses_Id_Health_Status",
                table: "Animals",
                column: "Id_Health_Status",
                principalTable: "HealthStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Stages_Id_Stage",
                table: "Animals",
                column: "Id_Stage",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_ApplicationMethods_Id_Application_Method",
                table: "Treatments",
                column: "Id_Application_Method",
                principalTable: "ApplicationMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_Products_Id_Product",
                table: "Treatments",
                column: "Id_Product",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_ServiceTypes_Id_ServiceType",
                table: "Treatments",
                column: "Id_ServiceType",
                principalTable: "ServiceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_HealthStatuses_Id_Health_Status",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Stages_Id_Stage",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_ApplicationMethods_Id_Application_Method",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_Products_Id_Product",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_ServiceTypes_Id_ServiceType",
                table: "Treatments");

            migrationBuilder.DropTable(
                name: "AnimalsxCattles");

            migrationBuilder.DropTable(
                name: "ApplicationMethods");

            migrationBuilder.DropTable(
                name: "Births");

            migrationBuilder.DropTable(
                name: "CattlesxDivision");

            migrationBuilder.DropTable(
                name: "DivisionxLots");

            migrationBuilder.DropTable(
                name: "HealthStatuses");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ServiceTypes");

            migrationBuilder.DropTable(
                name: "Stages");

            migrationBuilder.DropTable(
                name: "BirthServices");

            migrationBuilder.DropTable(
                name: "Cattles");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Lots");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_Id_Product",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_Id_ServiceType",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Animals_Id_Health_Status",
                table: "Animals");

            migrationBuilder.DropIndex(
                name: "IX_Animals_Id_Stage",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Id_Health_Status",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "Id_Stage",
                table: "Animals");

            migrationBuilder.AddColumn<decimal>(
                name: "BirthWeight",
                table: "Animals",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_ApplicationMethod_Id_Application_Method",
                table: "Treatments",
                column: "Id_Application_Method",
                principalTable: "ApplicationMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
