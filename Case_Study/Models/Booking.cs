using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Case_Study.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int? ShowId { get; set; }
        public int TotalTickets { get; set; }
        public int SeatNo { get; set; }
        public double TotalCost { get; set; }
        public DateTime Date { get; set; }
        public string EventName { get; set; }
        public string VenueName { get; set; }
        public string UserName { get; set; }
        public string City { get; set; }
        public int StageNo { get; set; }
        public virtual User User { get; set; }
    }
}



