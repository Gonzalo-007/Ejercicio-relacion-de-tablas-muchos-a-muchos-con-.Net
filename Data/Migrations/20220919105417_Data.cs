using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosConRoles.Data.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a7d9233f-8637-4d05-a455-40e163871778", "52d64cef-4b9c-4127-bda6-68eac381d45f", "Admin", "ADMIN" },
                    { "df56797b-2b7f-4612-ac4b-b80a69fec08b", "a3f851aa-4e1c-4187-a288-f5d295576672", "Vendedor", "VENDEDOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23ba38f3-6df9-4fa9-b1c1-18b992c9575d", 0, "3077d96f-6d23-49e6-8bc8-9ef649961171", "usuarioSinRol@hotmail.com", false, false, null, "USUARIOSINROL@HOTMAIL.COM", "USUARIOSINROL", null, null, false, "505debee-0c76-428f-9f74-b801c57868ab", false, "usuarioSinRol" },
                    { "6b848640-5f04-4e8c-b615-0237a09be276", 0, "1dc2dc80-44e6-4221-90d0-12c3f4865eff", "usuarioAdmin@hotmail.com", false, false, null, "USUARIOADMIN@HOTMAIL.COM", "USUARIOADMIN", null, null, false, "bbf54556-db15-44c8-829e-b33b020074e1", false, "usuarioAdmin" },
                    { "a02b2a9c-bd77-471e-a0e0-b8ffd9271073", 0, "91073f60-edbc-4ca1-8dce-3094409a34d2", "usuarioVendedor@hotmail.com", false, false, null, "USUARIOVENDEDOR@HOTMAIL.COM", "USUARIOVENDEDOR", null, null, false, "82c5b7b6-59ef-48e2-809f-356ff0454c1e", false, "usuarioVendedor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a7d9233f-8637-4d05-a455-40e163871778", "6b848640-5f04-4e8c-b615-0237a09be276" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "df56797b-2b7f-4612-ac4b-b80a69fec08b", "a02b2a9c-bd77-471e-a0e0-b8ffd9271073" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a7d9233f-8637-4d05-a455-40e163871778", "6b848640-5f04-4e8c-b615-0237a09be276" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "df56797b-2b7f-4612-ac4b-b80a69fec08b", "a02b2a9c-bd77-471e-a0e0-b8ffd9271073" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23ba38f3-6df9-4fa9-b1c1-18b992c9575d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7d9233f-8637-4d05-a455-40e163871778");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "df56797b-2b7f-4612-ac4b-b80a69fec08b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b848640-5f04-4e8c-b615-0237a09be276");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a02b2a9c-bd77-471e-a0e0-b8ffd9271073");
        }
    }
}
