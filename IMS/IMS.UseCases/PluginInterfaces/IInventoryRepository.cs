using IMS.CoreBusiness;

namespace IMS.UseCases.PluginInterfaces
{
    public interface IInventoryRepository
    {
        Task AddInventoryAsync(Inventory inventory);
        Task DeleteInventoriesByIdAsync(int inventoryId);
        Task<Inventory> GetInventoriesByIdAsync(int inventoryId);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}
