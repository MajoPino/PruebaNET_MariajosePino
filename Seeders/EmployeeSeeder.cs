using Bogus;
using Microsoft.EntityFrameworkCore;
using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Seeders;
public class EmployeeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            //Create fake data for the seeder
            new Employee 
            { 
                Id = 1,
                FirstName = "Marc",
                LastName = "Spector",
                Email = "marc@gmail.com",
                IdentificationNumber = "12345",
                Password = "markitos"
                },
            new Employee 
            { 
                Id = 2,
                FirstName = "Steven",
                LastName = "Grant",
                Email = "steven@gmail.com",
                IdentificationNumber = "54321",
                Password = "stevenwithav"
                },
            new Employee 
            { 
                Id = 3,
                FirstName = "John",
                LastName = "MacTavish",
                Email = "soap@gmail.com",
                IdentificationNumber = "67890",
                Password = "soapisthebest"
                }
        );
    }

}
