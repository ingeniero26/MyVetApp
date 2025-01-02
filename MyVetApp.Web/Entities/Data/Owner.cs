using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Document { get; set; } = string.Empty;
        [Display(Name = "Nombre")]
        [MaxLength(80, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string FirstName { get; set; }
        [Display(Name = "Apellidos")]
        [MaxLength(80, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string LastName { get; set; }
        [Display(Name = "Teléfono")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string FixedPhone { get; set; }
        [Display(Name = "Celular")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Direccion")]
        [MaxLength(100, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        public string Address { get; set; }
        [Display(Name = "Correo")]
        [MaxLength(200, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Email { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Pet> Pets { get; set; }
       


    }
}
