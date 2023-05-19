using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9_Ejercicio3
{
    public class Coche : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("El coche está acelerando");
        }
        public override void Frenar()
        {
            Console.WriteLine("El coche está frenando");
        }
        public void Pitar()
        {
            Console.WriteLine("El coche está pitando");
        }
    }
}
