using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class CpuEntity_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "249f06e4-10de-4097-9ce1-08a819ff4c76", "38d1f2e1-c57e-48cd-8a4f-f10b6d64433b" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "184f15a7-f34f-4e81-bf6e-796d89982e08", "747129b4-2a07-4631-981f-20f150d996df" });
        }
    }
}
