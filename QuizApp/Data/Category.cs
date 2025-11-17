namespace QuizApp.Data
{
    public class Answer
    {
        public string answer_a { get; set; }
        public string answer_b { get; set; }
        public string answer_c { get; set; }
        public string answer_d { get; set; }
        public object answer_e { get; set; }
        public object answer_f { get; set; }
    }

    public class CorrectAnswer
    {
        public string answer_a_correct { get; set; }
        public string answer_b_correct { get; set; }
        public string answer_c_correct { get; set; }
        public string answer_d_correct { get; set; }
        public string answer_e_correct { get; set; }
        public string answer_f_correct { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string question { get; set; }
        public string description { get; set; }
        public Answer answers { get; set; }
        public string multiple_correct_answers { get; set; }
        public CorrectAnswer correct_answers { get; set; }
        public string explanation { get; set; }
        public object tip { get; set; }
        public List<object> tags { get; set; }
        public string category { get; set; }
        public string difficulty { get; set; }
    }
}
