using System;
namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            string entrada;
            bool flag = true;
            while (flag)
            {
                entrada = Console.ReadLine();
                if (string.IsNullOrEmpty(entrada))
                    flag = false;

            }
            var parells = numeros.Where(n => n % 2 == 0);
            foreach (int parell in parells){
                Console.WriteLine(parell);
            }
        }
    }
}