using System.ComponentModel.DataAnnotations;
namespace PersonalPortfolio.Models
{
    public class ContactMessage
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Add Subject and Message properties with appropriate validation
        // Your code here
        [Required]
        [StringLength(200)]
        public string Subject { get; set; } = string.Empty;
        [Required]
        [StringLength(1000)]
        public string Message { get; set; } = string.Empty;
        public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

    }
}