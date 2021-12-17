using System;
using System.IO;
using System.Linq;

namespace TwoDimensionalArrays
{
    internal class Program
    {
        private const string Path = @"D:\TestTextFile";

        private static void Main(string[] args)
        {
            try
            {
                var txtFiles = Directory.EnumerateFiles(Path, "*.txt");
                foreach (var currentFile in txtFiles)
                {
                    var lines = File.ReadAllLines(currentFile);
                    var jagged = lines.Select(line => line.Split(',').ToArray()).ToArray();


                    for (var i = 0; i < lines.Length; i++)
                    {
                        for (var j = 0; j < jagged.Length - 1; j++)
                            Console.Write(currentFile.Split('\\').Last() + @" - " + jagged[i][j] + @" * ");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();
        }
    }
}