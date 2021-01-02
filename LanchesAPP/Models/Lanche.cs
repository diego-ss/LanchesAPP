
using System.ComponentModel.DataAnnotations;

namespace LanchesAPP.Models
{
    public class Lanche
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        [Display(Name = "Descrição Curta")]
        [StringLength(100)]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Descrição Detalhada")]
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }

        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "Necessário informar o valor do lanche!")]
        [Display(Name ="Preço")]
        public double Preco { get; set; }

        [StringLength(255)]
        public string ImagemUrl { get; set; }

        [StringLength(255)]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Lanche Preferido")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
