using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.TweetUserMigrationScript
{
    /// <inheritdoc />
    public partial class AddPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ea933be-684b-4713-9e71-86ed07df4e86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a5f7209-21c7-4756-8579-044ae6fc8746");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc95ee50-a8d9-484a-be9d-a445e8fcdcc7");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "802b7d18-1d13-476a-80b9-d754f3a77c3e", 0, null, "d98030c1-9191-4119-97e7-5feca69ac564", "Deb", "debojyotisaha5@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEHiExwHxpGoGlja3hlHW3iDsCMD+chFaKqLQ/6L62DOEiUiG7wkFwGnLeMGiJ+HRxQ==", null, false, "d5bc364d-c3ab-43ab-a401-815deecbb1e8", false, "deb" },
                    { "904b8c13-e8a1-456e-a390-b6581f5f9215", 0, null, "e7f592f7-6bf9-4e2e-8015-2286cf6ccc11", "Debojyoti", "debs5312@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEOOFG77MWa7/FbfmQmIWaGuUxtX54CzBPisJisNq/13Ccxp9qMEPK3KxzZTtFo9MAw==", null, false, "96499f85-0ff4-405e-828c-086666593ac0", false, "debs5312" },
                    { "f43d14e3-e7f2-4ce3-9700-6b834f540476", 0, null, "b23b5894-d790-4bae-a22e-4a20f41da3ca", "Jaya", "jayasaha69@gmail.com", false, false, null, null, null, "AQAAAAIAAYagAAAAEH8yJMkcLTKDohmQORjyjvtNNLmE1WdrGfTJhNpkiZXJ7j7revfgkUdYWUgVytzXqw==", null, false, "d86ee758-40c3-46fb-ba21-c08ea645b2fa", false, "jaya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "802b7d18-1d13-476a-80b9-d754f3a77c3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "904b8c13-e8a1-456e-a390-b6581f5f9215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f43d14e3-e7f2-4ce3-9700-6b834f540476");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0ea933be-684b-4713-9e71-86ed07df4e86", 0, null, "ae76b9ac-b7d9-4393-945a-8fee414a55df", "Debojyoti", "debs5312@gmail.com", false, false, null, null, null, null, null, false, "5335cf0f-df56-448d-a6ff-55a22cc68c7d", false, "debs5312" },
                    { "8a5f7209-21c7-4756-8579-044ae6fc8746", 0, null, "02f5bb93-481b-454e-9d0e-0f33d258454d", "Jaya", "jayasaha69@gmail.com", false, false, null, null, null, null, null, false, "314db3f8-60f1-43d7-b2b9-283fb5b87296", false, "jaya" },
                    { "fc95ee50-a8d9-484a-be9d-a445e8fcdcc7", 0, null, "217b05e3-c1f3-456f-a19d-cef1dc1aeeb8", "Deb", "debojyotisaha5@gmail.com", false, false, null, null, null, null, null, false, "5131fe60-869b-49a3-9172-6110d66e2403", false, "deb" }
                });
        }
    }
}
