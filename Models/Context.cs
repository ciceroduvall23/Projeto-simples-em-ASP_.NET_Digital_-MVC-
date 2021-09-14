using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP_.NET_Digital.Models
{
    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; } //Categoria passando o tipo da classe,estou passando pra ele a tebale categoria

        public DbSet<Produto> produtos { get; set; } //agora adicione o migration novamente para atualizar o banco de dados para a nova imigração 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-OOKTGKQ\SQLEXPRESS;Initial Catalog=ubisoft;Integrated Security=True");
        }
    }
}
