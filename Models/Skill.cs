using System.ComponentModel.DataAnnotations;
namespace PersonalPortfolio.Models
{
    public class Skill
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        [Required]
        [Range(1, 5)]
        public int ProficiencyLevel { get; set; }
    }
}