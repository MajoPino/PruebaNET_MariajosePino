using System.ComponentModel.DataAnnotations;

namespace PruebaNET_MariajosePino.DTOs;

public class EmployeeDTO
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public required string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    [MinLength(2)]
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
    [MaxLength(255)]
    [MinLength(8)]
    public required string Password { get; set; }
}
