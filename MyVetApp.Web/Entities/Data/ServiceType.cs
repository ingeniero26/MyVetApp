using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Display(Name = "Tipo Servicios")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Name { get; set; }

        public ICollection<ServiceType> Services { get; set; } = new HashSet<ServiceType>();
    }
}
