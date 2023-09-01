using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1,2,3,4,5};
            MostrarArrayRecursivo(array, 0);
            Console.ReadLine();
        }
        public static void MostrarArrayRecursivo(int[] array, int indice)
        {
            if(indice != array.Length)
            {
                Console.WriteLine(array[indice]);
                MostrarArrayRecursivo(array, indice + 1);
            }
            
          
        }
    }
}
