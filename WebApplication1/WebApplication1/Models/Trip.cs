using System.ComponentModel.DataAnnotations;

namespace CarpoolingApp.Models
{
    public class Trip
    {
        public int Id { get; set; }

        [Required]
        public string StartLocation { get; set; } = "";

        [Required]
        public string EndLocation { get; set; } = "";

        // ✅ Proper date type
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        // ✅ Proper time type
        [Required]
        [DataType(DataType.Time)]
        public TimeSpan Time { get; set; }

        [Required]
        [Range(1, 100)]
        public int AvailableSeats { get; set; }

        public string DriverId { get; set; } = "";
        public ApplicationUser? Driver { get; set; }

        public List<Booking> Bookings { get; set; } = new();
    }
}
