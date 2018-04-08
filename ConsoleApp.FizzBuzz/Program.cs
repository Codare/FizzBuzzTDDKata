using System;
using FizzBuzz.GameEngine;

namespace ConsoleApp.FizzBuzz
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Hello World!");

            var fizzBuzzGame = new FizzBuzzGame();

            for (var i = 0; i < 100; i++)
            {
                Console.WriteLine(fizzBuzzGame.Of(i));
            }

            Console.ReadLine();
        }
    }
}