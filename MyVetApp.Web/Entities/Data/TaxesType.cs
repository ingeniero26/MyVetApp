using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class TaxesType
    {
        public int Id { get; set; }
        [Display(Name = "Tipo Impuesto")]
        [MaxLength(20, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string NameTaxesType { get; set; }

        public ICollection<Taxes> Taxes { get; set; }
    }
}
