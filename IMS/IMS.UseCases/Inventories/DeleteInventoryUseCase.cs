using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.PluginInterfaces;

namespace IMS.UseCases.Inventories
{
    public class DeleteInventoryUseCase : IDeleteInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }
        public async Task ExecuteAsync(int inventoryId)
        {
            await inventoryRepository.DeleteInventoriesByIdAsync(inventoryId);
        }
    }
}
