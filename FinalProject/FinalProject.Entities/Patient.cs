using System.ComponentModel.DataAnnotations;

namespace FinalProject.Entities
{
    public class Patient
    {
        [Required]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Aadhar ID must be exactly 12 digits.")]
        [RegularExpression(@"^\d{12}$", ErrorMessage = "Aadhar ID must contain only digits.")]
        public string AadharId { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Disease { get; set; } = string.Empty;

        public List<string> Symptoms { get; set; } = new List<string>();

        public string RoomNumber { get; set; } = string.Empty;

        public DateTime AdmissionDateTime { get; set; }

        public decimal InitialDeposit { get; set; }
    }

}
