using System.ComponentModel.DataAnnotations;

namespace MyVetApp.Web.Entities.Data
{
    public class Taxes
    {
        public int Id { get; set; }
        [Display(Name = "Impuesto")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string NameTaxes { get; set; }
        [Display(Name = "Tarifa")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public double Rate { get; set; }

        public TaxesType TaxesType { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
