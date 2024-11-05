using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;
using Touristic_agency.Infrastructure.Data;
using Touristic_agency.Interfaces.Repositories;

namespace Touristic_agency.Repositories
{
    public class BookingServiceRepository : IBookingServiceRepository
    {
        private readonly Touristic_agencyContext _context;

        public BookingServiceRepository(Touristic_agencyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookingService>> GetAllBookingServices()
        {
            return await _context.BookingServices.ToListAsync();
        }

        public async Task<BookingService> GetBookingServiceById(int id)
        {
            return await _context.BookingServices.FindAsync(id);
        }

        public async Task CreateBookingService(BookingService bookingService)
        {
            await _context.BookingServices.AddAsync(bookingService);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBookingService(BookingService bookingService)
        {
            _context.BookingServices.Update(bookingService);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookingService(int id)
        {
            var bookingService = await _context.BookingServices.FindAsync(id);
            if (bookingService != null)
            {
                _context.BookingServices.Remove(bookingService);
                await _context.SaveChangesAsync();
            }
        }

    }
}
