﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201201072221_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.DrinkModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AlcContent")
                        .HasColumnType("float");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrinkType")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SizeInMl")
                        .HasColumnType("int");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DrinkModel");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8d04cfd8-6d6d-42f5-b286-90f79e5340dc"),
                            AlcContent = 5.5,
                            Company = "Paulaner Brauerei Gmbh",
                            CompanyLocation = "Germany",
                            Description = "Pale cloudy yellow with fine persistent carbonation; aromas of banana/sweet fruit, cloves andwheat with citrus and herbal/hoppy notes; dry, light to medium bodied, crisp, lightly bitter and smooth on the palate, flavours of spice, light malt, wheat and banana, with notes of citrus, yeast and candied fruit on the clean refreshing finish.",
                            DrinkType = 1,
                            Image = "Resources/Images/paulaner-hefe-weisbier.jpeg",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Paulaner",
                            Price = 2.9500000000000002,
                            SizeInMl = 500,
                            Style = "Hefe-Weissbier"
                        },
                        new
                        {
                            Id = new Guid("2a71af5b-d6da-4aaf-8974-d2aed1de0078"),
                            AlcContent = 5.5,
                            Company = "Faxe",
                            CompanyLocation = "Denmark",
                            Description = "Amber colour; dried leaf/hop nose and with crisp, hoppy flavours; medium-bodied",
                            DrinkType = 1,
                            Image = "Resources/Images/faxe-premium-lager.jpeg",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Faxe Premium Lager",
                            Price = 2.2000000000000002,
                            SizeInMl = 500,
                            Style = "lager"
                        },
                        new
                        {
                            Id = new Guid("60923147-c85a-469e-bc19-fdc7e5ffb379"),
                            AlcContent = 8.5,
                            Company = "Relax",
                            CompanyLocation = "Mosel, Germany",
                            Description = "Light green straw colour; aromas of tangerine, peach, white spice and black slate, with light floral tones; off-dry, medium-plus bodied, with balanced citrus acidity and tangerine and peach flavours.",
                            DrinkType = 2,
                            Image = "Resources/Images/relax-riesling.jpeg",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Relax Riesling, Mosel",
                            Price = 12.9,
                            SizeInMl = 750,
                            Style = "Riesling"
                        },
                        new
                        {
                            Id = new Guid("209a7eea-8d2f-497c-9899-f324d93fc4bc"),
                            AlcContent = 14.0,
                            Company = "Compania Vitivinicola Tandem S",
                            CompanyLocation = "Navarra, Spain",
                            Description = "An elegant wine overflowing with ripe fruit flavours complemented by delicate balsamic and spicy notes. Layered with complexity, this is a powerful expression of its mountainous terroir.",
                            DrinkType = 2,
                            Image = "Resources/Images/Tandem-Winery-Ars-Nova-2014.jpeg",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tandem Winery Ars Nova 2014",
                            Price = 24.850000000000001,
                            SizeInMl = 750,
                            Style = "Cabernet Sauvignon/Merlot/Tempranillo"
                        },
                        new
                        {
                            Id = new Guid("c4cb6345-f9e4-4e18-8194-645d575ef548"),
                            AlcContent = 0.0,
                            Company = "Smiling Tiger",
                            CompanyLocation = "Kitchener",
                            Description = "A caramelized boot-band camp; deep notes roll bones, leaving lasting rhythms and tones.  ",
                            DrinkType = 3,
                            Image = "Resources/Images/smiling-tiger-late.png",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dark caffee late",
                            Price = 4.2000000000000002,
                            SizeInMl = 120,
                            Style = "Late"
                        },
                        new
                        {
                            Id = new Guid("184211bc-d904-4b75-8268-e788b82dfeef"),
                            AlcContent = 9.0,
                            Company = "Ruedesheimer Schloss",
                            CompanyLocation = "Ruedesheim, Germany",
                            Description = "Deliciously brewed coffee with flambeed Asbach brandy and whipped cream",
                            DrinkType = 3,
                            Image = "Resources/Images/ruedesheimer-coffee-asbach.jpg",
                            LastUpdatedBy = 0,
                            LastUpdatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ruedesheimer Kafe",
                            Price = 12.44,
                            SizeInMl = 140,
                            Style = "Coffee with brandy"
                        });
                });

            modelBuilder.Entity("WebAPI.Models.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("LastUpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastUpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Usermobile")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEmail")
                        .IsUnique()
                        .HasFilter("[UserEmail] IS NOT NULL");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[UserName] IS NOT NULL");

                    b.ToTable("UserModels");
                });
#pragma warning restore 612, 618
        }
    }
}
