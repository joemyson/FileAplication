using System;
using System.IO;

namespace FileAplication
{
    class Program
    {
        static void Main(string[] args)

        {
            string sourcePath = @"C:\Users\joemy\source\repos\textoTeste.txt";
            string targetPath = @"C:\Users\joemy\source\repos\textoTeste2.txt";


            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch( IOException e)
            {
                Console.WriteLine("um erro ocorreu");
                Console.WriteLine(e.Message);
            }
    }}
}
