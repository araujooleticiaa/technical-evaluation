using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestao.Colaboradores.Migrations
{
    /// <inheritdoc />
    public partial class updatemodels1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_UsuarioId",
                table: "Colaboradores");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_UsuarioId",
                table: "Colaboradores",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_UsuarioId",
                table: "Colaboradores");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_UsuarioId",
                table: "Colaboradores",
                column: "UsuarioId",
                unique: true);
        }
    }
}
