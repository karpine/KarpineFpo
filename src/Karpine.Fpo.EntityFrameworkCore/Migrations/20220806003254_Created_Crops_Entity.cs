using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karpine.Fpo.Migrations
{
    public partial class Created_Crops_Entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FarmerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acreage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveyNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoilType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ph = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nitrogen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phosphurus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pottasium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Magnesium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calcium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salinity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zinc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iron = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manganese = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copper = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sodium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sulphur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoilTestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lattitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TestedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crops", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Crops");
        }
    }
}
