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
                alumnesEdat.Add($"{i}",int.Parse(Console.ReadLine()));
            }
            foreach (var alumne in alumnesEdat)
            {
                Console.WriteLine($"{alumne.Key} {alumne.Value} anys");
            }
        }
    }
}