using System;
namespace T4_Activitats
{
    public class Program
    {
        public delegate void Notificacio(string msg);
        public static void ExecutarAmbMetodeAnonim(Notificacio notificacio)
        {
            notificacio("Aixo es una notificacio");
        }

        public static void Main(string[] args)
        {
            ExecutarAmbMetodeAnonim((msg) => Console.WriteLine($"{msg}"));
        }
    }
}