﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Route_Groups_AspNet.Context;

#nullable disable

namespace Route_Groups_AspNet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("Route_Groups_AspNet.Model.Category", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d09fe398-0917-439d-8edc-d423894c21cc"),
                            Title = "Tecnologias",
                            Url = "https://http2.mlstatic.com/D_NQ_NP2X_660966-MLA80300585057_102024-B.webp"
                        },
                        new
                        {
                            Id = new Guid("f407aca2-ef55-4771-a1b4-1456bfaf2665"),
                            Title = "Casa E Móveis",
                            Url = "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1729294158019-desktop26.png"
                        },
                        new
                        {
                            Id = new Guid("f19d1d91-34dc-4a2d-ba08-1fee0468fcf3"),
                            Title = "Esportes e Fitnes",
                            Url = "https://http2.mlstatic.com/storage/splinter-admin/o:f_webp,q_auto:best/1731421475975-desk-01-v2.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
