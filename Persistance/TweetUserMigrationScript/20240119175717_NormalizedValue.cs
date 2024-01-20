using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.TweetUserMigrationScript
{
    /// <inheritdoc />
    public partial class NormalizedValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2384546d-8bf2-4e32-b932-abde1504c74e", 0, null, "e4a57fb8-0552-4323-8036-33b7a274307f", "Deb", "debojyotisaha5@gmail.com", false, false, null, "DEBOJYOTISAHA@GMAIL.COM", "DEB", "AQAAAAIAAYagAAAAECWkvP0lVCGZDG+owjuwqKpufR4JL/rAG4FV8tn2dwIvsdsCoerzfgto+CLW883P0Q==", null, false, "88d2b513-d282-44a1-bdb4-c8069a1bb602", false, "deb" },
                    { "2cf1b256-e5b1-4c93-96f3-61325a15017d", 0, null, "cf9d4c3f-db37-4e95-81b6-9d91d170caa9", "Debojyoti", "debs5312@gmail.com", false, false, null, "DEBS5312@GMAIL.COM", "DEBS5312", "AQAAAAIAAYagAAAAEAudIzvSIAeJw/tFa74zxJv4z05qj3Xx7s/TJ7sPuGxB5ZBIvtF2PoZmIVOrAp+81Q==", null, false, "dc3d159b-0754-49c0-9f4b-240ff60ea24d", false, "debs5312" },
                    { "7ab77141-44c9-4497-9abb-8173dffb9e11", 0, null, "d9703af9-213c-4bfa-a1ec-7c6639200a88", "Jaya", "jayasaha69@gmail.com", false, false, null, "JAYASAHA69@GMAIL.COM", "JAYA", "AQAAAAIAAYagAAAAEGDP1TstBqfuFiYnVHqdV/bfyUVGHslEqFilw058/7mqQ3SPl0PtBRA9jl2fLoGg2g==", null, false, "eb2315b1-c74d-4e51-9e4c-3324d92dc1fa", false, "jaya" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2384546d-8bf2-4e32-b932-abde1504c74e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cf1b256-e5b1-4c93-96f3-61325a15017d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ab77141-44c9-4497-9abb-8173dffb9e11");

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
    }
}
