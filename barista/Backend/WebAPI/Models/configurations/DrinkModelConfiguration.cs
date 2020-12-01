using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAPI.Models.configurations
{
    public class DrinkModelConfiguration : IEntityTypeConfiguration<DrinkModel>
    {
        public void Configure(EntityTypeBuilder<DrinkModel> builder)
        {
            builder.ToTable("DrinkModel");
            builder.HasData
            (
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 1,
                    Name = "Paulaner",
                    Style = "Hefe-Weissbier",
                    SizeInMl = 500,
                    AlcContent = 5.5,
                    Price = 2.95,
                    Company = "Paulaner Brauerei Gmbh",
                    CompanyLocation = "Germany",
                    Description = "Pale cloudy yellow with fine persistent carbonation; aromas of banana/sweet fruit, cloves andwheat with citrus and herbal/hoppy notes; dry, light to medium bodied, crisp, lightly bitter and smooth on the palate, flavours of spice, light malt, wheat and banana, with notes of citrus, yeast and candied fruit on the clean refreshing finish.",
                    Image = "Resources/Images/paulaner-hefe-weisbier.jpeg"
                },
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 1,
                    Name = "Faxe Premium Lager",
                    Style = "lager",
                    SizeInMl = 500,
                    AlcContent = 5.5,
                    Price = 2.20,
                    Company = "Faxe",
                    CompanyLocation = "Denmark",
                    Description = "Amber colour; dried leaf/hop nose and with crisp, hoppy flavours; medium-bodied",
                    Image = "Resources/Images/faxe-premium-lager.jpeg"
                },
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 2,
                    Name = "Relax Riesling, Mosel",
                    Style = "Riesling",
                    SizeInMl = 750,
                    AlcContent = 8.5,
                    Price = 12.9,
                    Company = "Relax",
                    CompanyLocation = "Mosel, Germany",
                    Description = "Light green straw colour; aromas of tangerine, peach, white spice and black slate, with light floral tones; off-dry, medium-plus bodied, with balanced citrus acidity and tangerine and peach flavours.",
                    Image = "Resources/Images/relax-riesling.jpeg"
                },
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 2,
                    Name = "Tandem Winery Ars Nova 2014",
                    Style = "Cabernet Sauvignon/Merlot/Tempranillo",
                    SizeInMl = 750,
                    AlcContent = 14,
                    Price = 24.85,
                    Company = "Compania Vitivinicola Tandem S",
                    CompanyLocation = "Navarra, Spain",
                    Description = "An elegant wine overflowing with ripe fruit flavours complemented by delicate balsamic and spicy notes. Layered with complexity, this is a powerful expression of its mountainous terroir.",
                    Image = "Resources/Images/Tandem-Winery-Ars-Nova-2014.jpeg"
                },
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 3,
                    Name = "Dark caffee late",
                    Style = "Late",
                    SizeInMl = 120,
                    AlcContent = 0,
                    Price = 4.20,
                    Company = "Smiling Tiger",
                    CompanyLocation = "Kitchener",
                    Description = "A caramelized boot-band camp; deep notes roll bones, leaving lasting rhythms and tones.  ",
                    Image = "Resources/Images/smiling-tiger-late.png"
                },
                new DrinkModel{
                    Id = Guid.NewGuid(),
                    DrinkType = 3,
                    Name = "Ruedesheimer Kafe",
                    Style = "Coffee with brandy",
                    SizeInMl = 140,
                    AlcContent = 9,
                    Price = 12.44,
                    Company = "Ruedesheimer Schloss",
                    CompanyLocation = "Ruedesheim, Germany",
                    Description = "Deliciously brewed coffee with flambeed Asbach brandy and whipped cream",
                    Image = "Resources/Images/ruedesheimer-coffee-asbach.jpg"
                }
            );
        }
    }
}