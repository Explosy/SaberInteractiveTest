using System;
using System.Text;

namespace SaberInteractiveTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тестовое задание для SaberInteractive");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task1");
            Console.ForegroundColor = ConsoleColor.White;
            
            Random numberRandomizer = new Random();
            int decNumber = numberRandomizer.Next();
            Console.WriteLine("Исходное число: " + decNumber);
            string binaryNumber = Task1.GetBinaryNumber(decNumber);
            Console.WriteLine("Число в двоичной СС: " + binaryNumber+'\n');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task2");
            Console.ForegroundColor = ConsoleColor.White;
            
            string stringWithDuplicate = "AAA BBB   AAA CCC FD FGGHF";
            Console.WriteLine("Строка с дубликатами: " + stringWithDuplicate);
            string stringWithoutDuplicates = Task2.RemoveDuplicates(stringWithDuplicate);
            Console.WriteLine("Строка без дубликатов: " + stringWithoutDuplicates);
        }
    }
}
