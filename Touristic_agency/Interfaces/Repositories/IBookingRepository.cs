﻿using Touristic_agency.Entities;

namespace Touristic_agency.Interfaces.Repositories
{
    public interface IBookingRepository
    {
        Task<IEnumerable<Booking>> GetAllBookings();
        Task<Booking> GetBookingById(int id);
        Task CreateBooking(Booking booking);
        Task UpdateBooking(Booking booking);
        Task DeleteBooking(int id);
    }
}