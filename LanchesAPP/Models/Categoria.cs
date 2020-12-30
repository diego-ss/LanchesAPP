using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanchesAPP.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Necessário informar o nome da categoria!")]
        [Display(Name = "Nome Categoria")]
        public string CategoriaNome { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "Necessário informar a descrição da categoria!")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
