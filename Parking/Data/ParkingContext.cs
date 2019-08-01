using Microsoft.EntityFrameworkCore;


namespace Parking.Models
{
    public class ParkingContext : DbContext
    {

        public ParkingContext(DbContextOptions<ParkingContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; }

    }
}
