using System.ComponentModel.DataAnnotations;

namespace Quiz.Data
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(200, MinimumLength = 10)]
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }
}