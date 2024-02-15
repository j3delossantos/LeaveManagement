using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class AddedUserAndRoreSeedingConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b1cbed6c-3b5f-5519-4563-41c21c941e1d", "8da12487-dfbe-4e71-9f7b-4e86d931214f", "user", "USER" },
                    { "f8cbed6a-3b5f-5519-8467-40c29c948e2c", "cb133aff-2c7b-44d4-af98-61b3763adfb7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ccac559a-254c-4873-9adb-7eefb498a20c", 0, "30fb7f3f-da8f-4050-9ede-ce82cbe77fd2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test@test.com", false, "User", "User", false, null, "TEST@TESt.COM", null, "AQAAAAEAACcQAAAAEGqGLBIv/2FoCH2cS60g/DSbSz8PrjmdbeWiwvPeDSYJNPGE4WtPu9SkKCrewp1T7Q==", null, false, "d6ddbaed-6d51-4f4f-8e37-33a620668440", null, false, null },
                    { "f7cbed5a-2b5f-4419-8467-36c29c947e1c", 0, "96d7d8fe-c8c9-4bdc-b9dc-b565cd8f38a7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "j3delossantos@gmail.com", false, "Super", "Admin", false, null, "J3DELOSSANTOS@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGqGLBIv/2FoCH2cS60g/DSbSz8PrjmdbeWiwvPeDSYJNPGE4WtPu9SkKCrewp1T7Q==", null, false, "71b0c907-3208-4207-9911-617daed40398", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b1cbed6c-3b5f-5519-4563-41c21c941e1d", "ccac559a-254c-4873-9adb-7eefb498a20c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f8cbed6a-3b5f-5519-8467-40c29c948e2c", "f7cbed5a-2b5f-4419-8467-36c29c947e1c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1cbed6c-3b5f-5519-4563-41c21c941e1d", "ccac559a-254c-4873-9adb-7eefb498a20c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f8cbed6a-3b5f-5519-8467-40c29c948e2c", "f7cbed5a-2b5f-4419-8467-36c29c947e1c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1cbed6c-3b5f-5519-4563-41c21c941e1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8cbed6a-3b5f-5519-8467-40c29c948e2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccac559a-254c-4873-9adb-7eefb498a20c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7cbed5a-2b5f-4419-8467-36c29c947e1c");
        }
    }
}
