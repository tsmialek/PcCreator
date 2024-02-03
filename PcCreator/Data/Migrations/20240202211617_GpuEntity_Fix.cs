using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class GpuEntity_Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "236824f8-6460-455b-8a30-5abff85a3145", "236824f8-6460-455b-8a30-5abff85a3145", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e888ab63-1637-465e-ba85-23d0a5a611c7", "e888ab63-1637-465e-ba85-23d0a5a611c7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "61d13172-f4ba-4eff-8c8a-b2645c474387", 0, "ab6ed0be-61a6-4dcd-a121-2ca7c500ec18", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEMPHkHCt+OoGxcQTmMKNKjPG/nHtulBjPjtU2gSy4qb/DELr7WUfeGYTwCl8ayXfMw==", null, false, "4780d050-e8d4-4f92-9011-33497437a21c", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b54a429c-1aec-4c8a-b3a0-2a137b27392e", 0, "cc2957f2-2fd3-4829-b95d-471195c5822c", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEHH1I/UZepT7xgZbz7GNq5ARVQCn0gtkPMdnch/VOOVWWg8xgXDVeD81SbwQ/WyJIA==", null, false, "9f0e441c-2ce4-4af5-9b12-247220424fc7", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e888ab63-1637-465e-ba85-23d0a5a611c7", "61d13172-f4ba-4eff-8c8a-b2645c474387" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "236824f8-6460-455b-8a30-5abff85a3145", "b54a429c-1aec-4c8a-b3a0-2a137b27392e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e888ab63-1637-465e-ba85-23d0a5a611c7", "61d13172-f4ba-4eff-8c8a-b2645c474387" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "236824f8-6460-455b-8a30-5abff85a3145", "b54a429c-1aec-4c8a-b3a0-2a137b27392e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "236824f8-6460-455b-8a30-5abff85a3145");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e888ab63-1637-465e-ba85-23d0a5a611c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d13172-f4ba-4eff-8c8a-b2645c474387");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b54a429c-1aec-4c8a-b3a0-2a137b27392e");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7a84029f-5da2-4906-8300-bae978c2a071", "59422f8f-14bb-45b7-b912-91f6432a7b43" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2105f6d0-50d7-40ec-9a83-2a57aabdc137", "c3d6c57e-7415-499a-b50c-965a295a38b8" });
        }
    }
}
