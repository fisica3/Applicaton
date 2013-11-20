using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas
{
    public class Basicas
    {
        public int Fibonacci(int indice)
        {
            if (indice == 1 || indice == 2) return 1;
            return Fibonacci(indice-2) + Fibonacci(indice-1);
        }

        public int Suma(int sumandoA, int sumandoB)
        {
            return 0;
        }

    }
}
