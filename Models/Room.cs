namespace PruebaNET_MariajosePino.Models;

public class Room
{
    public int Id { get; set; }
    public int RoomNumber { get; set; }
    public int RoomTypeId { get; set; }
    public double PricePerNight { get; set; }
    public bool Availability { get; set; }
    public byte MaxOccupancyPersons { get; set; }
}
