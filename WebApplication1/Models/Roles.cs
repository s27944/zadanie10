using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

public class Roles
{
    [Key]
    [Column("PK_role")]
    public int PK_role { get; set; }
    
    [Column("name")]
    [MaxLength(100)]
    public string name { get; set; }
}