using System.ComponentModel.DataAnnotations.Schema;

namespace Touristic_agency.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int User_id{get;set;}
        public User? User { get; set; }

        [ForeignKey("TourRoute")]
        public int Tourroute_id { get;set;}
        public TourRoute? TourRoute { get; set; }

        [ForeignKey("Hotel")]
        public int Hotel_id { get; set;}
        public Hotel? Hotel { get; set; }

        public string Status { get; set;}
    }

}
