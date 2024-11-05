using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Repositories;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Services
{
    public class BookingServiceService : IBookingServiceService
    {
        private readonly IBookingServiceRepository _bookingServiceRepository;

        public BookingServiceService(IBookingServiceRepository bookingServiceRepository)
        {
            _bookingServiceRepository = bookingServiceRepository;
        }

        public async Task<IEnumerable<Entities.BookingService>> GetAllBookingServices()
        {
            return await _bookingServiceRepository.GetAllBookingServices();
        }

        public async Task<Entities.BookingService> GetBookingServiceById(int id)
        {
            return await _bookingServiceRepository.GetBookingServiceById(id);
        }
        public async Task CreateBookingService(Entities.BookingService bookingService)
        {
            await _bookingServiceRepository.CreateBookingService(bookingService);
        }

        public async Task UpdateBookingService(Entities.BookingService bookingService)
        {
            await _bookingServiceRepository.UpdateBookingService(bookingService);
        }

        public async Task DeleteBookingService(int id)
        {
            await _bookingServiceRepository.DeleteBookingService(id);
        }

    }
}
