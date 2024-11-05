namespace Touristic_agency.Entities
{
    public class TourRoute
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Cost { get; set; }

        public string City { get; set; }

        public DateTime Startdate { get; set; }

        public DateTime Enddate { get; set; }

        public string Program { get; set; }
    }
}
