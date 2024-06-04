using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

public class Products_Categories
{
    [Key]
    [ForeignKey("Products")]
    [Column("FK_product")]
    public int FK_product { get; set; }
    
    public Products Products { get; set; }
    
    [Key]
    [ForeignKey("Categories")]
    [Column("FK_category")]
    public int FK_category { get; set; }

    public Categories Categories { get; set; }
}