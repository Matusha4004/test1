using System.ComponentModel.DataAnnotations.Schema;

namespace test1.DataBase.Models
{
    [Table("deps")]
    public class Dep { [Column("id")] public int Id { get; set; } [Column("name")] public string Name { get; set; } }
}