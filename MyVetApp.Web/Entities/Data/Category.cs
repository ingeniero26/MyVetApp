using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Categoria")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string NameCategory { get; set; }
        [Display(Name = "Descripciòn")]
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
