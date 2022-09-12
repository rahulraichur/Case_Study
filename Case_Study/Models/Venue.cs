using System.ComponentModel.DataAnnotations;

namespace Case_Study.Models
{
    public class Venue
    {
            
        [Key]
       
        public string VenueName { get; set; }
        public string City { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int VenueStage { get; set; }
    }
}

