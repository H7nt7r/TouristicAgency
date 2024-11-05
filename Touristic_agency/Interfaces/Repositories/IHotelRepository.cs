using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Repositories
{
    public interface IHotelRepository
    {
        Task<IEnumerable<Hotel>> GetAllHotels();
        Task<Hotel> GetHotelById(int id);
        Task CreateHotel(Hotel hotel);
        Task UpdateHotel(Hotel hotel);
        Task DeleteHotel(int id);
    }
}
