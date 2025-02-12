using System;
namespace T4_Activitats
{
    public class Program
    {
        public delegate int Operacio(int a, int b);
        public delegate void DelegatePrintOf(int a, int b);
        public static void SumaPrint(int a, int b) { Console.WriteLine($"Suma {a+b}"); }
        public static void RestaPrint(int a, int b) { Console.WriteLine($"Resta {a - b}"); }
        public static int Multiplicar(int a, int b) { return a * b; }
        public static int Divisio(int a, int b) => a / b;

        public static void ExecutarOperacio(int a, int b, Operacio op) => Console.WriteLine(op(a,b));
        public static void Main(string[] args)
        {
            DelegatePrintOf printOp = SumaPrint;
            printOp += RestaPrint;
            printOp += SumaPrint;
            printOp(0,0);
            printOp -= RestaPrint;
            printOp(6, 2);

            ExecutarOperacio(5,8, (a,b) => a*b);

            Operacio op = Multiplicar;
            ExecutarOperacio(5,8,op);

            // 23
            Console.WriteLine("ex 23");
            Operacio op1 = (a,b) => (int)Math.Pow(a,b);
            Console.WriteLine(op1(2,3));
        }
    }
}