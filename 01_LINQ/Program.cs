using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ e Lambda 
            //Lambda = (entrada) -> (expressão)
            int[] list = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            var listaFiltrada = list.Where(x => x > 10).OrderBy(x => x).Select(x => x);

            foreach(var listas in listaFiltrada)
            {
                Console.WriteLine(listas);
            }

            Console.ReadKey();
        }
    }
}
