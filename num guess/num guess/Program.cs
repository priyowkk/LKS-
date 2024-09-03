using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace num_guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r= new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playagain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = r.Next(min,max + 1);

                while (guess != number)
                {
                    Console.WriteLine("guess a number between " + min + "-" + max + ":");
                    guess = Convert .ToInt32(Console.ReadLine());
                    Console.WriteLine("guess :" + guess );

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is too high!");
                    }
                    else if (guess < number) 
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("number: " + number);
                Console.WriteLine("YOU WIN!!");
                Console.WriteLine("guesses:" + guesses );

                Console.WriteLine("Would u like to play again? (yes/no) :");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response =="yes")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }

            }
            Console.WriteLine("Thanks For Playing!!!");

            Console.ReadKey();


        }
    }
}
