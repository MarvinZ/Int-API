﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using quiz_backend;
using System;

namespace quiz_backend.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20191031182718_FirstRealMigration")]
    partial class FirstRealMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("quiz_backend.Models.Feed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<bool>("isSubscribed");

                    b.Property<string>("url");

                    b.HasKey("Id");

                    b.ToTable("Feed");
                });

            modelBuilder.Entity("quiz_backend.Models.UserFeed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FeedId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserFeed");
                });
#pragma warning restore 612, 618
        }
    }
}