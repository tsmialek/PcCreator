using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class GpuEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9c736332-dfa9-42ab-8ac4-00967a16c836", "1e84d9d3-161c-4e9a-9694-55f5dbba0fea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e880fa08-e241-43fa-8a3f-8a0ecfa86831", "d9b784d3-5c6d-44f7-99a5-e92c7b9b4fe7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c736332-dfa9-42ab-8ac4-00967a16c836");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e880fa08-e241-43fa-8a3f-8a0ecfa86831");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e84d9d3-161c-4e9a-9694-55f5dbba0fea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9b784d3-5c6d-44f7-99a5-e92c7b9b4fe7");

            migrationBuilder.DropColumn(
                name: "GPU",
                table: "Pcs");

            migrationBuilder.AddColumn<int>(
                name: "GpuId",
                table: "Pcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Gpus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    VRam = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gpus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2105f6d0-50d7-40ec-9a83-2a57aabdc137", "2105f6d0-50d7-40ec-9a83-2a57aabdc137", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7a84029f-5da2-4906-8300-bae978c2a071", "7a84029f-5da2-4906-8300-bae978c2a071", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "59422f8f-14bb-45b7-b912-91f6432a7b43", 0, "4cd2646e-0dac-4e52-bde3-232b98ef86b4", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEPS6X2Lfc+TH0m7/7D0hJNbPQHDT5cDokb9QbzZe2BiL3KcGQJvRS3XuF0iQp3/l3w==", null, false, "3a92b370-3d14-4223-95fd-8cff9d8eb403", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c3d6c57e-7415-499a-b50c-965a295a38b8", 0, "c080826e-d4e5-4662-8560-fb65cd9fc7c7", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEJI7krrD+IB0xxg/kxAiN0eENJ6xOVmajeAEtSRhiEkJ5kUc9piq/XyszJwZ4t+7Tw==", null, false, "bb6afc1c-bab4-4982-a2cd-abc437b6274f", false, "kamil" });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 1, "Nvidia GTX 1050", "Nvidia", 2 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 2, "Nvidia GTX 1060 GB", "Nvidia", 6 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 3, "Nvidia GTX 1070", "Nvidia", 8 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 4, "Nvidia GTX 1080", "Nvidia", 8 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 5, "Nvidia GTX 2050", "Nvidia", 4 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 6, "Nvidia GTX 2070", "Nvidia", 8 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a84029f-5da2-4906-8300-bae978c2a071", "59422f8f-14bb-45b7-b912-91f6432a7b43" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2105f6d0-50d7-40ec-9a83-2a57aabdc137", "c3d6c57e-7415-499a-b50c-965a295a38b8" });

            migrationBuilder.CreateIndex(
                name: "IX_Pcs_GpuId",
                table: "Pcs",
                column: "GpuId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pcs_Gpus_GpuId",
                table: "Pcs",
                column: "GpuId",
                principalTable: "Gpus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pcs_Gpus_GpuId",
                table: "Pcs");

            migrationBuilder.DropTable(
                name: "Gpus");

            migrationBuilder.DropIndex(
                name: "IX_Pcs_GpuId",
                table: "Pcs");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7a84029f-5da2-4906-8300-bae978c2a071", "59422f8f-14bb-45b7-b912-91f6432a7b43" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2105f6d0-50d7-40ec-9a83-2a57aabdc137", "c3d6c57e-7415-499a-b50c-965a295a38b8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2105f6d0-50d7-40ec-9a83-2a57aabdc137");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a84029f-5da2-4906-8300-bae978c2a071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59422f8f-14bb-45b7-b912-91f6432a7b43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3d6c57e-7415-499a-b50c-965a295a38b8");

            migrationBuilder.DropColumn(
                name: "GpuId",
                table: "Pcs");

            migrationBuilder.AddColumn<string>(
                name: "GPU",
                table: "Pcs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9c736332-dfa9-42ab-8ac4-00967a16c836", "9c736332-dfa9-42ab-8ac4-00967a16c836", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e880fa08-e241-43fa-8a3f-8a0ecfa86831", "e880fa08-e241-43fa-8a3f-8a0ecfa86831", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e84d9d3-161c-4e9a-9694-55f5dbba0fea", 0, "a02e14a0-0212-487b-9ca6-f98a040d88cd", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEJCrFQxnN1rtq3f9zeNVs/JvJ7vSNDrBNS0w/Kf4BxHIsYpTAadTwUJE9jZaCPAvRw==", null, false, "efaeafe7-fef5-454f-9a31-2c776811453e", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d9b784d3-5c6d-44f7-99a5-e92c7b9b4fe7", 0, "45f70cb8-2cb0-404a-9719-70575d9572a0", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEC02PVFNCWbhW5U76df2ErpEnIUIugw3v6ZSOIcylbE4B6nupb2tEKVZd5Fs9AzkGw==", null, false, "ec3d6452-ec49-45ce-a1f7-8dc08227ea59", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9c736332-dfa9-42ab-8ac4-00967a16c836", "1e84d9d3-161c-4e9a-9694-55f5dbba0fea" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e880fa08-e241-43fa-8a3f-8a0ecfa86831", "d9b784d3-5c6d-44f7-99a5-e92c7b9b4fe7" });
        }
    }
}
