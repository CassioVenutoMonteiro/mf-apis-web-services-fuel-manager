using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_apis_web_services_fuel_manager.Migrations
{
    public partial class M011 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Usuarios",
                newName: "Nome");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
         

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "Name");
        }
    }
}
