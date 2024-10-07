using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaNET_MariajosePino.Models;

[Table("employees")]
public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public required string FirstName { get; set; }

    [Column("last_name")]
    [Required]
    [MaxLength(50)]
    [MinLength(2)]
    public required string LastName { get; set; }

    [Column("email")]
    [Required]
    [MaxLength(255)]
    [MinLength(10)]
    public required string Email { get; set; }

    [Column("identification_number")]
    [Required]
    [MaxLength(20)]
    [MinLength(15)]
    public required string IdentificationNumber { get; set; }

    [Column("password")]
    [Required]
    [MaxLength(255)]
    [MinLength(8)]
    public required string Password { get; set; }

    public Employee(int id, string firstName, string lastName, string email, string identificationNumber, string password)
    {
        Id = id;
        FirstName = firstName.ToLower().Trim();
        LastName = lastName.ToLower().Trim();
        Email = email.ToLower().Trim();
        IdentificationNumber = identificationNumber.ToLower().Trim();
        Password = password.ToLower().Trim();
    }
}
