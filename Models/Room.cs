using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_MariajosePino.Models;


[Table("rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("room_number")]
    [Required]
    [MaxLength(10)]
    public required string RoomNumber { get; set; }

    [Column("room_type_id")]
    [ForeignKey("RoomType")]
    [Required]
    public int RoomTypeId { get; set; }

    [Column("price_per_night")]
    [Required]
    public double PricePerNight { get; set; }

    [Column("availability")]
    [Required]
    public bool Availability { get; set; }

    [Column("max_occupancy_persons")]
    [Required]
    public byte MaxOccupancyPersons { get; set; }

    // Navigation property for the management of foreign key
    public virtual required RoomType RoomType { get; set; }

    public Room(int id, string roomNumber, int roomTypeId, double pricePerNight, bool availability, byte maxOccupancyPersons)
    {
        Id = id;
        RoomNumber = roomNumber.ToLower().Trim();
        RoomTypeId = roomTypeId;
        PricePerNight = pricePerNight;
        Availability = availability;
        MaxOccupancyPersons = maxOccupancyPersons;
    }
}
