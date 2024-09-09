using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }  // Primary Key

        [Required]
        public int LecturerID { get; set; }  // Foreign key from Lecturer

        [Required]
        [Range(0, 1000, ErrorMessage = "Hours worked must be between 0 and 1000.")]
        public int HoursWorked { get; set; }

        [Range(0, double.MaxValue)]
        public decimal ClaimAmount { get; set; }  // Calculated Amount

        [Required]
        [StringLength(50)]
        public string Status { get; set; } = "Pending";  // Default status is "Pending"

        // Method to calculate claim amount based on hourly rate
        public void CalculateClaimAmount(decimal hourlyRate)
        {
            ClaimAmount = HoursWorked * hourlyRate;
        }
    }
}
