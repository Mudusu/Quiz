using System.ComponentModel.DataAnnotations.Schema;

namespace Quiz.Data
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public int Points { get; set; } = 1;

        [ForeignKey("QuizId")]
        public Quiz? Quiz { get; set; }
        public List<Option> Options { get; set; } = new List<Option>();
    }
}