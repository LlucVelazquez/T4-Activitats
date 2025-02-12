using System;
namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string msg = "data: ";
            Console.WriteLine(msg);
            DateTime time = DateTime.Parse(Console.ReadLine());
            TimeSpan result = time - DateTime.Today;
            Console.WriteLine($"Dies que falten {result.Days}");
        }
    }
}