using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 1;
            int final = 10;
            int n;
            List <int> numeros = new List<int> ();
            while (inicio <= final) {
                Console.WriteLine("Digite el número que desea ingresar: ");
                n = Convert.ToInt32 (Console.ReadLine());
                numeros.Add(n);
                inicio += 1;
            }

            foreach (int numero in numeros) {
                Console.WriteLine("El número de la lista es: "+ numero);
                

            }
            Console.ReadKey();



        }
        
        
    }
}
