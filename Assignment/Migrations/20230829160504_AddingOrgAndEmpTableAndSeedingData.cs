using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddingOrgAndEmpTableAndSeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "organisations",
                columns: table => new
                {
                    OrganisationId = table.Column<int>(type: "int", nullable: false),
                    OrganisationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisations", x => x.OrganisationId);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DeptName", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org1", "Email1@abc.com", "First1", "Last1", "Phone1" },
                    { 2, new DateTime(2001, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org2", "Email2@abc.com", "First2", "Last2", "Phone2" },
                    { 3, new DateTime(1998, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org3", "Email3@abc.com", "First3", "Last3", "Phone3" },
                    { 4, new DateTime(1997, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org4", "Email4@abc.com", "First4", "Last4", "Phone4" },
                    { 5, new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org5", "Email5@abc.com", "First5", "Last5", "Phone5" },
                    { 6, new DateTime(1997, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org6", "Email6@abc.com", "First6", "Last6", "Phone6" },
                    { 7, new DateTime(1995, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org7", "Email7@abc.com", "First7", "Last7", "Phone7" },
                    { 8, new DateTime(1996, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org8", "Email8@abc.com", "First8", "Last8", "Phone8" },
                    { 9, new DateTime(2001, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org9", "Email9@abc.com", "First9", "Last9", "Phone9" },
                    { 10, new DateTime(1996, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org10", "Email10@abc.com", "First10", "Last10", "Phone10" },
                    { 11, new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org11", "Email11@abc.com", "First11", "Last11", "Phone11" },
                    { 12, new DateTime(1998, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org12", "Email12@abc.com", "First12", "Last12", "Phone12" },
                    { 13, new DateTime(1995, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org13", "Email13@abc.com", "First13", "Last13", "Phone13" },
                    { 14, new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org14", "Email14@abc.com", "First14", "Last14", "Phone14" },
                    { 15, new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org15", "Email15@abc.com", "First15", "Last15", "Phone15" },
                    { 16, new DateTime(2001, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org16", "Email16@abc.com", "First16", "Last16", "Phone16" },
                    { 17, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org17", "Email17@abc.com", "First17", "Last17", "Phone17" },
                    { 18, new DateTime(1999, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org18", "Email18@abc.com", "First18", "Last18", "Phone18" },
                    { 19, new DateTime(1996, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org19", "Email19@abc.com", "First19", "Last19", "Phone19" },
                    { 20, new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Org20", "Email20@abc.com", "First20", "Last20", "Phone20" }
                });

            migrationBuilder.InsertData(
                table: "organisations",
                columns: new[] { "OrganisationId", "OrganisationName" },
                values: new object[,]
                {
                    { 1, "Org1" },
                    { 2, "Org2" },
                    { 3, "Org3" },
                    { 4, "Org4" },
                    { 5, "Org5" },
                    { 6, "Org6" },
                    { 7, "Org7" },
                    { 8, "Org8" },
                    { 9, "Org9" },
                    { 10, "Org10" },
                    { 11, "Org11" },
                    { 12, "Org12" },
                    { 13, "Org13" },
                    { 14, "Org14" },
                    { 15, "Org15" },
                    { 16, "Org16" },
                    { 17, "Org17" },
                    { 18, "Org18" },
                    { 19, "Org19" },
                    { 20, "Org20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "organisations");
        }
    }
}
