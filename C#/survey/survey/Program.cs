using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numcorrect = 0;
            int ans = 0;
            int x;
            Console.WriteLine("1. What is 5+5? ");
            Console.WriteLine("A. 2  B. 10 C. 5 D.November");
            x = int.Parse(Console.ReadLine());
            if (x == 10) 
                numcorrect = numcorrect + 1;
            Console.WriteLine("What is 2 x 9?");
            Console.WriteLine("A. 6  B. 11  C. 18  D. 50");
            x = int.Parse(Console.ReadLine());
            if (x == 18)
                numcorrect = numcorrect + 1;
            Console.WriteLine("What is 1+1!!?");
            Console.WriteLine("A.5  B. 2  C. fish D. 5190");
            x = int.Parse(Console.ReadLine());
            if (x == 2)
                numcorrect = numcorrect + 1;
            Console.WriteLine("Your Score is " + numcorrect);
            if (numcorrect == 0)
                Console.WriteLine("YOU SUCK");
            if (numcorrect == 3)
                Console.WriteLine("You are a gifted person. or cheating :p");
            Console.ReadKey();
            
        }
    }
}
