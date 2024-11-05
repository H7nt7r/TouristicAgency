using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Repositories;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelService(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public async Task<IEnumerable<Hotel>> GetAllHotels()
        {
            return await _hotelRepository.GetAllHotels();
        }

        public async Task<Hotel> GetHotelById(int id)
        {
            return await _hotelRepository.GetHotelById(id);
        }
        public async Task CreateHotel(Hotel hotel)
        {
            await _hotelRepository.CreateHotel(hotel);
        }

        public async Task UpdateHotel(Hotel hotel)
        {
            await _hotelRepository.UpdateHotel(hotel);
        }

        public async Task DeleteHotel(int id)
        {
            await _hotelRepository.DeleteHotel(id);
        }

    }
}
