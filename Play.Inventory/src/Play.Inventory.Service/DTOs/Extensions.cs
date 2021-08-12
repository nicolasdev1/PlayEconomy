using Play.Inventory.Service.Entities;

namespace Play.Inventory.Service.DTOs
{
    public static class Extensions
    {
        public static InventoryItemDto AsDto(this InventoryItem item, string name, string description)
            => new(item.CatalogItemId, name, description, item.Quantity, item.AcquiredDate);
    }
}
