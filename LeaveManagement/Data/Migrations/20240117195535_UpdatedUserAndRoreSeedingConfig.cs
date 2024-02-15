using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class UpdatedUserAndRoreSeedingConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1cbed6c-3b5f-5519-4563-41c21c941e1d",
                column: "ConcurrencyStamp",
                value: "a131fb6e-de09-4b84-81fe-61811a879223");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8cbed6a-3b5f-5519-8467-40c29c948e2c",
                column: "ConcurrencyStamp",
                value: "21732453-3fb0-4fad-a5d2-0e1a90eba652");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccac559a-254c-4873-9adb-7eefb498a20c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "296a74bb-9ca7-4d9c-84c6-6e38aee8ca64", true, "TEST@TESt.COM", "9b8491a8-212a-4c65-bc34-fb016b31dbe9", "test@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7cbed5a-2b5f-4419-8467-36c29c947e1c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "c5c57f52-8e42-4941-a627-42f6485242f6", true, "J3DELOSSANTOS@GMAIL.COM", "ae376f49-7e03-41b0-ad64-b416bbb33a06", "j3delossantos@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1cbed6c-3b5f-5519-4563-41c21c941e1d",
                column: "ConcurrencyStamp",
                value: "8da12487-dfbe-4e71-9f7b-4e86d931214f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8cbed6a-3b5f-5519-8467-40c29c948e2c",
                column: "ConcurrencyStamp",
                value: "cb133aff-2c7b-44d4-af98-61b3763adfb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccac559a-254c-4873-9adb-7eefb498a20c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "30fb7f3f-da8f-4050-9ede-ce82cbe77fd2", false, null, "d6ddbaed-6d51-4f4f-8e37-33a620668440", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7cbed5a-2b5f-4419-8467-36c29c947e1c",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "SecurityStamp", "UserName" },
                values: new object[] { "96d7d8fe-c8c9-4bdc-b9dc-b565cd8f38a7", false, null, "71b0c907-3208-4207-9911-617daed40398", null });
        }
    }
}
