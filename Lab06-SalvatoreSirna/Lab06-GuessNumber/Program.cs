using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userGuess; //contains user number
            bool CorrectNumber = false;
            Random randomNumberGenerator = new Random();
            int randomNumber = randomNumberGenerator.Next(1, 101);

            while (!CorrectNumber)
            {
               
                {
                    Console.WriteLine("I'm thinking of a number between 1 and 100.  Can you guess it?");
                    {
                        Console.Write("Guess the Number: ");
                        userGuess = Convert.ToInt32(Console.ReadLine());

                        if (userGuess == randomNumber)
                        {
                            Console.WriteLine("Congrats!!  You guessed right!");
                            CorrectNumber = true;
                        }
                        else if (userGuess > randomNumber)
                        {
                            Console.WriteLine("You are too HIGH!");
                        }

                        else if (userGuess < randomNumber)

                        {
                            Console.WriteLine("You are too loowww!");
                        }

                    }


                }
                }
        }
    }
}

