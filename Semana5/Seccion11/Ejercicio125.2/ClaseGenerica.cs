using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion11_Ejercicio2
{
    internal class ClaseGenerica<T>
    {
        private List<T> lista = new List<T>();

        public void AgregarElementos(T elemento)
        {
            lista.Add(elemento);
        }

        public void MostrarElementos()
        {
            Console.WriteLine("Los elementos de la lista son: ");
            foreach (T elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
