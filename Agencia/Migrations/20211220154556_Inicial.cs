using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Agencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DestinoId",
                table: "Reservas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_DestinoId",
                table: "Reservas",
                column: "DestinoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Destino_DestinoId",
                table: "Reservas",
                column: "DestinoId",
                principalTable: "Destino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Destino_DestinoId",
                table: "Reservas");

            migrationBuilder.DropIndex(
                name: "IX_Reservas_DestinoId",
                table: "Reservas");

            migrationBuilder.DropColumn(
                name: "DestinoId",
                table: "Reservas");
        }
    }
}
