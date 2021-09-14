using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP_.NET_Digital.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")] //tive que importar using System.ComponentModel.DataAnnotations;

        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "valor fora da faixa")]
        public int Quantidade { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

    }
}
