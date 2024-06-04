using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

public class Accounts
{
    [Key]
    [Column("PK_account")] 
    public int PK_account { get; set; }
    
    
    [ForeignKey("Roles")]
    [Column("FK_role")] 
    public int FK_role { get; set; }
    
    public Roles Roles { get; set; }
    
    [Column("first_name")]
    [MaxLength(50)]
    public string first_name { get; set; }
    
    
    [Column("last_name")]
    [MaxLength(50)]
    public string last_name { get; set; }
    
    
    [Column("email")]
    [MaxLength(80)]
    public string email { get; set; }
    
    [Column("phone")]
    [MaxLength(9)]
    public string? phone { get; set; }
}