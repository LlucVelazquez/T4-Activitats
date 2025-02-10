using System;
namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> alumnesEdat = new Dictionary<string, int>();
            for (int i = 0; i < 5; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                alumnesEdat.Add(name,age);
            }
            foreach (var alumne in alumnesEdat)
            {
                Console.WriteLine($"{alumne.Key} {alumne.Value} anys");
            }
        }
    }
}