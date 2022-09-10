using System;

namespace SaberInteractiveTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестовое задание для SaberInteractive");
            Console.WriteLine("Task1");
            Random numberRandomizer = new Random();
            int decNumber = numberRandomizer.Next();
            string binaryNumber = Task1.GetBinaryNumber(-67);

        }
    }
}
