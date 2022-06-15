using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class Produto
    {
        [Key]
        [Display(Name = "ProdutoId:")]
        public long id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Nome:")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição")]
        [Display(Name = "Descrição:")]

        public string Descricao { get; set; }
    }
}