using System;

namespace _1_Intro
{
    class Program
    {
        // first video
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test();
            showText("Show Text");
            readTextConsole();
        }

        static void Test() {
            Console.WriteLine("Test");
        }

        static void showText(string txt) {
            Console.WriteLine(txt);
        }

        // second video
        static int age;
        static void readTextConsole() {
            Console.WriteLine("Quel est votre age ?");
            // age = int.Parse(Console.ReadLine());
            // age = int.TryParse(Console.ReadLine());
            var res = int.TryParse(Console.ReadLine(), out age);
            if (res == true)
                if (age >= 18)
                    Console.WriteLine("Vous êtes majeurs");
                else
                    Console.WriteLine("Vous êtes mineurs");
            else 
                Console.WriteLine("Erreur");
        }
    }
}
