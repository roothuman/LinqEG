using System;
using System.IO;
using System.Linq;

namespace LinqEG
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\windows";
            ShowLargeFilesWithLinq(path);
        }

        private static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                .OrderByDescending(f => f.Length)
                .Take(5);

            foreach (var file in query)
            {
                Console.WriteLine($"{file.Name, -20} : {file.Length, -10:N0}");
            }
        }
    }
}
