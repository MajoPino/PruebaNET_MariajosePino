using Microsoft.EntityFrameworkCore;
using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Seeders;
public class RoomTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoomType>().HasData(
            //Create fake data for the seeder
            new RoomType
            {
                Id = 1,
                Name = "Simple Room",
                Description = "A basic cozy room with a single sized bed, ideal for single travelers."
            },
            new RoomType
            {
                Id = 2,
                Name = "Double Room",
                Description = "Offer flexibility with two single sized beds or one double sized bed, perfect for couples or friends."
            },
            new RoomType
            {
                Id = 3,
                Name = "Suite",
                Description = "Spacious and luxurious, with a king sized bed and a separated living room, ideal for those who look for comfort and exclusivity."
            },
            new RoomType
            {
                Id = 4,
                Name = "Familiar Room",
                Description = "Designed for families, with additional space and several beds for a comfortable stance."
            }
        );
    }
}
