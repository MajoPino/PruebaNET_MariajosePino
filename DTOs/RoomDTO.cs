using System.ComponentModel.DataAnnotations;

namespace PruebaNET_MariajosePino.DTOs;

public class RoomDTO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(10)]
    public required string RoomNumber { get; set; }

    [Required]
    public int RoomTypeId { get; set; }

    [Required]
    public double PricePerNight { get; set; }

    [Required]
    public bool Availability { get; set; }

    [Required]
    public byte MaxOccupancyPersons { get; set; }

    //Configuration of the foreign key DTO
    public required RoomTypeDTO RoomType { get; set; }
}
