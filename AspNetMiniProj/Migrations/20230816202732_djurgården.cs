using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetMiniProj.Migrations
{
    /// <inheritdoc />
    public partial class djurgården : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "Titanic is a 1997 American disaster film directed, written, produced, and co-edited by James Cameron.", "Titanic" },
                    { 3, "Saw is a 2004 American horror film directed by James Wan, in his feature directorial debut, and written by Leigh Whannell from a story by Wan and Whannell.", "Saw" },
                    { 5, "Ghostbusters is a 1984 American supernatural comedy film directed and produced by Ivan Reitman, and written by Dan Aykroyd and Harold Ramis.", "Ghostbusters" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
