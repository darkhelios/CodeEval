using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueElements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arreglo = "1,1,1,2,2,3,3,4,4".Split(',');

            var arregloFinal = arreglo.Distinct().ToArray();

            Console.WriteLine(string.Join(",", arregloFinal));
            Console.ReadKey();

        }
    }
}   
