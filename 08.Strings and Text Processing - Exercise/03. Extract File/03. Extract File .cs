using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int StartIndexOfFile = path.LastIndexOf('\\')+1;
            string file = path.Substring(StartIndexOfFile);
            int startIndexOfExtension = file.LastIndexOf('.')+1;
            string name = file.Substring(0 ,startIndexOfExtension-1);
            string extension = file.Substring(startIndexOfExtension);

            Console.WriteLine($"File name: {name} \nFile extension: {extension}");
        }
    }
}
