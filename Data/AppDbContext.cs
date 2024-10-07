using Microsoft.EntityFrameworkCore;
using PruebaNET_MariajosePino.Models;

namespace PruebaNET_MariajosePino.Data;

public class AppDbContext : DbContext
{
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
}
