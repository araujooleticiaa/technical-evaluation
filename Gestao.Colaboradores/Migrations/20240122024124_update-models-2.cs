using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestao.Colaboradores.Migrations
{
    /// <inheritdoc />
    public partial class updatemodels2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Usuarios_UsuarioId",
                table: "Colaboradores");

            migrationBuilder.AlterColumn<Guid>(
                name: "UsuarioId",
                table: "Colaboradores",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UnidadeId",
                table: "Colaboradores",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores",
                column: "UnidadeId",
                principalTable: "Unidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Usuarios_UsuarioId",
                table: "Colaboradores",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Usuarios_UsuarioId",
                table: "Colaboradores");

            migrationBuilder.AlterColumn<Guid>(
                name: "UsuarioId",
                table: "Colaboradores",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "UnidadeId",
                table: "Colaboradores",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Unidade_UnidadeId",
                table: "Colaboradores",
                column: "UnidadeId",
                principalTable: "Unidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Usuarios_UsuarioId",
                table: "Colaboradores",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
