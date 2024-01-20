using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.TweetMigrationScript
{
    /// <inheritdoc />
    public partial class TweetDBAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tweets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tweetcontext = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "Id", "Category", "Date", "ImagePath", "Title", "Tweetcontext" },
                values: new object[,]
                {
                    { new Guid("094f926d-ad74-4141-8bb1-93c2771115b9"), "Economy", new DateTime(2023, 11, 19, 19, 32, 47, 165, DateTimeKind.Local).AddTicks(6438), "india.jpg", "Indian GDP", "Indian will be 3rd Largest in terms of nominal GDP aroung 2028" },
                    { new Guid("e6597ae5-949f-4d80-93fb-91bc0e3f0097"), "Geopilitics", new DateTime(2023, 9, 19, 19, 32, 47, 165, DateTimeKind.Local).AddTicks(6456), "S_Jaisankar.jpg", "Indian Forign Policy", "Indian foriegn minister S. Jaisankar build Indian Stature to global platform, ensuring Indian soft power." },
                    { new Guid("f9d9b9a2-262c-4702-8221-24e0457ec153"), "Sports", new DateTime(2024, 1, 19, 17, 32, 47, 165, DateTimeKind.Local).AddTicks(6458), "IPL.jpg", "Indian Cricket", "The IPL is the most-popular cricket league in the world; in 2014, it was ranked sixth by average attendance among all sports leagues.In 2010, the IPL became the first sporting event to be broadcast live on YouTube.Many domestic cricket and other sport's league started in India inspiring from the huge success of the IPL.The brand value of the league in 2022 was ₹90,038 crore (US$11 billion)." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tweets");
        }
    }
}
