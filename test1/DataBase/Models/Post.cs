
using System.ComponentModel.DataAnnotations.Schema;

namespace test1.DataBase.Models
{
    [Table("posts")]
    public class Post { [Column("id")] public int Id { get; set; } [Column("name")] public string Name { get; set; } }
}
