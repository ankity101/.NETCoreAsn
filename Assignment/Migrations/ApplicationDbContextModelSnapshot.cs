﻿// <auto-generated />
using System;
using Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org1",
                            Email = "Email1@abc.com",
                            FirstName = "First1",
                            LastName = "Last1",
                            Phone = "Phone1"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(2001, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org2",
                            Email = "Email2@abc.com",
                            FirstName = "First2",
                            LastName = "Last2",
                            Phone = "Phone2"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1998, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org3",
                            Email = "Email3@abc.com",
                            FirstName = "First3",
                            LastName = "Last3",
                            Phone = "Phone3"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org4",
                            Email = "Email4@abc.com",
                            FirstName = "First4",
                            LastName = "Last4",
                            Phone = "Phone4"
                        },
                        new
                        {
                            EmployeeId = 5,
                            DateOfBirth = new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org5",
                            Email = "Email5@abc.com",
                            FirstName = "First5",
                            LastName = "Last5",
                            Phone = "Phone5"
                        },
                        new
                        {
                            EmployeeId = 6,
                            DateOfBirth = new DateTime(1997, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org6",
                            Email = "Email6@abc.com",
                            FirstName = "First6",
                            LastName = "Last6",
                            Phone = "Phone6"
                        },
                        new
                        {
                            EmployeeId = 7,
                            DateOfBirth = new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org7",
                            Email = "Email7@abc.com",
                            FirstName = "First7",
                            LastName = "Last7",
                            Phone = "Phone7"
                        },
                        new
                        {
                            EmployeeId = 8,
                            DateOfBirth = new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org8",
                            Email = "Email8@abc.com",
                            FirstName = "First8",
                            LastName = "Last8",
                            Phone = "Phone8"
                        },
                        new
                        {
                            EmployeeId = 9,
                            DateOfBirth = new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org9",
                            Email = "Email9@abc.com",
                            FirstName = "First9",
                            LastName = "Last9",
                            Phone = "Phone9"
                        },
                        new
                        {
                            EmployeeId = 10,
                            DateOfBirth = new DateTime(1996, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org10",
                            Email = "Email10@abc.com",
                            FirstName = "First10",
                            LastName = "Last10",
                            Phone = "Phone10"
                        },
                        new
                        {
                            EmployeeId = 11,
                            DateOfBirth = new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org11",
                            Email = "Email11@abc.com",
                            FirstName = "First11",
                            LastName = "Last11",
                            Phone = "Phone11"
                        },
                        new
                        {
                            EmployeeId = 12,
                            DateOfBirth = new DateTime(1998, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org12",
                            Email = "Email12@abc.com",
                            FirstName = "First12",
                            LastName = "Last12",
                            Phone = "Phone12"
                        },
                        new
                        {
                            EmployeeId = 13,
                            DateOfBirth = new DateTime(1995, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org13",
                            Email = "Email13@abc.com",
                            FirstName = "First13",
                            LastName = "Last13",
                            Phone = "Phone13"
                        },
                        new
                        {
                            EmployeeId = 14,
                            DateOfBirth = new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org14",
                            Email = "Email14@abc.com",
                            FirstName = "First14",
                            LastName = "Last14",
                            Phone = "Phone14"
                        },
                        new
                        {
                            EmployeeId = 15,
                            DateOfBirth = new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org15",
                            Email = "Email15@abc.com",
                            FirstName = "First15",
                            LastName = "Last15",
                            Phone = "Phone15"
                        },
                        new
                        {
                            EmployeeId = 16,
                            DateOfBirth = new DateTime(2001, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org16",
                            Email = "Email16@abc.com",
                            FirstName = "First16",
                            LastName = "Last16",
                            Phone = "Phone16"
                        },
                        new
                        {
                            EmployeeId = 17,
                            DateOfBirth = new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org17",
                            Email = "Email17@abc.com",
                            FirstName = "First17",
                            LastName = "Last17",
                            Phone = "Phone17"
                        },
                        new
                        {
                            EmployeeId = 18,
                            DateOfBirth = new DateTime(1999, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org18",
                            Email = "Email18@abc.com",
                            FirstName = "First18",
                            LastName = "Last18",
                            Phone = "Phone18"
                        },
                        new
                        {
                            EmployeeId = 19,
                            DateOfBirth = new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org19",
                            Email = "Email19@abc.com",
                            FirstName = "First19",
                            LastName = "Last19",
                            Phone = "Phone19"
                        },
                        new
                        {
                            EmployeeId = 20,
                            DateOfBirth = new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeptName = "Org20",
                            Email = "Email20@abc.com",
                            FirstName = "First20",
                            LastName = "Last20",
                            Phone = "Phone20"
                        });
                });

            modelBuilder.Entity("Assignment.Models.Organisation", b =>
                {
                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("OrganisationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganisationId");

                    b.ToTable("organisations");

                    b.HasData(
                        new
                        {
                            OrganisationId = 1,
                            OrganisationName = "Org1"
                        },
                        new
                        {
                            OrganisationId = 2,
                            OrganisationName = "Org2"
                        },
                        new
                        {
                            OrganisationId = 3,
                            OrganisationName = "Org3"
                        },
                        new
                        {
                            OrganisationId = 4,
                            OrganisationName = "Org4"
                        },
                        new
                        {
                            OrganisationId = 5,
                            OrganisationName = "Org5"
                        },
                        new
                        {
                            OrganisationId = 6,
                            OrganisationName = "Org6"
                        },
                        new
                        {
                            OrganisationId = 7,
                            OrganisationName = "Org7"
                        },
                        new
                        {
                            OrganisationId = 8,
                            OrganisationName = "Org8"
                        },
                        new
                        {
                            OrganisationId = 9,
                            OrganisationName = "Org9"
                        },
                        new
                        {
                            OrganisationId = 10,
                            OrganisationName = "Org10"
                        },
                        new
                        {
                            OrganisationId = 11,
                            OrganisationName = "Org11"
                        },
                        new
                        {
                            OrganisationId = 12,
                            OrganisationName = "Org12"
                        },
                        new
                        {
                            OrganisationId = 13,
                            OrganisationName = "Org13"
                        },
                        new
                        {
                            OrganisationId = 14,
                            OrganisationName = "Org14"
                        },
                        new
                        {
                            OrganisationId = 15,
                            OrganisationName = "Org15"
                        },
                        new
                        {
                            OrganisationId = 16,
                            OrganisationName = "Org16"
                        },
                        new
                        {
                            OrganisationId = 17,
                            OrganisationName = "Org17"
                        },
                        new
                        {
                            OrganisationId = 18,
                            OrganisationName = "Org18"
                        },
                        new
                        {
                            OrganisationId = 19,
                            OrganisationName = "Org19"
                        },
                        new
                        {
                            OrganisationId = 20,
                            OrganisationName = "Org20"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
