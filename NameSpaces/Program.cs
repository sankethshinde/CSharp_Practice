using System;
using PATA = ProjectA.TeamA;
using PATB = ProjectA.TeamB;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.print();
            PATB.ClassA.print();
            Console.Read();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("Class A");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void print()
            {
                Console.WriteLine("Class B");
            }
        }
    }
}
