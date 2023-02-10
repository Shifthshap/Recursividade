using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {

            Recursiva r = new Recursiva();
            r.ExecutarRecursiva("Ola mundo!", 15);

            Console.ReadKey();

        }
    }
}
