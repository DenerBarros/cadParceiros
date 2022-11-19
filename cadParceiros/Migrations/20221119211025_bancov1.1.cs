using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadParceiros.Migrations
{
    /// <inheritdoc />
    public partial class bancov11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoParceiro",
                table: "Parceiros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoPessoa",
                table: "Parceiros",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoParceiro",
                table: "Parceiros");

            migrationBuilder.DropColumn(
                name: "TipoPessoa",
                table: "Parceiros");
        }
    }
}
