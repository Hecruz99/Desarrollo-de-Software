using Microsoft.EntityFrameworkCore.Migrations;

namespace persistencia.Migrations
{
    public partial class t_cliente_tecnico_automovil_camineta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_personas",
                table: "personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carros",
                table: "carros");

            migrationBuilder.RenameTable(
                name: "personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "carros",
                newName: "Carro");

            migrationBuilder.AddColumn<int>(
                name: "Cedula",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "Persona",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carro",
                table: "Carro",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carro",
                table: "Carro");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Persona");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "personas");

            migrationBuilder.RenameTable(
                name: "Carro",
                newName: "carros");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personas",
                table: "personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carros",
                table: "carros",
                column: "Id");
        }
    }
}
