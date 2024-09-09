using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    public class Lecturer
    {
        public int LecturerID { get; set; }  // Primary Key

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = "";  // Lecturer Name

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Hourly rate must be a positive value.")]
        public decimal HourlyRate { get; set; }

        // Custom method to validate if HourlyRate is reasonable
        public bool IsHourlyRateValid()
        {
            return HourlyRate > 0 && HourlyRate <= 500; // Example limit
        }
    }
}
