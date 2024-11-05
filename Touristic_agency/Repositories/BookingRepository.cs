using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;
using Touristic_agency.Infrastructure.Data;
using Touristic_agency.Interfaces.Repositories;

namespace Touristic_agency.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly Touristic_agencyContext _context;

        public BookingRepository(Touristic_agencyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<Booking> GetBookingById(int id)
        {
            return await _context.Bookings.FindAsync(id);
        }

        public async Task CreateBooking(Booking booking)
        {
            await _context.Bookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBooking(Booking booking)
        {
            _context.Bookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBooking(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
                await _context.SaveChangesAsync();
            }
        }

    }
}
