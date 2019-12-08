﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Repositories;

namespace TermProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProject.Models.Animal", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Class");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Diet");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("AnimalID");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("TermProject.Models.ForumPost", b =>
                {
                    b.Property<int>("PostID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Text")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("PostID");

                    b.ToTable("ForumPosts");
                });

            modelBuilder.Entity("TermProject.Models.Response", b =>
                {
                    b.Property<int>("ResponseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<int?>("ForumPostPostID");

                    b.HasKey("ResponseID");

                    b.HasIndex("ForumPostPostID");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("TermProject.Models.Response", b =>
                {
                    b.HasOne("TermProject.Models.ForumPost")
                        .WithMany("Responses")
                        .HasForeignKey("ForumPostPostID");
                });
#pragma warning restore 612, 618
        }
    }
}