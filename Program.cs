using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tasks: Basics of C# 
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1. Ask to write a symbol until the dot is given.

            Console.WriteLine("Please enter your symbol: ");
            char symbol;
            do
            {
                symbol = Console.ReadKey().KeyChar;
            }
            while (symbol != '.');

            // Task 2. Write a 6-element number to check if it's "lucky".

            Console.WriteLine("Please enter your 6-element number: ");
            string str = Console.ReadLine();

            char[] ch = new char[str.Length];
            ch = str.ToCharArray();

            int[] numberOfTicket = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int lnumber = 0; // left number
                int rnumber = 0; // right number

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        lnumber += numberOfTicket[i];
                    }
                    else { rnumber += numberOfTicket[i]; }
                }
                if (lnumber == rnumber)
                {
                    Console.WriteLine("It is a lucky ticket!");
                }
                else { Console.WriteLine("It's not  alucky number! Try again!"); }
            }
            else { Console.WriteLine("The given number is not correct!"); }

            Console.Read();

            // Task 3. Type A and B and give out all of the numbers between them. Printing of numbers should be equal to their value.

            int A;
            Console.WriteLine("Please type the number A: ");
            A = Int32.Parse(Console.ReadLine());
            int B;
            Console.WriteLine("Please type the number B: ");
            B = Int32.Parse(Console.ReadLine());

            while(A <= B)
            {
                Console.WriteLine(A.ToString());
                A++;
            }
            Console.ReadLine();

            // Task 4. Type the number and then give it out in reversed order.

            Console.Write("Please enter your number: ");
            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(n.ToString().Reverse().ToArray());

        }
    }
}
