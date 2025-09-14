using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Data
{
    public class Quiz
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(1, int.MaxValue)]
        public int CategoryId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime PublishedAt { get; set; }
        public bool IsPublished { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }
        public int Played { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public string CreatedById { get; set; } = string.Empty;

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; }
        [ForeignKey("CreatedById")]
        public ApplicationUser? CreatedBy { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();
    }
}