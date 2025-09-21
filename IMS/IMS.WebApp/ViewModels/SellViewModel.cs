using IMS.CoreBusiness;
using IMS.WebApp.ViewModels.ViewModelsValidations;
using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels
{
    public class SellViewModel
    {
        [Required]
        public string SalesOrderNumber { get; set; }=string.Empty;

        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="You have to select a product")]
        public int ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity has to be greater or equal to 1.")]
        [Sell_EnsureEnoughProductQuantity]
        public int QuantityToSell { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price has to be greater or equal to 0.")]
        public double UnitPrice { get; set; }

        public Product? Product { get; set; }
    }
}
