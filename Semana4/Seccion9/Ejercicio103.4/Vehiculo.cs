using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion9_Ejercicio4
{
    public class Vehiculo
    {
        private int Ruedas { get; set; }
        private int Puertas { get; set; }

        public Vehiculo()
        {
            Ruedas = 0;
            Puertas = 0;
        }

        public Vehiculo(int ruedas, int puertas)
        {
            Ruedas = ruedas;
            Puertas = puertas;
        }

        public void Mostrar()
        {
            Console.WriteLine($"Ruedas: {Ruedas}");
            Console.WriteLine($"Puertas: {Puertas}");
        }
    }
}
