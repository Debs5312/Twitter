using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistance.Migrations
{
    /// <inheritdoc />
    public partial class TweetDBCreation : Migration
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
                    { new Guid("11d3d49b-4c7d-4f94-8669-4b9e5f821778"), "Geopilitics", new DateTime(2023, 9, 17, 18, 9, 29, 936, DateTimeKind.Local).AddTicks(8257), "S_Jaisankar.jpg", "Indian Forign Policy", "Indian foriegn minister S. Jaisankar build Indian Stature to global platform, ensuring Indian soft power." },
                    { new Guid("32758eed-8e83-4872-a872-0e9a2bdc08f1"), "Sports", new DateTime(2024, 1, 17, 16, 9, 29, 936, DateTimeKind.Local).AddTicks(8260), "IPL.jpg", "Indian Cricket", "The IPL is the most-popular cricket league in the world; in 2014, it was ranked sixth by average attendance among all sports leagues.In 2010, the IPL became the first sporting event to be broadcast live on YouTube.Many domestic cricket and other sport's league started in India inspiring from the huge success of the IPL.The brand value of the league in 2022 was ₹90,038 crore (US$11 billion)." },
                    { new Guid("d0a20312-533f-4c7d-88ce-92578ce71b1d"), "Economy", new DateTime(2023, 11, 17, 18, 9, 29, 936, DateTimeKind.Local).AddTicks(8234), "india.jpg", "Indian GDP", "Indian will be 3rd Largest in terms of nominal GDP aroung 2028" }
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
