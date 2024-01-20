using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.TweetUserMigrationScript
{
    /// <inheritdoc />
    public partial class UserAddedtoDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
