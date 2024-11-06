using Microsoft.EntityFrameworkCore.Migrations;

namespace TruckData.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompaniesStocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: false),
                    CompanyPassword = table.Column<string>(nullable: false),
                    CompanyNumber = table.Column<string>(nullable: false),
                    MainAdress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesStocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DriverPassword = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfStock = table.Column<string>(nullable: false),
                    Stock = table.Column<string>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    FromAdress = table.Column<string>(nullable: false),
                    ToAdress = table.Column<string>(nullable: false),
                    PickupDate = table.Column<string>(nullable: false),
                    DeliveryDate = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrucksCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TruckCompanyName = table.Column<string>(nullable: false),
                    TruckCompanyPassword = table.Column<string>(nullable: false),
                    MainTruckAdress = table.Column<string>(nullable: false),
                    TruckCompanyNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrucksCompanies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    LiscenceNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesStocks_Shipments",
                columns: table => new
                {
                    CompanyStock_Id = table.Column<int>(nullable: false),
                    Shipment_Id = table.Column<int>(nullable: false),
                    CompanyStokId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesStocks_Shipments", x => new { x.Shipment_Id, x.CompanyStock_Id });
                    table.ForeignKey(
                        name: "FK_CompaniesStocks_Shipments_CompaniesStocks_CompanyStokId",
                        column: x => x.CompanyStokId,
                        principalTable: "CompaniesStocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompaniesStocks_Shipments_Shipments_Shipment_Id",
                        column: x => x.Shipment_Id,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckCompanies_Drivers",
                columns: table => new
                {
                    TruckCompany_Id = table.Column<int>(nullable: false),
                    Driver_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckCompanies_Drivers", x => new { x.Driver_Id, x.TruckCompany_Id });
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Drivers_Drivers_Driver_Id",
                        column: x => x.Driver_Id,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Drivers_TrucksCompanies_TruckCompany_Id",
                        column: x => x.TruckCompany_Id,
                        principalTable: "TrucksCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckCompanies_Shipments",
                columns: table => new
                {
                    TruckCompany_Id = table.Column<int>(nullable: false),
                    Shipment_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckCompanies_Shipments", x => new { x.Shipment_Id, x.TruckCompany_Id });
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Shipments_Shipments_Shipment_Id",
                        column: x => x.Shipment_Id,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Shipments_TrucksCompanies_TruckCompany_Id",
                        column: x => x.TruckCompany_Id,
                        principalTable: "TrucksCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TruckCompanies_Vehicles",
                columns: table => new
                {
                    TruckCompany_Id = table.Column<int>(nullable: false),
                    Vehicle_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckCompanies_Vehicles", x => new { x.Vehicle_Id, x.TruckCompany_Id });
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Vehicles_TrucksCompanies_TruckCompany_Id",
                        column: x => x.TruckCompany_Id,
                        principalTable: "TrucksCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TruckCompanies_Vehicles_Vehicles_Vehicle_Id",
                        column: x => x.Vehicle_Id,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesStocks_Shipments_CompanyStokId",
                table: "CompaniesStocks_Shipments",
                column: "CompanyStokId");

            migrationBuilder.CreateIndex(
                name: "IX_TruckCompanies_Drivers_TruckCompany_Id",
                table: "TruckCompanies_Drivers",
                column: "TruckCompany_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TruckCompanies_Shipments_TruckCompany_Id",
                table: "TruckCompanies_Shipments",
                column: "TruckCompany_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TruckCompanies_Vehicles_TruckCompany_Id",
                table: "TruckCompanies_Vehicles",
                column: "TruckCompany_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompaniesStocks_Shipments");

            migrationBuilder.DropTable(
                name: "TruckCompanies_Drivers");

            migrationBuilder.DropTable(
                name: "TruckCompanies_Shipments");

            migrationBuilder.DropTable(
                name: "TruckCompanies_Vehicles");

            migrationBuilder.DropTable(
                name: "CompaniesStocks");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "TrucksCompanies");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
