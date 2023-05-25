using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion11_Ejercicio3
{
    enum Animales
    {
        Perro = 5,
        Gato = 8,
        Canario = 2,
        Caballo = 12
    }

    internal class Animal
    {
        public Animales Tipo { get; set; }
    }
}
