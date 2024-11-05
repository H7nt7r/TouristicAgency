using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Repositories;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Services
{
    public class TourRouteService : ITourRouteService
    {
        private readonly ITourRouteRepository _tourRouteRepository;

        public TourRouteService(ITourRouteRepository tourRouteRepository)
        {
            _tourRouteRepository = tourRouteRepository;
        }

        public async Task<IEnumerable<TourRoute>> GetAllTourRoutes()
        {
            return await _tourRouteRepository.GetAllTourRoutes();
        }

        public async Task<TourRoute> GetTourRouteById(int id)
        {
            return await _tourRouteRepository.GetTourRouteById(id);
        }
        public async Task CreateTourRoute(TourRoute tourRoute)
        {
            await _tourRouteRepository.CreateTourRoute(tourRoute);
        }

        public async Task UpdateTourRoute(TourRoute tourRoute)
        {
            await _tourRouteRepository.UpdateTourRoute(tourRoute);
        }

        public async Task DeleteTourRoute(int id)
        {
            await _tourRouteRepository.DeleteTourRoute(id);
        }

    }
}
