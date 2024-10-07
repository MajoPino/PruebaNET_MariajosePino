using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PruebaNET_MariajosePino.Models;

[Table("guests")]
public class Guest
{
    [Column("id")]
    [Key]
    public int Id { get; set; }

    [Column("first_name")]
    [Required]
    [MaxLength(255)]
    [MinLength(2)]
    public required string FirstName { get; set; }

    [Column("last_name")]
    [Required]
    [MaxLength(255)]
    [MinLength(3)]
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

    [Column("phone_number")]
    [Required]
    [MaxLength(20)]
    [MinLength(15)]
    public required string PhoneNumber { get; set; }

    [Column("birthdate")]
    [DataType(DataType.Date)]
    public DateTime? Birthdate { get; set; }
}
