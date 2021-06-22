using System;

namespace ConsoleApp3
{
    internal class ConsoleUI : IUI
    {

        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}