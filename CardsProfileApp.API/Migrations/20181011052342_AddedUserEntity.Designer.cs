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
    [Migration("20181011052342_AddedUserEntity")]
    partial class AddedUserEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("CardsProfileApp.API.Models.ProfileCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArtisticName");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("BirthPlace");

                    b.Property<string>("RealName");

                    b.HasKey("Id");

                    b.ToTable("ProfileCards");
                });

            modelBuilder.Entity("CardsProfileApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DisplayName");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}