﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

#nullable disable

namespace Persistance.TweetMigrationScript
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
                            Id = new Guid("094f926d-ad74-4141-8bb1-93c2771115b9"),
                            Category = "Economy",
                            Date = new DateTime(2023, 11, 19, 19, 32, 47, 165, DateTimeKind.Local).AddTicks(6438),
                            ImagePath = "india.jpg",
                            Title = "Indian GDP",
                            Tweetcontext = "Indian will be 3rd Largest in terms of nominal GDP aroung 2028"
                        },
                        new
                        {
                            Id = new Guid("e6597ae5-949f-4d80-93fb-91bc0e3f0097"),
                            Category = "Geopilitics",
                            Date = new DateTime(2023, 9, 19, 19, 32, 47, 165, DateTimeKind.Local).AddTicks(6456),
                            ImagePath = "S_Jaisankar.jpg",
                            Title = "Indian Forign Policy",
                            Tweetcontext = "Indian foriegn minister S. Jaisankar build Indian Stature to global platform, ensuring Indian soft power."
                        },
                        new
                        {
                            Id = new Guid("f9d9b9a2-262c-4702-8221-24e0457ec153"),
                            Category = "Sports",
                            Date = new DateTime(2024, 1, 19, 17, 32, 47, 165, DateTimeKind.Local).AddTicks(6458),
                            ImagePath = "IPL.jpg",
                            Title = "Indian Cricket",
                            Tweetcontext = "The IPL is the most-popular cricket league in the world; in 2014, it was ranked sixth by average attendance among all sports leagues.In 2010, the IPL became the first sporting event to be broadcast live on YouTube.Many domestic cricket and other sport's league started in India inspiring from the huge success of the IPL.The brand value of the league in 2022 was ₹90,038 crore (US$11 billion)."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}