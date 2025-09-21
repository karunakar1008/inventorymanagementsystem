using System.ComponentModel.DataAnnotations;

namespace IMS.WebApp.ViewModels.ViewModelsValidations
{
    public class Sell_EnsureEnoughProductQuantity : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var sellViewModel = validationContext.ObjectInstance as SellViewModel;
            if (sellViewModel is not null)
            {
                if (sellViewModel.Product is not null)
                {
                    if (sellViewModel.Product.Quantity<sellViewModel.QuantityToSell)
                    {
                        return new ValidationResult($"There is not enough products. There is only {sellViewModel.Product.Quantity} in the warehouse",
                            new[] { validationContext.MemberName });
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}
