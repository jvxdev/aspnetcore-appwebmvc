using Integro.App.Extensions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Integro.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(200, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        [StringLength(1000, ErrorMessage = "Este campo deve ter entre {2} a {1} caracteres!", MinimumLength = 2)]
        public string Descricao { get; set; }

        [DisplayName("Imagem do produto")]
        public IFormFile ImagemUpload { get; set; }

        public string Imagem { get; set; }

        [Moeda]
        [Required(ErrorMessage = "Este campo não pode ficar em branco!")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public FornecedorViewModel Fornecedor { get; set; }

        public IEnumerable<FornecedorViewModel> Fornecedores { get; set; }
    }
}
