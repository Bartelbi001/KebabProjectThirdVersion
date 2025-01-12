namespace KebabProjectV3.Domain.Common;

public abstract class BaseProductModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
}