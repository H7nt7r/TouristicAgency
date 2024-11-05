using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Repositories
{
    public interface IBookingServiceRepository
    {
        Task<IEnumerable<BookingService>> GetAllBookingServices();
        Task<BookingService> GetBookingServiceById(int id);
        Task CreateBookingService(BookingService bookingService);
        Task UpdateBookingService(BookingService bookingService);
        Task DeleteBookingService(int id);
    }
}
