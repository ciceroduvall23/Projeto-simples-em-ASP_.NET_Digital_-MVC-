using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_ASP_.NET_Digital.Models
{
    public class Categoria
    {
         public int id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage = "valor fora da caixa ")] //eu posso eestabelecer o valor minino e o valor maximo
        public List<Produto> produto{ get; set; }
    }
}
