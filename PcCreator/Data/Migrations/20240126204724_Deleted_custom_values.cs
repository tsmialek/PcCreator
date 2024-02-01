using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Deleted_custom_values : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "946d41cd-2e18-4466-aaa7-441ff313751b", "9215815e-ec78-4e65-bdcd-bb3484846a3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777", "a5a67f45-7676-4d4e-8dde-349d699bfd15" });

            migrationBuilder.DeleteData(
                table: "Pcs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pcs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "946d41cd-2e18-4466-aaa7-441ff313751b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9215815e-ec78-4e65-bdcd-bb3484846a3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5a67f45-7676-4d4e-8dde-349d699bfd15");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777", "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "946d41cd-2e18-4466-aaa7-441ff313751b", "946d41cd-2e18-4466-aaa7-441ff313751b", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9215815e-ec78-4e65-bdcd-bb3484846a3d", 0, "fc0c037c-84e5-4778-a255-f15cf8a8c158", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEI2dU+TB8O+om3BzSbaJedJklL8CkydN4sU85eIFVmAKbtTn6oX8ZFXsBY3DKztTGA==", null, false, "a60c78de-5e21-406e-a632-95ffbd16c950", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5a67f45-7676-4d4e-8dde-349d699bfd15", 0, "2aba5c61-02d1-4d4b-8e52-a42ed59e9b64", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEK5UfAJDt73PnxgLvqqKK5dN03LoLe5RDepED7aXhe+XpmXl4Qx7qrxn9kz1V3y7iw==", null, false, "b63f28d9-4d58-499e-8310-a1297c0fcb5f", false, "kamil" });

            migrationBuilder.InsertData(
                table: "Pcs",
                columns: new[] { "Id", "Created", "Disk", "DiskType", "GPU", "Manufacturer", "Name", "Processor", "production_date", "RAM" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1TB", "HDD", "Nvidia 1050", "Dell", "Pc1", "Intel i5", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "8GB" });

            migrationBuilder.InsertData(
                table: "Pcs",
                columns: new[] { "Id", "Created", "Disk", "DiskType", "GPU", "Manufacturer", "Name", "Processor", "production_date", "RAM" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1TB", "HDD", "Nvidia 1060", "Dell", "Pc2", "Intel i7", new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "16GB" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "946d41cd-2e18-4466-aaa7-441ff313751b", "9215815e-ec78-4e65-bdcd-bb3484846a3d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777", "a5a67f45-7676-4d4e-8dde-349d699bfd15" });
        }
    }
}
