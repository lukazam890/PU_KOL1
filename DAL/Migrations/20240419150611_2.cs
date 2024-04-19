using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdGrupy",
                table: "Historie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Historie_IdGrupy",
                table: "Historie",
                column: "IdGrupy");

            migrationBuilder.AddForeignKey(
                name: "FK_Historie_Grupy_IdGrupy",
                table: "Historie",
                column: "IdGrupy",
                principalTable: "Grupy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Historie_Grupy_IdGrupy",
                table: "Historie");

            migrationBuilder.DropIndex(
                name: "IX_Historie_IdGrupy",
                table: "Historie");

            migrationBuilder.DropColumn(
                name: "IdGrupy",
                table: "Historie");
        }
    }
}
