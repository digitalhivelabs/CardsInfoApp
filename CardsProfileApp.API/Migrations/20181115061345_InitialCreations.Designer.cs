﻿// <auto-generated />
using System;
using CardsProfileApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardsProfileApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181115061345_InitialCreations")]
    partial class InitialCreations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("CardsProfileApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSDataSpec", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayLabel");

                    b.Property<string>("DisplayValue");

                    b.Property<int>("PSProfileId");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSDataSpec");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSKnownAsName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<int>("PSProfileId");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSKnownAsName");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSPhotoGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayLabel");

                    b.Property<int>("PSProfileId");

                    b.Property<string>("PhotoPackUrl");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSPhotoGallery");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSPreviewPhotoUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PSPhotoGalleryId");

                    b.Property<int>("PhotoGalleryId");

                    b.Property<string>("PhotoUrl");

                    b.HasKey("Id");

                    b.HasIndex("PSPhotoGalleryId");

                    b.ToTable("PSPreviewPhotoUrl");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthCountry");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("BirthPlace");

                    b.Property<string>("BodyType");

                    b.Property<string>("Breast");

                    b.Property<int>("CareerEndYear");

                    b.Property<int>("CareerStartYear");

                    b.Property<int>("Height");

                    b.Property<bool>("IsStillInBusiness");

                    b.Property<string>("KnownName");

                    b.Property<string>("Measurements");

                    b.Property<string>("OtherRelatedInfo");

                    b.Property<string>("PhotoUrl");

                    b.Property<string>("Piercings");

                    b.Property<string>("Residence");

                    b.Property<string>("ResidenceCountry");

                    b.Property<int>("ScortingProfileId");

                    b.Property<string>("Tattos");

                    b.Property<int>("Weight");

                    b.Property<string>("WhatWeKnow");

                    b.HasKey("Id");

                    b.ToTable("PSProfiles");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSRelatedLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayLabel");

                    b.Property<string>("LinkUrl");

                    b.Property<int>("PSProfileId");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSRelatedLink");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSRelevantQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int>("PSProfileId");

                    b.Property<string>("Question");

                    b.Property<string>("SourceSite");

                    b.Property<string>("SourceUrl");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSRelevantQuestion");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSSocialNetwork", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("FAIcon");

                    b.Property<int>("PSProfileId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSSocialNetwork");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayValue");

                    b.Property<int>("PSProfileId");

                    b.Property<string>("PreviewUrl");

                    b.HasKey("Id");

                    b.HasIndex("PSProfileId");

                    b.ToTable("PSVideoGallery");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGalleryLinks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PSVideoGalleryId");

                    b.Property<string>("Source");

                    b.HasKey("Id");

                    b.HasIndex("PSVideoGalleryId");

                    b.ToTable("PSVideoGalleryLinks");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGalleryUrl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PSVideoGallerLinksId");

                    b.Property<int?>("PSVideoGalleryLinksId");

                    b.Property<string>("VideoDownloadUrl");

                    b.HasKey("Id");

                    b.HasIndex("PSVideoGalleryLinksId");

                    b.ToTable("PSVideoGalleryUrl");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Gender");

                    b.Property<string>("Interests");

                    b.Property<string>("Introduction");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LookingFor");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.Photo", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSDataSpec", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("DataSpecifications")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSKnownAsName", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("KnownAsNames")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSPhotoGallery", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("PhotoGalleries")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSPreviewPhotoUrl", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSPhotoGallery")
                        .WithMany("PreviewPhotosUrls")
                        .HasForeignKey("PSPhotoGalleryId");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSRelatedLink", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("RelatedLinks")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSRelevantQuestion", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("RelevantQuestions")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSSocialNetwork", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("SocialNetworks")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGallery", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSProfile")
                        .WithMany("VideoGalleries")
                        .HasForeignKey("PSProfileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGalleryLinks", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSVideoGallery")
                        .WithMany("DownloadLinks")
                        .HasForeignKey("PSVideoGalleryId");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.PSVideoGalleryUrl", b =>
                {
                    b.HasOne("CardsProfileApp.API.Models.PSVideoGalleryLinks")
                        .WithMany("Urls")
                        .HasForeignKey("PSVideoGalleryLinksId");
                });
#pragma warning restore 612, 618
        }
    }
}
