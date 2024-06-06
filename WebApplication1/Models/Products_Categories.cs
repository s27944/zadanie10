using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

[Table("Products_Categories")]
public class Products_Categories
{
    [ForeignKey("Products")]
    [Column("FK_product")]
    public int ProductId { get; set; }
    public Products Products { get; set; }

    [ForeignKey("Categories")]
    [Column("FK_category")]
    public int CategoryId { get; set; }
    public Categories Categories { get; set; }
}