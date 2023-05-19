using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9_Ejercicio3
{
    public class Avion : Vehiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("El avión está acelerando");
        }
        public override void Frenar()
        {
            Console.WriteLine("El avión está frenando");
        }
        public void Aterrizar(string destino)
        {
            Console.WriteLine($"El avión proveniente de {destino} está aterrizando");
        }
    }
}
