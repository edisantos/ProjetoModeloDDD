using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Produto é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo{0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo{0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        [Range(typeof(decimal),"0","9999999")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }

        [Display(Name ="Disponivel?")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}