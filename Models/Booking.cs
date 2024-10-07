using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_MariajosePino.Models;


[Table("bookings")]
public class Booking
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("room_id")]
    [ForeignKey("Room")]
    [Required]
    public int RoomId { get; set; }

    [Column("guest_id")]
    [ForeignKey("Guest")]
    [Required]
    public int GuestId { get; set; }

    [Column("employee_id")]
    [ForeignKey("Employee")]
    [Required]
    public int EmployeeId { get; set; }

    [Column("start_date")]
    [DataType(DataType.Date)]
    [Required]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    [DataType(DataType.Date)]
    public DateTime? EndDate { get; set; }

    [Column("total_cost")]
    [Required]
    public double TotalCost { get; set; }

    // Navigation properties for the management of foreign keys
    public virtual required Room Room { get; set; }  
    public virtual required Guest Guest { get; set; } 
    public virtual required Employee Employee { get; set; } 
}
