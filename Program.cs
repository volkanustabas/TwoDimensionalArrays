using System;
using System.IO;
using System.Linq;

namespace TwoDimensionalArrays
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"D:\01.txt");
            var jagged = lines.Select(line => line.Split(',').ToArray()).ToArray();


            for (var i = 0; i < lines.Length; i++)
            {
                for (var j = 0; j < jagged.Length - 1; j++) Console.Write(jagged[i][j] + @" * ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}