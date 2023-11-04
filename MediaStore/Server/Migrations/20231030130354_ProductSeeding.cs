using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MediaStore.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "This is a terrible movie", "https://upload.wikimedia.org/wikipedia/en/0/09/Suburbicon.jpg", 2.99m, "Suburbicon" },
                    { 2, "Sliders is an American science fiction and fantasy television series created by Robert K. Weiss and Tracy Tormé. It was broadcast for five seasons between 1995 and 2000. The series follows a group of travelers as they use a wormhole to 'slide' between different parallel universes. Tracy Tormé, Robert K. Weiss, Leslie Belzberg, John Landis, David Peckinpah, Bill Dial and Alan Barnette served as executive producers at different times of the production. For its first two seasons, it was produced in Vancouver, British Columbia. It was filmed primarily in Los Angeles, California, in the last three seasons.", "https://upload.wikimedia.org/wikipedia/en/e/e3/Sliders2.JPG", 29.99m, "Sliders (TV series)" },
                    { 3, "Charmed is an American fantasy drama television series created by Constance M. Burge and produced by Aaron Spelling and his production company Spelling Television, with Brad Kern serving as showrunner. The series was originally broadcast by The WB from October 7, 1998, until May 21, 2006", "https://upload.wikimedia.org/wikipedia/en/a/af/Charmedtitlelogo1.jpg", 29.99m, "Charmed" },
                    { 4, "Buffy the Vampire Slayer is a 1992 American comedy vampire film directed by Fran Rubel Kuzui and starring Kristy Swanson, Donald Sutherland, Paul Reubens, Rutger Hauer, Luke Perry, Hilary Swank, and David Arquette.", "https://upload.wikimedia.org/wikipedia/en/9/90/Buffy_Season_%281%29.jpg", 29.99m, "Buffy The Vampire Slayer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
