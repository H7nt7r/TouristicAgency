using Microsoft.AspNetCore.Mvc;
using Touristic_agency.Entities;
using Touristic_agency.Interfaces.Services;

namespace Touristic_agency.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TourRouteController : ControllerBase
    {
        private readonly ITourRouteService _tourRouteService;

        public TourRouteController(ITourRouteService tourRouteService)
        {
            _tourRouteService = tourRouteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTourRoutes()
        {
            var tourRoutes = await _tourRouteService.GetAllTourRoutes();
            return Ok(tourRoutes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTourRoute(int id)
        {
            var tourRoute = await _tourRouteService.GetTourRouteById(id);
            if (tourRoute == null)
            {
                return NotFound();
            }
            return Ok(tourRoute);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTourRoute(TourRoute tourRoute)
        {
            await _tourRouteService.CreateTourRoute(tourRoute);
            return CreatedAtAction(nameof(GetTourRoute), new { id = tourRoute.Id }, tourRoute);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTourRoute(int id, TourRoute tourRoute)
        {
            if (id != tourRoute.Id)
            {
                return BadRequest();
            }
            await _tourRouteService.UpdateTourRoute(tourRoute);
            return Ok(tourRoute);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTourRoute(int id)
        {
            await _tourRouteService.DeleteTourRoute(id);
            return NoContent();
        }
    }
}
