using System.ComponentModel.DataAnnotations.Schema;

namespace Touristic_agency.Entities
{
    public class BookingService
    {
        public int Id { get; set; }

        [ForeignKey("Booking")]
        public int Booking_id { get; set; }
        public Booking? Booking { get; set; }

        [ForeignKey("Service")]
        public int Service_id { get; set; }
        public Service? Service { get; set; }
    }
}
