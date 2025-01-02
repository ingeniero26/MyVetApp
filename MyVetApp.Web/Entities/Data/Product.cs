using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyVetApp.Web.Entities.Data
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }
        [Display(Name = "Codigo Barra")]
        public string BarCode { get; set; }
        [Display(Name = "Cantidad Inicial")]
        public int Quantity { get; set; }
        [Display(Name = "Precio Venta")]
        public float SalePrice { get; set; }
        [Display(Name = "Precio Compra")]
        public float PurchasePrice { get; set; }
        [Display(Name = "Fecha Creado")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd H:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime DateManufacture { get; set; }
        [Display(Name = "Fecha Vencimiento")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        public DateTime ExpiryDate { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public Unit Unit { get; set; }
        public Taxes Taxes { get; set; }

        [Display(Name = "Fecha*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => DateManufacture.ToLocalTime();

        [Display(Name = "Fecha Vencimiento*")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocalExpire => ExpiryDate.ToLocalTime();

    }
}
