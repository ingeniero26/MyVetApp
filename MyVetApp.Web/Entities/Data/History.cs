using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class History
    {
        public int Id { get; set; }
        [Display(Name = "Descripción Historia")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Date*")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }

        public string Remarks { get; set; }

        [Display(Name = "Fecha Nacimiento*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime DateLocal => Date.ToLocalTime();

        public ServiceType ServiceType { get; set; }

        public Pet Pet { get; set; }
    }

}

