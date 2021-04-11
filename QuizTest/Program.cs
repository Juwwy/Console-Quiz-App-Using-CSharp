using System;
using System.Collections.Generic;

namespace QuizTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var tester = new MultipleChoice();
            var testee = new CheckBox();
            var testee2 = new BoolChoice();


           Console.Write($"{tester.GetTest()}\n");
           Console.Write($"{tester.GetAnswer()}\n");
           Console.Write($"{tester}");

           Console.Write($"{testee.GetTest()}\n");
           Console.Write($"{testee.GetAnswer()}\n");
           Console.Write($"{tester}");

           Console.Write($"{testee2.GetTest()}\n");
           Console.Write($"{testee2.GetAnswer()}\n");
           Console.Write($"{tester}\n");

           try
           {
            while(true)
            {
                QuizStore[] quizCatalogue = new QuizStore[20];
                int num = 0;
                int ansCount = 0;
                int score = 0;
                

                Console.Write("\nEnter an Option for Qiuz [Add | Choose | Quit]\n");
                string command = Console.ReadLine();

                if(command == "add" || command == "Add")
                {
                    while(true)
                    {
                        Console.Write("\nEnter your question below:\n");
                    string newQuiz = Console.ReadLine();
                    List<string> options = Opt();
                    Console.Write("\nEnter your possible answer below:\n");
                    string quizAns = Console.ReadLine();

                    QuizStore quiz = new QuizStore(newQuiz, options, quizAns);

                    if(num < 20)
                    {
                        quizCatalogue[num] = quiz;
                        num++;
                    }else{
                        Console.WriteLine("\nQuiz store is full\n");
                    }

                    while(true)
                    {

                    

                    Console.WriteLine("Add more quiz | Answer quiz | Scores | Back ?\n");
                    string response = Console.ReadLine();
                    if(response == "answer" || response == "answer quiz" || response == "Answer" || response == "Answer quiz")
                    {
                        if(num > 0)
                    {
                        
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine($"{quizCatalogue[i]}");
                            Console.WriteLine($"Enter your answer below: ");
                            string ans = Console.ReadLine();
                            
                            if(ans == quizCatalogue[i].QuizAns)
                            {
                                score+=5;
                                Console.WriteLine("Correct! Bravo you.");
                            }else{
                                
                                Console.Write("Wrong! You missed");
                            }
                        }
                    }else{
                        Console.WriteLine("Quiz Cataloque is empty! Try and add quiz or select 'Choose'\n to play default games");
                    }
                    }else if(response == "add" || response == "Add")
                    {
                        Console.WriteLine("Ok keep adding quiz");
                        break;
                    }else if(response == "scores" || response== "Scores" || response == "score")
                    {
                        if(score != 0)
                        {
                            if(score >=70 && score <=100 )
                            {
                                Console.Write($"Your score is {score}: grade is A\n");
                            }else if(score>=60 && score <=69)
                            {
                                Console.Write($"Your score is {score}: grade is B\n");
                            }else if(score >=50 && score <=59)
                            {
                                Console.Write($"Your score is {score}: grade is C\n");
                            }else{
                                Console.Write($"You have scores of {score} which is below average. Try add more question and try again\n");
                            }
                        }else{
                            Console.WriteLine("No record found for Quiz score. Please add question or play\n the default choose game on the main menu.\n");
                        }
                    }else if(response=="Back" || response == "back")
                    {
                        break;
                    }else{
                        Console.WriteLine($"{response} is not valid");
                    }
                    }
                    Console.Write("Back to Main Menu? \ny/n: ");
                    string confirm = Console.ReadLine();
                    if(confirm == "y")
                    {
                        break;
                    }else{
                        continue;
                    }
                    }
                
                }else if(command == "choose" || command == "Choose")
                {
                    
                    for (int i = 0; i < 3; i++)
                    {
                    Console.Write("\nChoose a number between 1-3 for Quiz\n");
                    int ans = int.Parse(Console.ReadLine());
                    if(ans <= 3)
                    {
                    switch(ans)
                    {
                        case 1:
                        Console.WriteLine("\nIn JavaScript with what keyword can we declare a variable with?\n(a) declare\n(b) open()\n(c) let\n(d) key\n");
                        string response = Console.ReadLine();
                        if(response == "c" || response == "C")
                        {
                            ansCount++;
                            Console.WriteLine("Correct! Bravo you");
                        }else{
                            Console.WriteLine("Wrong! You missed");
                        }
                        break;

                        case 2:
                        Console.WriteLine("\nWhich of the following country can be referred to as a world power?\n(a) Peru\n(b) Australia\n(c)Cyprus\n(d) United Kingdom\n"); 
                        response = Console.ReadLine();
                        if(response == "d" || response == "D")
                        {
                            ansCount++;
                            Console.WriteLine("Correct! Bravo you");
                        }else{
                            Console.WriteLine("Wrong! You missed");
                        }
                        break;

                        case 3:
                        Console.WriteLine("\nThe full meaning of CSS acronym in the CSS3 language is?\n(a) Cast Style Set-up\n(b) Cascading Style Sheet\n(c) Casding Style Sheet\n(d) CastCading Styling Sheets"); 
                        response = Console.ReadLine();
                        if(response == "b" || response == "B")
                        {
                            ansCount++;
                            Console.WriteLine("\nCorrect! Bravo you\n");
                        }else{
                            Console.WriteLine("\nWrong! You missed\n");
                        }
                        break;

                        default:
                        Console.WriteLine("\nPlease enter a valid number within the range\n");
                        break;

                    }
                    }
                }
                if(ansCount == 3)
                    {
                        Console.WriteLine("\nYour Quiz Grade Score is A (Excellent)\n");
                    }else if(ansCount == 2)
                    {
                        Console.WriteLine("\nYour Quiz Grade Score is B (Very Good)\n");
                    }else if(ansCount == 1)
                    {
                        Console.WriteLine("\nYour Quiz Grade Score is C (fair)\n");
                    }else{
                        Console.WriteLine("\nSorry you fail!\n");
                    }
                }else if(command == "Quit" || command == "quit")
                {
                    Console.WriteLine("Thanks and Bye!");
                    break;
                }else{
                    Console.WriteLine($"{command} is not acceptaple. Please enter a valid input");
                }
            }
           }
           catch (System.Exception e)
           {
               
               Console.WriteLine(e.Message);
           }
           
        }

        static List<string> Opt()
        {
            List<string> optList = new List<string>();
            for (int i = 0; i < 4; i++)
            {
            Console.Write("\nEnter your options below:\n");
            string optQuiz = Console.ReadLine();
            optList.Add(optQuiz);
            }
            return optList;
        }
     }
}
