using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion10_Ejercicio1
{
    internal class Animal : IAnimal
    {
        public void Andar()
        {
            Console.WriteLine("El animal está andando");
        }

        public bool EsPerro()
        {
            return true;
        }

        public void Saltar()
        {
            Console.WriteLine("El animal está saltando");
        }
    }
}
