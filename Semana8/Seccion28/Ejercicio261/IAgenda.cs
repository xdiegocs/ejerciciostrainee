using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion27_Ejercicio1
{
    public interface IAgenda
    {
        void AgregarCita();
        void AgregarContacto();
        void ConsultarCita();
        void BuscarContacto();
    }
}
