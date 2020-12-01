using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinkModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DrinkType = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    SizeInMl = table.Column<int>(nullable: false),
                    AlcContent = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Company = table.Column<string>(nullable: true),
                    CompanyLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserPassword = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    Usermobile = table.Column<int>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    LastUpdatedOn = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserModels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DrinkModel",
                columns: new[] { "Id", "AlcContent", "Company", "CompanyLocation", "Description", "DrinkType", "Image", "LastUpdatedBy", "LastUpdatedOn", "Name", "Price", "SizeInMl", "Style" },
                values: new object[,]
                {
                    { new Guid("8d04cfd8-6d6d-42f5-b286-90f79e5340dc"), 5.5, "Paulaner Brauerei Gmbh", "Germany", "Pale cloudy yellow with fine persistent carbonation; aromas of banana/sweet fruit, cloves andwheat with citrus and herbal/hoppy notes; dry, light to medium bodied, crisp, lightly bitter and smooth on the palate, flavours of spice, light malt, wheat and banana, with notes of citrus, yeast and candied fruit on the clean refreshing finish.", 1, "Resources/Images/paulaner-hefe-weisbier.jpeg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paulaner", 2.9500000000000002, 500, "Hefe-Weissbier" },
                    { new Guid("2a71af5b-d6da-4aaf-8974-d2aed1de0078"), 5.5, "Faxe", "Denmark", "Amber colour; dried leaf/hop nose and with crisp, hoppy flavours; medium-bodied", 1, "Resources/Images/faxe-premium-lager.jpeg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Faxe Premium Lager", 2.2000000000000002, 500, "lager" },
                    { new Guid("60923147-c85a-469e-bc19-fdc7e5ffb379"), 8.5, "Relax", "Mosel, Germany", "Light green straw colour; aromas of tangerine, peach, white spice and black slate, with light floral tones; off-dry, medium-plus bodied, with balanced citrus acidity and tangerine and peach flavours.", 2, "Resources/Images/relax-riesling.jpeg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Relax Riesling, Mosel", 12.9, 750, "Riesling" },
                    { new Guid("209a7eea-8d2f-497c-9899-f324d93fc4bc"), 14.0, "Compania Vitivinicola Tandem S", "Navarra, Spain", "An elegant wine overflowing with ripe fruit flavours complemented by delicate balsamic and spicy notes. Layered with complexity, this is a powerful expression of its mountainous terroir.", 2, "Resources/Images/Tandem-Winery-Ars-Nova-2014.jpeg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tandem Winery Ars Nova 2014", 24.850000000000001, 750, "Cabernet Sauvignon/Merlot/Tempranillo" },
                    { new Guid("c4cb6345-f9e4-4e18-8194-645d575ef548"), 0.0, "Smiling Tiger", "Kitchener", "A caramelized boot-band camp; deep notes roll bones, leaving lasting rhythms and tones.  ", 3, "Resources/Images/smiling-tiger-late.png", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dark caffee late", 4.2000000000000002, 120, "Late" },
                    { new Guid("184211bc-d904-4b75-8268-e788b82dfeef"), 9.0, "Ruedesheimer Schloss", "Ruedesheim, Germany", "Deliciously brewed coffee with flambeed Asbach brandy and whipped cream", 3, "Resources/Images/ruedesheimer-coffee-asbach.jpg", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruedesheimer Kafe", 12.44, 140, "Coffee with brandy" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserModels_UserEmail",
                table: "UserModels",
                column: "UserEmail",
                unique: true,
                filter: "[UserEmail] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserModels_UserName",
                table: "UserModels",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkModel");

            migrationBuilder.DropTable(
                name: "UserModels");
        }
    }
}
