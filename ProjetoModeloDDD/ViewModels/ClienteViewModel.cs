using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório")]
        [MaxLength(150,ErrorMessage ="Máximo{0} caracteres")]
        [MinLength(2,ErrorMessage ="Minimo{0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo{0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo{0} caracteres")]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "E-mail é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo{0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo{0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um e-mail valido")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produto { get; set; }
    }
}