using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana4
{
    internal class Revista : Material
    {
        public string Edicion { get; set; }
        
        public Revista(string titulo, string edicion) : base(titulo)
        {
            Edicion = edicion;
        }

        public void Prestar()
        {
            Disponible = false;
        }
    }
}
