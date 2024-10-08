using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_MariajosePino.Models;

[Table("room_types")]
public class RoomType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public required string Name { get; set; }

    [Column("description")]
    [MaxLength(255)]
    public string? Description { get; set; }

    //Empty constructor for the seeder
    public RoomType() { }

    public RoomType(int id, string name, string? description = null)
    {
        Id = id;
        Name = name.ToLower().Trim();
        Description = description?.ToLower().Trim();
    }
}
