using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Processor = table.Column<string>(type: "TEXT", nullable: false),
                    RAM = table.Column<string>(type: "TEXT", nullable: false),
                    Disk = table.Column<string>(type: "TEXT", nullable: false),
                    DiskType = table.Column<string>(type: "TEXT", nullable: false),
                    GPU = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    production_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pcs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pcs",
                columns: new[] { "Id", "Disk", "DiskType", "GPU", "Manufacturer", "Name", "Processor", "production_date", "RAM" },
                values: new object[] { 1, "1TB", "HDD", "Nvidia 1050", "Dell", "Pc1", "Intel i5", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8GB" });

            migrationBuilder.InsertData(
                table: "Pcs",
                columns: new[] { "Id", "Disk", "DiskType", "GPU", "Manufacturer", "Name", "Processor", "production_date", "RAM" },
                values: new object[] { 2, "1TB", "HDD", "Nvidia 1060", "Dell", "Pc2", "Intel i7", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16GB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pcs");
        }
    }
}
