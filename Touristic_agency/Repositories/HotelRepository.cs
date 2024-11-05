using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;
using Touristic_agency.Infrastructure.Data;
using Touristic_agency.Interfaces.Repositories;

namespace Touristic_agency.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly Touristic_agencyContext _context;

        public HotelRepository(Touristic_agencyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            return await _context.Hotels.FindAsync(id);
        }

        public async Task CreateHotel(Hotel hotel)
        {
            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotel(int id)
        {
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel != null)
            {
                _context.Hotels.Remove(hotel);
                await _context.SaveChangesAsync();
            }
        }

    }
}
