using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

public class Products
{
    [Key]
    [Column("PK_product")]
    public int PK_product { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string name { get; set; }
    
    
    [Column("weight")]
    public decimal weight { get; set; }
    
    [Column("width")]
    public decimal width { get; set; }
    
    [Column("height")]
    public decimal height { get; set; }
    
    [Column("depth")]
    public decimal depth { get; set; }
}