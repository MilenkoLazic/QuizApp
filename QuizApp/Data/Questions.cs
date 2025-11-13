namespace QuizApp.Data
{
    public class Questions
    {
        public int id;
        public string question;
        public string description;
        public List<String> answers;

        public String multiple_correct_answers;
        public List<string> correct_answers;
        public string explanation;
        public string category;
        public string difficulty;

    }
}
