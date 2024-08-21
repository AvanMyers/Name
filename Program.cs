using System;

namespace Name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string simbol;

            Console.WriteLine("Введите имя:");
            name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            simbol = Console.ReadLine();

            for (int i = 0; i < name.Length + 2; i++)
            {
                Console.Write(simbol);
            }

            Console.WriteLine();
            Console.WriteLine(simbol + name + simbol);

            for (int i = 0; i < name.Length + 2; i++)
            {
                Console.Write(simbol);
            }

            Console.ReadKey();
        }
    }
}
