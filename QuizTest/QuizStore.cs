using System;
using System.Collections.Generic;
namespace QuizTest
{
    public class QuizStore 
    {
        public string NewQuiz { get; set; }
        public List<string> Options { get; set; }
        public string QuizAns { get; set; }
        public int Correct { get; set; } = 0;
        public int Wrong { get; set; } = 0;


        public QuizStore(string newQuiz, List<string> options, string quizAns)
        {
            NewQuiz = newQuiz;
            Options = options;
            QuizAns = quizAns;
        }

      

        public override string ToString()
        {
            string stringify = "";
            
            foreach (var opt in Options)
            {
                stringify += opt + " " ;
            }
            return $"{NewQuiz}\n{stringify}\n";
        }
        
    }
}