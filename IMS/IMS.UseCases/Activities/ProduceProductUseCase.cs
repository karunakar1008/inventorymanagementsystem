using IMS.CoreBusiness;
using IMS.UseCases.Activities.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Activities
{
    public class ProduceProductUseCase : IProduceProductUseCase
    {
        private readonly IProductTransactionRepository productTransactionRepository;
        private readonly IProductRepository productRepository;

        public ProduceProductUseCase(IProductTransactionRepository productTransactionRepository,
            IProductRepository productRepository)
        {
            this.productTransactionRepository = productTransactionRepository;
            this.productRepository = productRepository;
        }
        public async Task ExecuteAsync(string productionNumber, Product product, int quantity, string doneBy)
        {
            //add product transaction record
            //add inventory transaction record
            //decrease the quantity of inventories
            await this.productTransactionRepository.ProduceAsync(productionNumber, product, quantity, doneBy);

            //update the quantity of product
            product.Quantity += quantity;
            await this.productRepository.UpdateProductAsync(product);
        }
    }
}
