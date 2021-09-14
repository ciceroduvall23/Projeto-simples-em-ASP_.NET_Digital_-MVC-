using Microsoft.EntityFrameworkCore.Migrations;

namespace Curso_ASP_.NET_Digital.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)//UP onde ele vai criar a tabela 
        {    //Aqui vamos ter o historico de atualizações no banco 
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) //Down onde ele vai desfazer a tabela 
        {
            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
