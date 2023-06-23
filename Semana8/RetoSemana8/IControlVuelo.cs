using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana8
{
    public interface IControlVuelo
    {
        void CargarDatosDeCSV();
        void InsertDataIntoTable(List<Vuelo> vuelos);
        List<string> ObtenerDestinoPorOrigen(string origen);
        List<string> ObtenerOrigenPorDestino(string destino);
    }
}
