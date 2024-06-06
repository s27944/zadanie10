using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zadanie10;

[Table("Roles")]
public class Roles
{
    [Key]
    [Column("PK_role")]
    public int RoleID { get; set; }

    [Column("name")]
    [MaxLength(100)]
    public string Name { get; set; }

    IEnumerable<Accounts> Accounts { get; set; }
}