using Microsoft.AspNetCore.Mvc;
using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingServiceController : ControllerBase
    {
        private readonly IBookingServiceService _bookingServiceService;

        public BookingServiceController(IBookingServiceService bookingServiceService)
        {
            _bookingServiceService = bookingServiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookingServices()
        {
            var bookingServices = await _bookingServiceService.GetAllBookingServices();
            return Ok(bookingServices);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingService(int id)
        {
            var bookingService = await _bookingServiceService.GetBookingServiceById(id);
            if (bookingService == null)
            {
                return NotFound();
            }
            return Ok(bookingService);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBookingService(BookingService bookingService)
        {
            await _bookingServiceService.CreateBookingService(bookingService);
            return CreatedAtAction(nameof(GetBookingService), new { id = bookingService.Id }, bookingService);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookingService(int id, BookingService bookingService)
        {
            if (id != bookingService.Id)
            {
                return BadRequest();
            }
            await _bookingServiceService.UpdateBookingService(bookingService);
            return Ok(bookingService);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookingService(int id)
        {
            await _bookingServiceService.DeleteBookingService(id);
            return NoContent();
        }
    }
}
