using System;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hej! Vad heter du?");
            string namn;
            namn = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Skriv ett namn på en kändis.");
            string namn2;
            namn2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hur gammal är du?");
            string age;
            age = Console.ReadLine();

            Console.WriteLine("Du är " + age + " och heter " + namn + " Samt gillar " + namn2 + ".");
            Console.ReadLine();
        }
    }
}
