using System;
using System.Collections;
namespace T4_Activitats
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                arrayList.Add(Console.ReadLine());
            }
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}