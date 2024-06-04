using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

public class Shopping_Carts
{
    [Key]
    [ForeignKey("Accounts")]
    [Column("FK_account")]
    public int FK_account { get; set; }

    public Accounts Accounts { get; set; }
    
    
    [Key]
    [ForeignKey("Products")]
    [Column("FK_product")]
    public int FK_product { get; set; }

    public Products Products { get; set; }
    
    
    [Column("amount")]
    public int amount { get; set; }

}