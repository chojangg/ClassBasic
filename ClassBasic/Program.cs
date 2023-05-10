using System;
using System.Data;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Math
    {
        public static int abs(int i) { return 0; }
    }
    internal class Program234
    {
        static void Main(string[] args)
        {
            Math.abs(-3);

            OtherClass oc = new OtherClass();


            Console.WriteLine("Hello World!");
        }

        class ThridClass
        {

        }
    }

    class SecondClass
    {

    }
}