using Microsoft.EntityFrameworkCore.Migrations;

namespace CardsProfileApp.API.Migrations
{
    public partial class AddedQtyPhotosProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtyPhotos",
                table: "PSPhotoGallery",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QtyPhotos",
                table: "PSPhotoGallery");
        }
    }
}
