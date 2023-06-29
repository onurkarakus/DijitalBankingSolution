﻿// <auto-generated />
using System;
using Customer.Infrastructure.DbContextInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Customer.Infrastructure.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    partial class CustomerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Customer.Domain.DataModels.CustomerInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteFootballTeam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFavoriteAddress")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CustomerInformation", "Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Test Adres Bilgisi",
                            AddressDescription = "Ev Adresi",
                            BirthDate = new DateTime(1980, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "SeedBatch",
                            CreatedDate = new DateTime(2023, 6, 29, 15, 33, 34, 862, DateTimeKind.Local).AddTicks(9458),
                            EmailAddress = "test@test.com",
                            FavoriteFootballTeam = "Galatasaray",
                            FirstName = "Mehmet",
                            IsFavoriteAddress = true,
                            LastName = "Yılmaz",
                            MiddleName = "Onur",
                            MobileNumber = "5555555555",
                            UpdatedBy = "SeedBatch",
                            UpdatedDate = new DateTime(2023, 6, 29, 15, 33, 34, 862, DateTimeKind.Local).AddTicks(9496)
                        });
                });

            modelBuilder.Entity("Customer.Domain.DataModels.CustomerSecurity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("FailedLoginAttempts")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastLoginDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastPasswordChangedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastUpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityQuestion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerSecurity", "Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "SeedBatch",
                            CreatedDate = new DateTime(2023, 6, 29, 15, 33, 34, 863, DateTimeKind.Local).AddTicks(60),
                            CustomerId = 1,
                            FailedLoginAttempts = 0,
                            Password = "F+qm2jfPeT0sHU5Uf6ZWa2wy9QPCuKo+rbNjf5pKk4BlHJl5LL63ovDPXAMbYIZ58biqvAaTD6B23PDhK/K8TQ==",
                            PasswordSalt = "aW2MIhfFInZM5mrK2JOcIX7wY/tmdjCk8r0M3xWvQW0=",
                            SecurityAnswer = "Mavi",
                            SecurityQuestion = "En sevdiğiniz renk nedir?",
                            UpdatedBy = "SeedBatch",
                            UpdatedDate = new DateTime(2023, 6, 29, 15, 33, 34, 863, DateTimeKind.Local).AddTicks(62),
                            UserName = "onuryilmaz"
                        });
                });

            modelBuilder.Entity("Customer.Domain.DataModels.CustomerSecurity", b =>
                {
                    b.HasOne("Customer.Domain.DataModels.CustomerInformation", "CustomerInformation")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerInformation");
                });
#pragma warning restore 612, 618
        }
    }
}
