using System.ComponentModel.DataAnnotations;

namespace WebApplication1.RequestModels;

public class PostProductRequestModel
{
    [Required] [MaxLength(100)] public string ProductName { get; set; }

    [Range(0.01, double.MaxValue)] public decimal ProductWeight { get; set; }

    [Range(0.01, double.MaxValue)] public decimal ProductWidth { get; set; }

    [Range(0.01, double.MaxValue)] public decimal ProductHeight { get; set; }

    [Range(0.01, double.MaxValue)] public decimal ProductDepth { get; set; }

    [Required] [MinLength(1)] public List<int> ProductCategories { get; set; }
}