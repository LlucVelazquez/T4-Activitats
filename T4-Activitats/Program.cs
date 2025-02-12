using System;
namespace T4_Activitats
{
    public class Program
    {
        public delegate void Notificacio(string msg);
        public static void MostrarMissatgeConsola(string msg) => Console.WriteLine(msg);
        public static void MostrarMissatgeambEstrelles(string msg) => Console.WriteLine($"***{msg}");
        public static void Main(string[] args)
        {
            Notificacio notificacio;
            notificacio = MostrarMissatgeConsola;
            notificacio += MostrarMissatgeambEstrelles;
            notificacio("Soc una notificacio!");

        }
    }
}