using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestao.Colaboradores.Migrations
{
    /// <inheritdoc />
    public partial class updatemodels3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_UnidadeId",
                table: "Colaboradores");

            migrationBuilder.DropColumn(
                name: "UnidadeId",
                table: "Colaboradores");

            migrationBuilder.AddColumn<Guid>(
                name: "ColaboradorId",
                table: "Unidade",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Unidade_ColaboradorId",
                table: "Unidade",
                column: "ColaboradorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Unidade_Colaboradores_ColaboradorId",
                table: "Unidade",
                column: "ColaboradorId",
                principalTable: "Colaboradores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Unidade_Colaboradores_ColaboradorId",
                table: "Unidade");

            migrationBuilder.DropIndex(
                name: "IX_Unidade_ColaboradorId",
                table: "Unidade");

            migrationBuilder.DropColumn(
                name: "ColaboradorId",
                table: "Unidade");

            migrationBuilder.AddColumn<Guid>(
                name: "UnidadeId",
                table: "Colaboradores",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_UnidadeId",
                table: "Colaboradores",
                column: "UnidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores",
                column: "UnidadeId",
                principalTable: "Unidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
