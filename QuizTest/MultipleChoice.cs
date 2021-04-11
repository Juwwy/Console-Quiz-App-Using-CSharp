using System;
namespace QuizTest
{
    public class MultipleChoice : Question
    {

        public override string GetTest()
        {
            return "\nObjective Test :[Choose an answer]\n\nWho is the 46th president in USA?\n\n(a) Baldry Walter\n(b) Peter Joseph\n(c)Joe Biden\n(d)George Bush\n";
            // Console.WriteLine("Who is the 46th president in USA?");
            // string ans = Console.ReadLine();
        }

        public override string GetAnswer()
        {
           
            string ans = Console.ReadLine();
            if (ans == "c" || ans== "C")
            {
                Counter++;
                return "\nCorrect! Bravo you.\n";
            }else{
                return "\nWrong! You missed this.\n";
            }
        }
    }
}