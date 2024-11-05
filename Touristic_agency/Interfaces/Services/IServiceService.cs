using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Services
{
    public interface IServiceService
    {
        Task<IEnumerable<Service>> GetAllServices();
        Task<Service> GetServiceById(int id);
        Task CreateService(Service service);
        Task UpdateService(Service service);
        Task DeleteService(int id);
    }
}
