using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion13_Ejercicio1
{
    public interface IArchivo
    {
        void Guardar(string ruta);
        void Cargar(string ruta);
    }
}
