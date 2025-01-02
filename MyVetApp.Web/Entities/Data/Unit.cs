using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class Unit
    {
        public int Id { get; set; }
        [Display(Name = "Medida")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
