namespace quizApp.Models
{
    public class QuizItem
    {
        //[Name("question")]
        public string? Question { get; set; }
        //[Name("answerPossibilities")]
        public List<string>? AnswerPossibilities { get; set; }
        //[Name("rightAnswer")]
        public string? RightAnswer { get; set; }
        //[Name("hint")]
        public string? Hint { get; set; }
        public QuizItem(string question, List<string> answerPossibilities, string rightAnswer, string hint)
        {
            Question = question;
            AnswerPossibilities = answerPossibilities;
            RightAnswer = rightAnswer;
            Hint = hint;
        }
    }
}