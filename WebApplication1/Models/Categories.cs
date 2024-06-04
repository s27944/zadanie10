using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Zadanie10;

public class Categories
{
    [Key]
    [Column("PK_category")]
    public int PK_category { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string name { get; set; }
    
}