using Play.Catalog.Service.Entities;

namespace Play.Catalog.Service.DTOs
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
            => new(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
    }
}
