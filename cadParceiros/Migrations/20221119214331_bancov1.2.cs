using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cadParceiros.Migrations
{
    /// <inheritdoc />
    public partial class bancov12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusCadastro",
                table: "Parceiros",
                newName: "Status");

            migrationBuilder.AlterColumn<int>(
                name: "TipoPessoa",
                table: "Parceiros",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TipoParceiro",
                table: "Parceiros",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Parceiros",
                newName: "StatusCadastro");

            migrationBuilder.AlterColumn<string>(
                name: "TipoPessoa",
                table: "Parceiros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TipoParceiro",
                table: "Parceiros",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
