namespace ConnectionToSQL.Models
{
    public class ClaimFormViewModel
    {
        // Personal Details
        public required string LecturerName { get; set; }
        public required string LecturerSurname { get; set; }
        public required string EmployeeNo { get; set; }
        public required string ContactDetails { get; set; }

        // Claim Details
        public required string Module { get; set; }
        public required string Programme { get; set; }
        public int NumberOfHours { get; set; }
        public decimal HourlyRate { get; set; }

        // Supporting Document
        public required IFormFile SupportingDocument { get; set; }
    }
}