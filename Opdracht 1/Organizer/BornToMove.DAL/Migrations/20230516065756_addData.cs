using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BornToMove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table:  "move",
                columns: new[] { "Name", "Description", "SweatRate"},
                values: new object[] { "Push up", 
                    "Ga horizontaal liggen op teentoppen en handen. Laat het lijf langzaam zakken tot de neus de grond bijna raakt. Duw het lijf terug nu omhoog tot de ellebogen bijna gestrekt zijn. Vervolgens weer laten zakken. Doe dit 20 keer zonder tussenpauzes", 
                    "3" } ) ;

            migrationBuilder.InsertData(
                table: "move",
                columns: new[] { "Name", "Description", "SweatRate" },
                values: new object[] { "Planking",
                    "Ga horizontaal liggen op teentoppen en onderarmen. Houdt deze positie 1 minuut vast",
                    "3"});

            migrationBuilder.InsertData(
                table: "move",
                columns: new[] { "Name", "Description", "SweatRate" },
                values: new object[] {"Squat",
                    "Ga staan met gestrekte armen. Zak door de knieën tot de billen de grond bijna raken. Ga weer volledig gestrekt staan. Herhaal dit 20 keer zonder tussenpauzes",
                    "5"});

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
