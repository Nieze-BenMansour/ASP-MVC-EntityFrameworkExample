using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityFrameworkExample.Migrations;

/// <inheritdoc />
public partial class InitialCreate : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "People",
            columns: table => new
            {
                PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                FirstName = table.Column<string>(type: "TEXT", nullable: false),
                LastName = table.Column<string>(type: "TEXT", nullable: false),
                City = table.Column<string>(type: "TEXT", nullable: false),
                Address = table.Column<string>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_People", x => x.PersonId);
            });

        migrationBuilder.InsertData(
            table: "People",
            columns: new[] { "PersonId", "Address", "City", "FirstName", "LastName" },
            values: new object[,]
            {
                { 1, "317 Long Street", "Ocala", "Tara", "Brewer" },
                { 2, "3163 Nickel Road", "Anaheim", "Andrew", "Tippett" }
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "People");
    }
}
