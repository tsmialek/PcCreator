using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class GpuEntity_Fix_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Processor",
                table: "Pcs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a3c8947b-caf2-4b00-ad9a-b0d56128eac6", "a3c8947b-caf2-4b00-ad9a-b0d56128eac6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d84612c9-083d-437d-ba77-98e241e4513f", "d84612c9-083d-437d-ba77-98e241e4513f", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "06c2c3a2-8c6f-4c33-b068-a195558cbc1d", 0, "7d2eb03e-a511-438f-88df-3bd1198ec333", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEHjLdI2K/7HoVVXnUvd8KERxju9+b/6WYR+Ms3OIlidknUPFmPLWVmScvKtxuwWccA==", null, false, "682a00fd-c878-429a-aa44-c3e8d090976a", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "64c9fde1-3580-412a-9b0b-47477e4c2fb7", 0, "a6f4bc91-53e2-43f9-9207-aefb2a7aec44", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEBABC4J0fq7v2LAxkCeQ78VHDiqC8CCq+tvDs1tHu6E1w0kvoRtByV4Lp3KRIeygsA==", null, false, "6bc5afea-cb38-47cb-bf5d-f5f035df4371", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d84612c9-083d-437d-ba77-98e241e4513f", "06c2c3a2-8c6f-4c33-b068-a195558cbc1d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a3c8947b-caf2-4b00-ad9a-b0d56128eac6", "64c9fde1-3580-412a-9b0b-47477e4c2fb7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d84612c9-083d-437d-ba77-98e241e4513f", "06c2c3a2-8c6f-4c33-b068-a195558cbc1d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a3c8947b-caf2-4b00-ad9a-b0d56128eac6", "64c9fde1-3580-412a-9b0b-47477e4c2fb7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3c8947b-caf2-4b00-ad9a-b0d56128eac6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d84612c9-083d-437d-ba77-98e241e4513f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06c2c3a2-8c6f-4c33-b068-a195558cbc1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64c9fde1-3580-412a-9b0b-47477e4c2fb7");

            migrationBuilder.AddColumn<string>(
                name: "Processor",
                table: "Pcs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
    }
}
