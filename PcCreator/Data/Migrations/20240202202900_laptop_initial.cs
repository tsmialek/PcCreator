using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class laptop_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3bf8ad7b-2a56-4fc0-840d-325ca72a90ce", "425c3f36-a73d-47ea-8d1f-ff78af84ba38" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f95ef249-df69-40db-824e-111ceb9a888a", "644f4025-6d7e-487f-bd76-38c2693a5314" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bf8ad7b-2a56-4fc0-840d-325ca72a90ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f95ef249-df69-40db-824e-111ceb9a888a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "425c3f36-a73d-47ea-8d1f-ff78af84ba38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "644f4025-6d7e-487f-bd76-38c2693a5314");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3bf8ad7b-2a56-4fc0-840d-325ca72a90ce", "3bf8ad7b-2a56-4fc0-840d-325ca72a90ce", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f95ef249-df69-40db-824e-111ceb9a888a", "f95ef249-df69-40db-824e-111ceb9a888a", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "425c3f36-a73d-47ea-8d1f-ff78af84ba38", 0, "b7621d17-d404-4872-a35e-27306fa327ef", "tomek@wsei.pl", true, false, null, "TOMEK@WSEI.PL", "TOMEK", "AQAAAAEAACcQAAAAECICRT5wEHJejucenXUCuScSj0eoz8ePL5ZQ1tdFzau6SSh7Y0Ue9WKHi+VBCpf6sA==", null, false, "55a8f63d-c338-40ee-8744-a190a95b8d24", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "644f4025-6d7e-487f-bd76-38c2693a5314", 0, "38d48fbd-2fbf-42eb-a6f5-efe4fb0ebbd2", "kamil@wsei.pl", true, false, null, "KAMIL@WSEI.PL", "KAMIL", "AQAAAAEAACcQAAAAEIvaI4np5KWZqnn9VKmEac5PBf7MM/n0HF2IY9bROH3BmugD5qhHVEqa8S8XGjxtdA==", null, false, "5fb7f138-4b2a-4f0f-b09f-db89df136244", false, "kamil" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3bf8ad7b-2a56-4fc0-840d-325ca72a90ce", "425c3f36-a73d-47ea-8d1f-ff78af84ba38" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f95ef249-df69-40db-824e-111ceb9a888a", "644f4025-6d7e-487f-bd76-38c2693a5314" });
        }
    }
}
