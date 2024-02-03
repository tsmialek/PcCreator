using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class CpuEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b61dbd28-4da9-4ea4-8960-4e4a765a5a95", "052c34f3-5577-412a-9855-ca87049f16b0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a35133c0-02f2-437e-9e29-2be7a759bb56", "cafb1227-b048-4c3a-a6c8-8618236e7e36" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a35133c0-02f2-437e-9e29-2be7a759bb56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b61dbd28-4da9-4ea4-8960-4e4a765a5a95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "052c34f3-5577-412a-9855-ca87049f16b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cafb1227-b048-4c3a-a6c8-8618236e7e36");

            migrationBuilder.AddColumn<int>(
                name: "CpuId",
                table: "Pcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Cores = table.Column<int>(type: "INTEGER", nullable: false),
                    Threads = table.Column<int>(type: "INTEGER", nullable: false),
                    Frequency = table.Column<float>(type: "REAL", nullable: false),
                    TurboFrequency = table.Column<float>(type: "REAL", nullable: true),
                    L3Cache = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "184f15a7-f34f-4e81-bf6e-796d89982e08", "184f15a7-f34f-4e81-bf6e-796d89982e08", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "249f06e4-10de-4097-9ce1-08a819ff4c76", "249f06e4-10de-4097-9ce1-08a819ff4c76", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "38d1f2e1-c57e-48cd-8a4f-f10b6d64433b", 0, "0c61fdd5-434c-453e-a1e0-3df9d343dfc8", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAECEFB23aGirZI8+vAhFb8XU/XIyzMKRTt4iwMtJjD0pAbz87vjZopQ6OzL3na+UJSw==", null, false, "838f231f-efeb-4d68-9683-647d5c9be379", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "747129b4-2a07-4631-981f-20f150d996df", 0, "4b15808f-59e9-42fd-8689-1c4df7b0fdfe", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEMGFy0TrgEmx14Fl8uPzus5f/BDCSfRdxsu1Zs65/+CZe1ba/XXfzOuUTzgVJdVhEg==", null, false, "b454f43a-3676-4de9-bcce-6f46255bfd87", false, "kamil" });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 1, 4, 3.4f, 6, "Intel i5 8600k", 8, 4.2f });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 2, 6, 3.2f, 12, "Intel i7 8700", 12, 4.6f });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 3, 8, 3.6f, 16, "Intel i9", 16, 5f });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "249f06e4-10de-4097-9ce1-08a819ff4c76", "38d1f2e1-c57e-48cd-8a4f-f10b6d64433b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "184f15a7-f34f-4e81-bf6e-796d89982e08", "747129b4-2a07-4631-981f-20f150d996df" });

            migrationBuilder.CreateIndex(
                name: "IX_Pcs_CpuId",
                table: "Pcs",
                column: "CpuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pcs_Cpus_CpuId",
                table: "Pcs",
                column: "CpuId",
                principalTable: "Cpus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pcs_Cpus_CpuId",
                table: "Pcs");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropIndex(
                name: "IX_Pcs_CpuId",
                table: "Pcs");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "249f06e4-10de-4097-9ce1-08a819ff4c76", "38d1f2e1-c57e-48cd-8a4f-f10b6d64433b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "184f15a7-f34f-4e81-bf6e-796d89982e08", "747129b4-2a07-4631-981f-20f150d996df" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "184f15a7-f34f-4e81-bf6e-796d89982e08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "249f06e4-10de-4097-9ce1-08a819ff4c76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38d1f2e1-c57e-48cd-8a4f-f10b6d64433b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "747129b4-2a07-4631-981f-20f150d996df");

            migrationBuilder.DropColumn(
                name: "CpuId",
                table: "Pcs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a35133c0-02f2-437e-9e29-2be7a759bb56", "a35133c0-02f2-437e-9e29-2be7a759bb56", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b61dbd28-4da9-4ea4-8960-4e4a765a5a95", "b61dbd28-4da9-4ea4-8960-4e4a765a5a95", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "052c34f3-5577-412a-9855-ca87049f16b0", 0, "35c8ebf7-1ee4-47b7-aa08-c0bb4f019af9", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEO7+s9y0KXr1UxEXgXJewWq9YbZnqEqkJ5nGmb/XMTbidaWMGo0lMVuAa2dDsh/rBw==", null, false, "0d28108a-61a3-4884-86c1-76614c534d96", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cafb1227-b048-4c3a-a6c8-8618236e7e36", 0, "a66f6e9d-053c-4e58-bcc6-ce0ad82e1cc6", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEDUWyYkChUwNfLnCiZTrEthv9wCVHWqVEyQXXSSULq9QYccRauSd32y2CNJp0EAumg==", null, false, "5688ff1d-81b5-413b-938e-c803d8c30063", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b61dbd28-4da9-4ea4-8960-4e4a765a5a95", "052c34f3-5577-412a-9855-ca87049f16b0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a35133c0-02f2-437e-9e29-2be7a759bb56", "cafb1227-b048-4c3a-a6c8-8618236e7e36" });
        }
    }
}
