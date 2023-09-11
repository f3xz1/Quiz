namespace Quiz.Areas.Identity.Data
{
    public class Quiz
    {
        public int Id { get; set; }
        public string TheamName { get; set; }
        public User Author { get; set; }
        List<Question> questions { get; set; }
    }
}
