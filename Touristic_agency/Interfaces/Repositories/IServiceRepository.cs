using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Repositories
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>> GetAllServices();
        Task<Service> GetServiceById(int id);
        Task CreateService(Service service);
        Task UpdateService(Service service);
        Task DeleteService(int id);
    }
}
