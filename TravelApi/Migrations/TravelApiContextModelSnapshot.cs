﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cons");

                    b.Property<string>("Name");

                    b.Property<string>("Pros");

                    b.Property<string>("Rating");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Cons = "Very Expensive",
                            Name = "New Zealand",
                            Pros = "Great for outdoor lovers!",
                            Rating = "5 Stars"
                        },
                        new
                        {
                            LocationId = 2,
                            Cons = "Rudeness",
                            Name = "France",
                            Pros = "Bread",
                            Rating = "4 Stars"
                        },
                        new
                        {
                            LocationId = 3,
                            Cons = "Might Get Kidnapped",
                            Name = "Somalia",
                            Pros = "Very Cheap",
                            Rating = "1 Star"
                        },
                        new
                        {
                            LocationId = 4,
                            Cons = "Endless Winter",
                            Name = "Antartica",
                            Pros = "Snow Angels",
                            Rating = "2 Stars"
                        });
                });

            modelBuilder.Entity("TravelApi.LocationReview", b =>
                {
                    b.Property<int>("LocationReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LocationId");

                    b.Property<int>("ReviewId");

                    b.HasKey("LocationReviewId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ReviewId");

                    b.ToTable("LocationReview");
                });

            modelBuilder.Entity("TravelApi.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<string>("UserName");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TravelApi.LocationReview", b =>
                {
                    b.HasOne("TravelApi.Location", "Location")
                        .WithMany("JoinEntries")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TravelApi.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
