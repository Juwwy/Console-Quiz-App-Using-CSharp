using System;
namespace QuizTest
{
    public class BoolChoice : Question
    {
        // public BoolChoice(string test, string answer) 
        // {
           

        // }

        public override string GetTest()
        {
            return "\n\nTue/False Test : [Choose between a or b]\n\nIn the Cat family Cheetah is the fastest among all\n(a) True (b) False\n";
        }

        public override string GetAnswer()
        {

            string ans = Console.ReadLine();
           if(ans == "a" || ans == "A")
           {
               Counter++;
               return "\nCorrect! Bravo you.\n";
           }else{
               return "\nWrong! you missed this\n";
           }
        }
    }
}