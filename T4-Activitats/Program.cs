using System;
namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pair<string, int> pair1 = new Pair<string, int>("pata1", 94742);
            Console.WriteLine(pair1.ToString());
            Pair<double, bool> pair2 = new Pair<double, bool>(45.44D, true);
            Console.WriteLine(pair2.ToString());
        }
    }
}