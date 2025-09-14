using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Data
{
    public class Option
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; } = string.Empty;
        public bool IsCorrect { get; set; }

        [ForeignKey("QuestionId")]
        public Question? Question { get; set; }
    }
}