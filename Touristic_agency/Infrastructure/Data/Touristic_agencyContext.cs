using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;

namespace Touristic_agency.Infrastructure.Data
{
    public class Touristic_agencyContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<TourRoute> TourRoutes { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<BookingService> BookingServices { get; set; }

        public Touristic_agencyContext(DbContextOptions<Touristic_agencyContext> options)
        : base(options)
        { }
    }
}
