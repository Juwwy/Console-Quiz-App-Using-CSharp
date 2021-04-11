namespace QuizTest
{
    public abstract class Question
    {
        public string Test { get; set; }
        public string Answer { get; set; }
        public static int Counter { get; set; } = 0;


        public abstract string GetTest();
        public abstract string GetAnswer();
        public override string ToString()
        {
            return $"Your score counter is {Counter}/3";
        }
    }
}