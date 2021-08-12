using System;
using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.DTOs
{
    /// <summary>
    /// This is the DTO Item
    /// </summary>
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    /// <summary>
    /// This is the DTO Create Item
    /// </summary>
    public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);

    /// <summary>
    /// This is the DTO Update Item
    /// </summary>
    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);
}
