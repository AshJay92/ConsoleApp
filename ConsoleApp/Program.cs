using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Number number = new Number();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(number.GetNumberRepresentation(i));
            }         
        }
    }
}
