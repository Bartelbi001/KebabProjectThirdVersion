using KebabProjectV3.Domain.Models;

namespace KebabProjectV3.Domain.Common;

public abstract class BaseProductModel
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public Image? TitleImage { get; set; }
    public int Weight { get; set; }
}