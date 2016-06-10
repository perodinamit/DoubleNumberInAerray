using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNumberInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3, 4, 5, 6, 2 };
            int duljina = 7;
            int suma = 0;
            int trueSum = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                
                suma += firstArray[i];
            }
            Console.WriteLine("Suma trenutnih brojeva u polju je:");
            Console.WriteLine(suma.ToString());

            Console.WriteLine("*----------------------*");
            for (int i = 1; i < duljina; i++)
            {
                trueSum += i;
            }
            Console.WriteLine("Ispravna suma brojeva unutar polja je: {0}", trueSum.ToString());

            int visak = 0;
            visak = suma - trueSum;
            Console.WriteLine("Broj koji je duplikat je: {0}", visak.ToString());
        }
    }
}
