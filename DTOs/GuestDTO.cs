using System.ComponentModel.DataAnnotations;

namespace PruebaNET_MariajosePino.DTOs;
public class GuestDTO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    [MinLength(2)]
    public required string FirstName { get; set; }

    [Required]
    [MaxLength(255)]
    [MinLength(3)]
    public required string LastName { get; set; }

    [Required]
    [MaxLength(255)]
    [MinLength(10)]
    public required string Email { get; set; }

    [Required]
    [MaxLength(20)]
    [MinLength(15)]
    public required string IdentificationNumber { get; set; }

    [Required]
    [MaxLength(20)]
    [MinLength(15)]
    public required string PhoneNumber { get; set; }

    [DataType(DataType.Date)]
    public DateTime? Birthdate { get; set; }
}
