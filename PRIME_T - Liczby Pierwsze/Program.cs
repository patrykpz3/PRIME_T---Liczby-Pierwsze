using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_T___Liczby_Pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {


                                                                                                    // Liczby w zakresie ze spoja
            int n = 10000;
            bool[] liczby = new bool[n + 1];
            
            for(int i=0; i <= n; i++)
            {
                liczby[i] = true;
            }
            liczby[1] = false;
                                                                                                    // Próba wykorzystania sita Eratostenesa 
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (liczby[i] == true)
                {
                    for (int j = i + i; j <= n; j = j + i)
                    {
                        liczby[j] = false;
                    }
                }
            }
     
            int ilosc_testow = Convert.ToInt32(Console.ReadLine());


            for(int i=0; i < ilosc_testow; i++)
            {
                int liczba = Convert.ToInt32(Console.ReadLine());
                if(liczby[liczba] == true)
                {
                    Console.WriteLine("TAK");
                }
                else
                {
                    Console.WriteLine("NIE");
                }

            }

        }
    }
}
