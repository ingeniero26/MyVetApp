using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class Brand
    {
        public int Id { get; set; }
        [Display(Name = "Marca")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string NameBrand { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
