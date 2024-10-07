using System.ComponentModel.DataAnnotations;

namespace PruebaNET_MariajosePino.DTOs;
public class RoomTypeDTO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public required string Name { get; set; }

    [MaxLength(255)]
    public string? Description { get; set; }
}
