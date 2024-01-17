﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(TweetContext))]
    partial class TweetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Model.Tweet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tweetcontext")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tweets");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d0a20312-533f-4c7d-88ce-92578ce71b1d"),
                            Category = "Economy",
                            Date = new DateTime(2023, 11, 17, 18, 9, 29, 936, DateTimeKind.Local).AddTicks(8234),
                            ImagePath = "india.jpg",
                            Title = "Indian GDP",
                            Tweetcontext = "Indian will be 3rd Largest in terms of nominal GDP aroung 2028"
                        },
                        new
                        {
                            Id = new Guid("11d3d49b-4c7d-4f94-8669-4b9e5f821778"),
                            Category = "Geopilitics",
                            Date = new DateTime(2023, 9, 17, 18, 9, 29, 936, DateTimeKind.Local).AddTicks(8257),
                            ImagePath = "S_Jaisankar.jpg",
                            Title = "Indian Forign Policy",
                            Tweetcontext = "Indian foriegn minister S. Jaisankar build Indian Stature to global platform, ensuring Indian soft power."
                        },
                        new
                        {
                            Id = new Guid("32758eed-8e83-4872-a872-0e9a2bdc08f1"),
                            Category = "Sports",
                            Date = new DateTime(2024, 1, 17, 16, 9, 29, 936, DateTimeKind.Local).AddTicks(8260),
                            ImagePath = "IPL.jpg",
                            Title = "Indian Cricket",
                            Tweetcontext = "The IPL is the most-popular cricket league in the world; in 2014, it was ranked sixth by average attendance among all sports leagues.In 2010, the IPL became the first sporting event to be broadcast live on YouTube.Many domestic cricket and other sport's league started in India inspiring from the huge success of the IPL.The brand value of the league in 2022 was ₹90,038 crore (US$11 billion)."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
