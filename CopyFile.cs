using System;
using System.IO;

class Program
{
    static void Main()
    {
        string source = @"C:\Users\Student\Desktop\C_sharp\source.txt.txt";
        string destination = @"C:\Users\Student\Desktop\C_sharp\destination.txt";

        if (!File.Exists(source))
        {
            Console.WriteLine("Source file not found!");
            return;
        }

        string content = File.ReadAllText(source);
        File.WriteAllText(destination, content);

        Console.WriteLine("File contents copied successfully!");
    }
}
