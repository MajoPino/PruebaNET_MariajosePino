using System.ComponentModel.DataAnnotations;

namespace PruebaNET_MariajosePino.DTOs;
public class BookingDTO
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int RoomId { get; set; }

    [Required]
    public int GuestId { get; set; }

    [Required]
    public int EmployeeId { get; set; }

    [DataType(DataType.Date)]
    [Required]
    public DateTime StartDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime? EndDate { get; set; }

    [Required]
    public double TotalCost { get; set; }

    // Configuration of the foreign keys DTOs

    public required RoomDTO Room { get; set; }
    public required GuestDTO Guest { get; set; }
    public required EmployeeDTO Employee { get; set; }
}
