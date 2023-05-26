using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana4
{
    public class Libro : Material
    {
        public string Autor { get; set; }
        public Libro(string titulo, string autor) : base(titulo)
        {
            Autor = autor;
        }
        
        public void Prestar()
        {
            Disponible = false;
        }

        public void Devolver()
        {
            Disponible = true;
        }
    }
}
