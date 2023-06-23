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
        void ObtenerDestinoPorOrigen(string origen);
        void ObtenerOrigenPorDestino(string destino);
    }
}
