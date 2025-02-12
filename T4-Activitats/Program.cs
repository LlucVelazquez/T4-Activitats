using System;
namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operacio(int a,int b);
        public static int Multiplicar(int a,int b) { return a * b; }
        public static int Divisio(int a, int b) => a / b;
        public static void Main(string[] args)
        {
            Operacio multiplicar = Multiplicar;
            Operacio divisio = Divisio;
            Console.WriteLine(multiplicar(5,3));
            Console.WriteLine(divisio(5,3));
        }
    }
}