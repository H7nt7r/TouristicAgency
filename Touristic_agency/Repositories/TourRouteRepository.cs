using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;
using Touristic_agency.Infrastructure.Data;
using Touristic_agency.Interfaces.Repositories;

namespace Touristic_agency.Repositories
{
    public class TourRouteRepository : ITourRouteRepository
    {
        private readonly Touristic_agencyContext _context;

        public TourRouteRepository(Touristic_agencyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TourRoute>> GetAllTourRoutes()
        {
            return await _context.TourRoutes.ToListAsync();
        }

        public async Task<TourRoute> GetTourRouteById(int id)
        {
            return await _context.TourRoutes.FindAsync(id);
        }

        public async Task CreateTourRoute(TourRoute tourRoute)
        {
            await _context.TourRoutes.AddAsync(tourRoute);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTourRoute(TourRoute tourRoute)
        {
            _context.TourRoutes.Update(tourRoute);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTourRoute(int id)
        {
            var tourRoute = await _context.TourRoutes.FindAsync(id);
            if (tourRoute != null)
            {
                _context.TourRoutes.Remove(tourRoute);
                await _context.SaveChangesAsync();
            }
        }

    }
}
