﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebProje.Models;

#nullable disable

namespace WebProje.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20230807195655_modelmig2")]
    partial class modelmig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("WebProje.Models.Login", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("User_ID"));

                    b.Property<string>("E_Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("User_ID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("WebProje.Models.ModelHayvanKabul", b =>
                {
                    b.Property<int>("HayvanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("HayvanID"));

                    b.Property<int>("Animal_Age")
                        .HasColumnType("integer");

                    b.Property<string>("Animal_Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Animal_Kind")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Animal_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HayvanDurum")
                        .HasColumnType("integer");

                    b.Property<int>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("HayvanID");

                    b.ToTable("modelHayvanKabul");
                });

            modelBuilder.Entity("WebProje.Models.ModelSahiplen", b =>
                {
                    b.Property<int>("SahiplenmeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("SahiplenmeID"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HayvanID")
                        .HasColumnType("integer");

                    b.Property<string>("IsimSoyisim")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SahiplenmeID");

                    b.ToTable("ModelSahiplen");
                });
#pragma warning restore 612, 618
        }
    }
}
