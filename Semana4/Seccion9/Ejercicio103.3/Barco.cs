using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9_Ejercicio3
{
    public class Barco : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("El barco está acelerando");
        }
        public override void Frenar()
        {
            Console.WriteLine("El barco está frenando");
        }
        public void EcharAncla()
        {
            Console.WriteLine("El barco está echando el ancla");
        }
    }
}
