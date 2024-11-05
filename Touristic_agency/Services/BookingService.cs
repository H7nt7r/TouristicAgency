using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Repositories;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _bookingRepository.GetAllBookings();
        }

        public async Task<Booking> GetBookingById(int id)
        {
            return await _bookingRepository.GetBookingById(id);
        }
        public async Task CreateBooking(Booking booking)
        {
            await _bookingRepository.CreateBooking(booking);
        }

        public async Task UpdateBooking(Booking booking)
        {
            await _bookingRepository.UpdateBooking(booking);
        }

        public async Task DeleteBooking(int id)
        {
            await _bookingRepository.DeleteBooking(id);
        }

    }
}
