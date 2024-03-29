﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using airubt.Infrastructure.Context;

namespace airubt.Infrastructure.Migrations
{
    [DbContext(typeof(airubtContext))]
    partial class airubtContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("airubt.Domain.Models.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int?>("Host")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int?>("Timelength")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("(datediff(minute,[StartTime],[EndTime]))", false);

                    b.HasKey("Id");

                    b.HasIndex("City");

                    b.HasIndex("Host");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("airubt.Domain.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("airubt.Domain.Models.ApartamentReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("apartamentId")
                        .HasColumnType("int");

                    b.Property<int>("stars")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("apartamentId");

                    b.HasIndex("userId");

                    b.ToTable("ApartamentReviews");
                });

            modelBuilder.Entity("airubt.Domain.Models.Apartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool?>("Garage")
                        .HasColumnType("bit");

                    b.Property<bool?>("Garden")
                        .HasColumnType("bit");

                    b.Property<int?>("HostId")
                        .HasColumnType("int")
                        .HasColumnName("HostID");

                    b.Property<int?>("MaxGuests")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("Review")
                        .HasColumnType("int");

                    b.Property<int?>("Rooms")
                        .HasColumnType("int");

                    b.Property<int?>("Space")
                        .HasColumnType("int");

                    b.Property<bool?>("Terrace")
                        .HasColumnType("bit");

                    b.Property<int?>("Toilets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Category");

                    b.HasIndex("City");

                    b.HasIndex("HostId");

                    b.ToTable("Apartment");
                });

            modelBuilder.Entity("airubt.Domain.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ApartmentId")
                        .HasColumnType("int")
                        .HasColumnName("ApartmentID");

                    b.Property<DateTime?>("Checkin")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Checkout")
                        .HasColumnType("datetime");

                    b.Property<int?>("Guests")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.HasKey("Id");

                    b.HasIndex("ApartmentId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("airubt.Domain.Models.Category", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Name")
                        .HasName("PK__Category__737584F7673CF758");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("airubt.Domain.Models.City", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Name")
                        .HasName("PK__City__737584F758D30F32");

                    b.ToTable("City");
                });

            modelBuilder.Entity("airubt.Domain.Models.Host", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("(datediff(year,[BirthDate],getdate()))", false);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Host");
                });

            modelBuilder.Entity("airubt.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("(datediff(year,[BirthDate],getdate()))", false);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("airubt.Domain.Models.Activity", b =>
                {
                    b.HasOne("airubt.Domain.Models.City", "CityNavigation")
                        .WithMany("Activities")
                        .HasForeignKey("City")
                        .HasConstraintName("FK__Activity__City__4BAC3F29");

                    b.HasOne("airubt.Domain.Models.Host", "HostNavigation")
                        .WithMany("Activities")
                        .HasForeignKey("Host")
                        .HasConstraintName("FK__Activity__Host__4CA06362");

                    b.Navigation("CityNavigation");

                    b.Navigation("HostNavigation");
                });

            modelBuilder.Entity("airubt.Domain.Models.ApartamentReview", b =>
                {
                    b.HasOne("airubt.Domain.Models.Apartment", "apartament")
                        .WithMany()
                        .HasForeignKey("apartamentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("airubt.Domain.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("apartament");

                    b.Navigation("user");
                });

            modelBuilder.Entity("airubt.Domain.Models.Apartment", b =>
                {
                    b.HasOne("airubt.Domain.Models.Category", "CategoryNavigation")
                        .WithMany("Apartments")
                        .HasForeignKey("Category")
                        .HasConstraintName("FK__Apartment__Categ__403A8C7D");

                    b.HasOne("airubt.Domain.Models.City", "CityNavigation")
                        .WithMany("Apartments")
                        .HasForeignKey("City")
                        .HasConstraintName("FK__Apartment__City__3F466844");

                    b.HasOne("airubt.Domain.Models.Host", "Host")
                        .WithMany("Apartments")
                        .HasForeignKey("HostId")
                        .HasConstraintName("FK__Apartment__HostI__3E52440B");

                    b.Navigation("CategoryNavigation");

                    b.Navigation("CityNavigation");

                    b.Navigation("Host");
                });

            modelBuilder.Entity("airubt.Domain.Models.Appointment", b =>
                {
                    b.HasOne("airubt.Domain.Models.Apartment", "Apartment")
                        .WithMany("Appointments")
                        .HasForeignKey("ApartmentId")
                        .HasConstraintName("FK__Appointme__Apart__440B1D61");

                    b.HasOne("airubt.Domain.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Appointme__UserI__4316F928");

                    b.Navigation("Apartment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("airubt.Domain.Models.Apartment", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("airubt.Domain.Models.Category", b =>
                {
                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("airubt.Domain.Models.City", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("airubt.Domain.Models.Host", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("Apartments");
                });

            modelBuilder.Entity("airubt.Domain.Models.User", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
