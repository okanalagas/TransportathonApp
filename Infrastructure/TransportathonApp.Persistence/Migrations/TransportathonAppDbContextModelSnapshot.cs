﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransportathonApp.Persistence.Contexts;

#nullable disable

namespace TransportathonApp.Persistence.Migrations
{
    [DbContext(typeof(TransportathonAppDbContext))]
    partial class TransportathonAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CompanyExecutiveId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.CompanyExecutive", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CompanyExecutives");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IdentityNo")
                        .HasColumnType("bigint");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Identity.AppUserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasSeen")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ReadDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceiverUserId")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<int>("SenderUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverUserId");

                    b.HasIndex("ReservationId");

                    b.HasIndex("SenderUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.Property<int>("TransportationOfferId")
                        .HasColumnType("int");

                    b.Property<int>("TransportationRequestId")
                        .HasColumnType("int");

                    b.Property<int>("TransportationStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TransportationOfferId");

                    b.HasIndex("TransportationRequestId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyExecutiveId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TransportationTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyExecutiveId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("DriverId");

                    b.HasIndex("TransportationTeamId");

                    b.HasIndex("VehicleId");

                    b.ToTable("TransportationOffers");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("FromAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TransportDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("TransportationRequests");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationTeam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EmploymentStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StaffCount")
                        .HasColumnType("int");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("TransportationTeams");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Capacity")
                        .HasColumnType("float");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUserRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Company", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.CompanyExecutive", "CompanyExecutive")
                        .WithOne("Company")
                        .HasForeignKey("TransportathonApp.Domain.Entities.Company", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyExecutive");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.CompanyExecutive", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", "User")
                        .WithOne("CompanyExecutive")
                        .HasForeignKey("TransportathonApp.Domain.Entities.CompanyExecutive", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Customer", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", "User")
                        .WithOne("Customer")
                        .HasForeignKey("TransportathonApp.Domain.Entities.Customer", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Driver", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Company", "Company")
                        .WithMany("Drivers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Message", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", "ReceiverUser")
                        .WithMany()
                        .HasForeignKey("ReceiverUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.Reservation", "Reservation")
                        .WithMany("Messages")
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.Identity.AppUser", "SenderUser")
                        .WithMany()
                        .HasForeignKey("SenderUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ReceiverUser");

                    b.Navigation("Reservation");

                    b.Navigation("SenderUser");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Company", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TransportathonApp.Domain.Entities.Customer", null)
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("TransportathonApp.Domain.Entities.Review", "Review")
                        .WithOne("Reservation")
                        .HasForeignKey("TransportathonApp.Domain.Entities.Reservation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.TransportationOffer", "TransportationOffer")
                        .WithMany()
                        .HasForeignKey("TransportationOfferId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.TransportationRequest", "TransportationRequest")
                        .WithMany()
                        .HasForeignKey("TransportationRequestId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("TransportationOffer");

                    b.Navigation("TransportationRequest");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Review", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Customer", null)
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationOffer", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.CompanyExecutive", "CompanyExecutive")
                        .WithMany()
                        .HasForeignKey("CompanyExecutiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.Company", null)
                        .WithMany("TransportationOffers")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TransportathonApp.Domain.Entities.Driver", "Driver")
                        .WithMany("TransportationOffers")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.TransportationTeam", "TransportationTeam")
                        .WithMany("TransportationOffers")
                        .HasForeignKey("TransportationTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TransportathonApp.Domain.Entities.Vehicle", "Vehicle")
                        .WithMany("TransportationOffers")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CompanyExecutive");

                    b.Navigation("Driver");

                    b.Navigation("TransportationTeam");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationRequest", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Customer", "Customer")
                        .WithMany("TransportationRequests")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationTeam", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Company", "Company")
                        .WithMany("TransportationTeams")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("TransportathonApp.Domain.Entities.Company", "Company")
                        .WithMany("Vehicles")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Company", b =>
                {
                    b.Navigation("Drivers");

                    b.Navigation("Reservations");

                    b.Navigation("TransportationOffers");

                    b.Navigation("TransportationTeams");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.CompanyExecutive", b =>
                {
                    b.Navigation("Company")
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Reservations");

                    b.Navigation("Reviews");

                    b.Navigation("TransportationRequests");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Driver", b =>
                {
                    b.Navigation("TransportationOffers");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Identity.AppUser", b =>
                {
                    b.Navigation("CompanyExecutive")
                        .IsRequired();

                    b.Navigation("Customer")
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Reservation", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Review", b =>
                {
                    b.Navigation("Reservation")
                        .IsRequired();
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.TransportationTeam", b =>
                {
                    b.Navigation("TransportationOffers");
                });

            modelBuilder.Entity("TransportathonApp.Domain.Entities.Vehicle", b =>
                {
                    b.Navigation("TransportationOffers");
                });
#pragma warning restore 612, 618
        }
    }
}
