using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Identity_Normalized_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5fdd5fd3-23e8-474e-97eb-95b7bc54db24", "110b79f2-9d07-4922-9e1b-955b91b7d2d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95b4e55d-8d50-44f4-9ae7-883d92401c9d", "6812b886-f328-4a16-ba3a-6d59ef411273" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fdd5fd3-23e8-474e-97eb-95b7bc54db24");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95b4e55d-8d50-44f4-9ae7-883d92401c9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "110b79f2-9d07-4922-9e1b-955b91b7d2d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6812b886-f328-4a16-ba3a-6d59ef411273");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "946d41cd-2e18-4466-aaa7-441ff313751b", "9215815e-ec78-4e65-bdcd-bb3484846a3d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3ac1fd0f-aa90-40a2-aafa-7f126ee1a777", "a5a67f45-7676-4d4e-8dde-349d699bfd15" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "5fdd5fd3-23e8-474e-97eb-95b7bc54db24", "5fdd5fd3-23e8-474e-97eb-95b7bc54db24", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "95b4e55d-8d50-44f4-9ae7-883d92401c9d", "95b4e55d-8d50-44f4-9ae7-883d92401c9d", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "110b79f2-9d07-4922-9e1b-955b91b7d2d5", 0, "3e8c05bd-b4b0-41d0-8eca-488c084b5626", "tomek@wsei.pl", true, false, null, null, "TOMEK", "AQAAAAEAACcQAAAAEJP5bkmhrdqBiz6jvgMBi5QzlnMwsX20zJNdfXHnO3OO2slaATQQz2319SMkMO2h0w==", null, false, "57dbf8ca-da31-4766-8365-d9f31576d525", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6812b886-f328-4a16-ba3a-6d59ef411273", 0, "25e44052-1daf-44dd-a67f-2f44fd991a0e", "kamil@wsei.pl", true, false, null, null, "KAMIL", "AQAAAAEAACcQAAAAEGh99A1Z+M6JHjHSSGoB2/WO3EIPbHxhYGCPG7LPY/Z+eah/cmB2YcB850zoWEtyDQ==", null, false, "be75a30d-5687-4d07-8bf0-cc2112fd37f6", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5fdd5fd3-23e8-474e-97eb-95b7bc54db24", "110b79f2-9d07-4922-9e1b-955b91b7d2d5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "95b4e55d-8d50-44f4-9ae7-883d92401c9d", "6812b886-f328-4a16-ba3a-6d59ef411273" });
        }
    }
}
