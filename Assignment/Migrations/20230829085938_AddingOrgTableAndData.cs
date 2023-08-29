using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class AddingOrgTableAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "organisations");
        }
    }
}
