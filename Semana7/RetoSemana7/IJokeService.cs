using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana7
{
    public interface IJokeService
    {
        Joke ObtenerChisteAleatorio();
        void GuardarAtributos(Joke chiste);
        List<Joke> BuscarPorPalabraClave(string palabraClave);
    }
}
