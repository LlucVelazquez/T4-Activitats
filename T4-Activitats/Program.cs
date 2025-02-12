using System;
namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operacio(int a, int b);
        public delegate void DelegatePrintOf(int a, int b);
        public static void SumaPrint(int a, int b) { Console.WriteLine($"Suma {a + b}"); }
        public static void RestaPrint(int a, int b) { Console.WriteLine($"Resta {a - b}"); }
        public static int Multiplicar(int a, int b) { return a * b; }
        public static int Divisio(int a, int b) => a / b;
        public static void Main(string[] args)
        {
            DelegatePrintOf printOp = SumaPrint;
            printOp += RestaPrint;
            printOp(0, 0);

            Action<string> printPantalla = msg => Console.WriteLine(msg);
            printPantalla("Soc un delegat");

            Func<int,int,int> multiplicacio = (a, b) => Multiplicar(a,b);
            Console.WriteLine(multiplicacio(6,2));
            Action<int,int> printSuma = (a,b)=> Console.WriteLine(a +b);
            printSuma(2, 5);

        }
    }
}