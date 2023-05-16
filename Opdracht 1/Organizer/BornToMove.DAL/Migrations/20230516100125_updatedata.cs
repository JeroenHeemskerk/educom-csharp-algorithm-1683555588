using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BornToMove.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoveRating_move_MoveId",
                table: "MoveRating");

            migrationBuilder.AlterColumn<int>(
                name: "MoveId",
                table: "MoveRating",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Moveld",
                table: "MoveRating",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveRating_move_MoveId",
                table: "MoveRating",
                column: "MoveId",
                principalTable: "move",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoveRating_move_MoveId",
                table: "MoveRating");

            migrationBuilder.DropColumn(
                name: "Moveld",
                table: "MoveRating");

            migrationBuilder.AlterColumn<int>(
                name: "MoveId",
                table: "MoveRating",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MoveRating_move_MoveId",
                table: "MoveRating",
                column: "MoveId",
                principalTable: "move",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
