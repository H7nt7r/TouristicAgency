using Microsoft.EntityFrameworkCore;
using Touristic_agency.Entities;
using Touristic_agency.Infrastructure.Data;
using Touristic_agency.Interfaces.Repositories;

namespace Touristic_agency.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Touristic_agencyContext _context;

        public ServiceRepository(Touristic_agencyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Service>> GetAllServices()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<Service> GetServiceById(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task CreateService(Service service)
        {
            await _context.Services.AddAsync(service);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateService(Service service)
        {
            _context.Services.Update(service);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteService(int id)
        {
            var service = await _context.Services.FindAsync(id);
            if (service != null)
            {
                _context.Services.Remove(service);
                await _context.SaveChangesAsync();
            }
        }

    }
}
