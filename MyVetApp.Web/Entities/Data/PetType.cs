using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class PetType
    {
        public int Id { get; set; }
        [Display(Name = "Tipo Mascota")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Pet> Pets { get; set; }
    }
}
