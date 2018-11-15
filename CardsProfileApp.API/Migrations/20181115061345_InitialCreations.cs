using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardsProfileApp.API.Migrations
{
    public partial class InitialCreations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PSProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    KnownName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BirthPlace = table.Column<string>(nullable: true),
                    BirthCountry = table.Column<string>(nullable: true),
                    Residence = table.Column<string>(nullable: true),
                    ResidenceCountry = table.Column<string>(nullable: true),
                    CareerStartYear = table.Column<int>(nullable: false),
                    CareerEndYear = table.Column<int>(nullable: false),
                    IsStillInBusiness = table.Column<bool>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    BodyType = table.Column<string>(nullable: true),
                    Measurements = table.Column<string>(nullable: true),
                    Breast = table.Column<string>(nullable: true),
                    Tattos = table.Column<string>(nullable: true),
                    Piercings = table.Column<string>(nullable: true),
                    ScortingProfileId = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    WhatWeKnow = table.Column<string>(nullable: true),
                    OtherRelatedInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    KnownAs = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false),
                    Introduction = table.Column<string>(nullable: true),
                    LookingFor = table.Column<string>(nullable: true),
                    Interests = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PSDataSpec",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayLabel = table.Column<string>(nullable: true),
                    DisplayValue = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSDataSpec", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSDataSpec_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSKnownAsName",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PSProfileId = table.Column<int>(nullable: false),
                    DisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSKnownAsName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSKnownAsName_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSPhotoGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayLabel = table.Column<string>(nullable: true),
                    PhotoPackUrl = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSPhotoGallery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSPhotoGallery_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSRelatedLink",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayLabel = table.Column<string>(nullable: true),
                    LinkUrl = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSRelatedLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSRelatedLink_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSRelevantQuestion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SourceSite = table.Column<string>(nullable: true),
                    SourceUrl = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSRelevantQuestion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSRelevantQuestion_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSSocialNetwork",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(nullable: true),
                    FAIcon = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSSocialNetwork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSSocialNetwork_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSVideoGallery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayValue = table.Column<string>(nullable: true),
                    PreviewUrl = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PSProfileId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSVideoGallery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSVideoGallery_PSProfiles_PSProfileId",
                        column: x => x.PSProfileId,
                        principalTable: "PSProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    IsMain = table.Column<bool>(nullable: false),
                    PublicId = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSPreviewPhotoUrl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhotoGalleryId = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    PSPhotoGalleryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSPreviewPhotoUrl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSPreviewPhotoUrl_PSPhotoGallery_PSPhotoGalleryId",
                        column: x => x.PSPhotoGalleryId,
                        principalTable: "PSPhotoGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PSVideoGalleryLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Source = table.Column<string>(nullable: true),
                    PSVideoGalleryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSVideoGalleryLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSVideoGalleryLinks_PSVideoGallery_PSVideoGalleryId",
                        column: x => x.PSVideoGalleryId,
                        principalTable: "PSVideoGallery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PSVideoGalleryUrl",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PSVideoGallerLinksId = table.Column<int>(nullable: false),
                    VideoDownloadUrl = table.Column<string>(nullable: true),
                    PSVideoGalleryLinksId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSVideoGalleryUrl", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSVideoGalleryUrl_PSVideoGalleryLinks_PSVideoGalleryLinksId",
                        column: x => x.PSVideoGalleryLinksId,
                        principalTable: "PSVideoGalleryLinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PSDataSpec_PSProfileId",
                table: "PSDataSpec",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSKnownAsName_PSProfileId",
                table: "PSKnownAsName",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSPhotoGallery_PSProfileId",
                table: "PSPhotoGallery",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSPreviewPhotoUrl_PSPhotoGalleryId",
                table: "PSPreviewPhotoUrl",
                column: "PSPhotoGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_PSRelatedLink_PSProfileId",
                table: "PSRelatedLink",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSRelevantQuestion_PSProfileId",
                table: "PSRelevantQuestion",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSSocialNetwork_PSProfileId",
                table: "PSSocialNetwork",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSVideoGallery_PSProfileId",
                table: "PSVideoGallery",
                column: "PSProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PSVideoGalleryLinks_PSVideoGalleryId",
                table: "PSVideoGalleryLinks",
                column: "PSVideoGalleryId");

            migrationBuilder.CreateIndex(
                name: "IX_PSVideoGalleryUrl_PSVideoGalleryLinksId",
                table: "PSVideoGalleryUrl",
                column: "PSVideoGalleryLinksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "PSDataSpec");

            migrationBuilder.DropTable(
                name: "PSKnownAsName");

            migrationBuilder.DropTable(
                name: "PSPreviewPhotoUrl");

            migrationBuilder.DropTable(
                name: "PSRelatedLink");

            migrationBuilder.DropTable(
                name: "PSRelevantQuestion");

            migrationBuilder.DropTable(
                name: "PSSocialNetwork");

            migrationBuilder.DropTable(
                name: "PSVideoGalleryUrl");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PSPhotoGallery");

            migrationBuilder.DropTable(
                name: "PSVideoGalleryLinks");

            migrationBuilder.DropTable(
                name: "PSVideoGallery");

            migrationBuilder.DropTable(
                name: "PSProfiles");
        }
    }
}
