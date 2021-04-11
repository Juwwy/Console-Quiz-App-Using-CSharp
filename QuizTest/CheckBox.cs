using System;        
namespace QuizTest
{
    public class CheckBox : Question 
    {

        public override string GetTest()
        {
            return "\n\nCheckBox Test: Pick any Two options\n\nExample of an acquatic animal are?\n(a) Pig\n(b) Fish\n(c) Octopus\n(d) Parrot";  
        }

        public override string GetAnswer()
        {
            string ans = Console.ReadLine();

            if(ans == "bc" || ans == "BC" || ans == "b c" || ans == "B C" || ans == "cb" || ans == "CB" || ans == "c b" || ans == "C B" )
            {
                Counter++;
                return "\nCorrect! Bravo you\n";
            }else{
                return "\nWrong! you missed this\n";
            }
        }

    }
}