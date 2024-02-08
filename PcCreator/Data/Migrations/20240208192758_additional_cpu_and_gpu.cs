using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class additional_cpu_and_gpu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3dc01775-675b-4801-8c8b-4625ce50e4f8", "3dc01775-675b-4801-8c8b-4625ce50e4f8", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bcfa132b-687f-43aa-bb68-dbda8d0241b0", "bcfa132b-687f-43aa-bb68-dbda8d0241b0", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00da8877-b95b-47d9-8b14-284fe5c6291a", 0, "db1b509a-b4df-41c6-b971-593e5081e47c", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAEHt9eyLDlLPL0yGT5tyLTvPRofkejRxw05nDHzmZPloQHpaHYHd9JzLPKFq50c0p4A==", null, false, "9e2ffc74-69c5-4d96-9fbc-48cf794ebf9a", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cecf57bd-b989-4534-9454-ae53ada19ec2", 0, "c0de9ebd-7862-4264-9004-9b49b3a1cfd1", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEJmjP8XLGiQpgRVeNmFe9r+QiQpun9kwyM45Tl21xezSugIvspzKIVia+bVJsZlRcw==", null, false, "42c0ada7-cb8b-457f-8ccd-873bb199da4f", false, "kamil" });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 4, 6, 3.4f, 16, "AMD Ryzen 5 2600", 12, 3.9f });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 5, 8, 3.2f, 16, "AMD Ryzen 7 2700", 16, 4.1f });

            migrationBuilder.InsertData(
                table: "Cpus",
                columns: new[] { "Id", "Cores", "Frequency", "L3Cache", "Name", "Threads", "TurboFrequency" },
                values: new object[] { 6, 8, 3.7f, 16, "AMD Ryzen 7 2700x", 16, 4.3f });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 7, "Radeon RX 570", "Radeon", 4 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 8, "Radeon RX 580", "Radeon", 8 });

            migrationBuilder.InsertData(
                table: "Gpus",
                columns: new[] { "Id", "FullName", "Manufacturer", "VRam" },
                values: new object[] { 9, "Radeon RX 590", "Radeon", 8 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bcfa132b-687f-43aa-bb68-dbda8d0241b0", "00da8877-b95b-47d9-8b14-284fe5c6291a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3dc01775-675b-4801-8c8b-4625ce50e4f8", "cecf57bd-b989-4534-9454-ae53ada19ec2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bcfa132b-687f-43aa-bb68-dbda8d0241b0", "00da8877-b95b-47d9-8b14-284fe5c6291a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3dc01775-675b-4801-8c8b-4625ce50e4f8", "cecf57bd-b989-4534-9454-ae53ada19ec2" });

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cpus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gpus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3dc01775-675b-4801-8c8b-4625ce50e4f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcfa132b-687f-43aa-bb68-dbda8d0241b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00da8877-b95b-47d9-8b14-284fe5c6291a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cecf57bd-b989-4534-9454-ae53ada19ec2");

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
    }
}
