using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace surv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correct = 0;
           correct += ShowQuestion("What is 1+1?", "a)1", "b)2", "c) 0", "d) 6", "b");
            correct += ShowQuestion("What is Mr.Clarke?", "a)god", "b)wizard", "c) teacher", "d) turtle", "c");
            correct += ShowQuestion("WHO LET THE DOGS OUT?", "a)null", "b)you", "c) whowhowhowho", "d) the dogs", "c" +
                "");
            Console.WriteLine("You got {0} correct!", correct);
            Console.ReadKey();
        }
        public static int ShowQuestion(string question,
                                        string answer1,
                                        string answer2,
                                        string answer3,
                                        string answer4,
                                        string correct)
        {
            Console.WriteLine(question);
            Console.WriteLine(answer1);
            Console.WriteLine(answer2);
            Console.WriteLine(answer3);
            Console.WriteLine(answer4);
            string answer = Console.ReadLine();
            if (answer.Equals(correct)) ; else
            return 0;
            {
                Console.WriteLine("You are so smart!");
                return 1;
            }
           
        }
    }
}
    

