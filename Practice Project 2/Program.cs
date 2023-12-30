using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = ("E:\\Practice project 2//data.txt");

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadAllLines(filePath))
                {
                    Console.WriteLine(line.Replace('\t', '\t'));
                }
            }
            else
            {
                Console.WriteLine("File not found:");
            }
        }
    }
}





































