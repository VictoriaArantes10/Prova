using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prova.Models
{
    public class Fornecedor
    {
        [Key]
        [Display(Name = "FornecedorId:")]
        public long id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Nome:")]

        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage ="Email inválido")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a rua")]
        [Display(Name = "Logradouro")]

        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Informe o número")]
        [Display(Name = "Número")]

        public string Numero { get; set; }

        [Required(ErrorMessage = "Informe o complemento")]
        [Display(Name = "Complemento")]

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe o bairro")]
        [Display(Name = "LBairro")]

        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe a cidade")]
        [Display(Name = "Cidade")]

        public string Cidade { get; set; }









    }
}
