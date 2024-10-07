using Microsoft.EntityFrameworkCore;
using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Seeders;
public class GuestSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>().HasData(
            //Create fake data for the seeder
            new Guest
            {
                Id = 1,
                FirstName = "Jhonatan",
                LastName = "Toro",
                Email = "jtorova@gmail.com",
                IdentificationNumber = "338844",
                PhoneNumber = "555-123-4567",
                Birthdate = new DateTime(1990, 5, 15)
            },
            new Guest
            {
                Id = 2,
                FirstName = "Julian",
                LastName = "Forero",
                Email = "tribog@gmail.com",
                IdentificationNumber = "533525",
                PhoneNumber = "555-987-6543",
                Birthdate = new DateTime(1985, 8, 10)
            },
            new Guest
            {
                Id = 3,
                FirstName = "Isabella",
                LastName = "Vargas",
                Email = "ivargas@gmail.com",
                IdentificationNumber = "694206",
                PhoneNumber = "555-789-0123",
                Birthdate = new DateTime(1995, 12, 25)
            },
            new Guest
            {
                Id = 4,
                FirstName = "Gabriel",
                LastName = "Hernandez",
                Email = "gabohernandez@gmail.com",
                IdentificationNumber = "762138",
                PhoneNumber = "555-456-7890",
                Birthdate = new DateTime(1980, 3, 12)
            }
        );
    }
}
