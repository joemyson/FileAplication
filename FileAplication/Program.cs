using System;
using System.IO;

namespace FileAplication
{
    class Program
    {
        static void Main(string[] args)

        {
            string sourcePath = @"C:caminho do diretorio";
            string targetPath = @"C:caminho do diretorio";


            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);
                fileinfo.CopyTo(targetPath);

            }
            catch (IOException e)
            {
                Console.WriteLine("um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
