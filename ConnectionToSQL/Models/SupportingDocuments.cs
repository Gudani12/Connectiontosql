using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    public class SupportingDocuments
    {
        public int DocumentID { get; set; }  // Primary Key

        [Required]
        public int ClaimID { get; set; }  // Foreign key from Claim

        [Required]
        [MaxLength(255)]
        public string FilePath { get; set; } = "";  // Path to the document file

        [MaxLength(100)]
        public string DocumentType { get; set; } = "";  // Type of document, e.g., "Invoice", "Timesheet"

        // Method to validate file path format (basic example)
        public bool IsValidFilePath()
        {
            return FilePath.EndsWith(".pdf") || FilePath.EndsWith(".jpg") || FilePath.EndsWith(".png");
        }
    }
}
