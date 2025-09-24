
using System.ComponentModel.DataAnnotations.Schema;

namespace test1.DataBase.Models
{
    [Table("status")]
    public class Status { [Column("id")] public int Id { get; set; } [Column("name")] public string Name { get; set; } }
}