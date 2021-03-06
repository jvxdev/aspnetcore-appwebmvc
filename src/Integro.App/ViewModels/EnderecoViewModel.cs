using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Integro.App.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(200, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(50, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        [DisplayName("Número")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(8, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 8)]
        [DisplayName("CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(100, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(100, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(50, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Estado { get; set; }

        [HiddenInput]
        public Guid FornecedorId { get; set; }
    }
}
