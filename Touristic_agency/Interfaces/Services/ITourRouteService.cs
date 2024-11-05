﻿using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Services
{
    public interface ITourRouteService
    {
        Task<IEnumerable<TourRoute>> GetAllTourRoutes();
        Task<TourRoute> GetTourRouteById(int id);
        Task CreateTourRoute(TourRoute tourRoute);
        Task UpdateTourRoute(TourRoute tourRoute);
        Task DeleteTourRoute(int id);
    }
}
