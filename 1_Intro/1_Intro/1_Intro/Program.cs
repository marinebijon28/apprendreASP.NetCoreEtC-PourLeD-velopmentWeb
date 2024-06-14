using System;

namespace _1_Intro
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Test();
            showText("Show Text");
        }

        static void Test() {
            Console.WriteLine("Test");
        }

         static void showText(string txt) {
            Console.WriteLine(txt);
        }
    }
}
