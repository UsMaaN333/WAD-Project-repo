﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WAD_SRMS_Project.Models;

#nullable disable

namespace WADSRMSProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221227072650_Addmission")]
    partial class Addmission
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WAD_SRMS_Project.models.AddmissionModel", b =>
                {
                    b.Property<string>("Email_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Mobile_Number")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("Email_Id");

                    b.ToTable("AddmissionModels");
                });
#pragma warning restore 612, 618
        }
    }
}
