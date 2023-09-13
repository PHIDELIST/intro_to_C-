using System;
using System.Runtime.InteropServices;

namespace Guessing_Game{
    class Program
    {
        static void Main(string[] args)
        {
                bool isCorrectGuess = false;
                Random random = new Random();
                int randomNum = random.Next(1,11);
            Console.WriteLine("Welcometo our number guesssing game!");
            Console.WriteLine("A number between 1 and 10 will be generated");
            Console.WriteLine("If you  guess the correct number you win");
          

            while(!isCorrectGuess) {
                Console.WriteLine("enter your guess");

                int guess = Convert.ToInt32(Console.ReadLine());

                if(guess > randomNum)
                {
                    Console.WriteLine("your guess is to hight");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("your guess is too low");
                }
                else
                {
                    Console.WriteLine("kudos you win");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine("Congratulations!!!");
        }
    }

}