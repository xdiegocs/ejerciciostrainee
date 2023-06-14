using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana7
{
    public class JokeService : IJokeService
    {
        private const string _apiUrl = "https://api.chucknorris.io/jokes/random";
        private const string _jokesFilePath = "chistes.txt";

        public Joke ObtenerChisteAleatorio()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = client.GetAsync(_apiUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        var chiste = JsonConvert.DeserializeObject<Joke>(content);
                        return chiste;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrio un error obteniendo el chiste aleatorio: {ex.Message}");
            }

            return null;
        }

        public void GuardarAtributos(Joke chiste)
        {
            if (chiste == null) return;

            var chistes = CargarChistesArchivo();
            if (!chistes.Any(j => j.Id == chiste.Id))
            {
                chistes.Add(chiste);
                GuardarChistesArchivo(chistes);
                Console.WriteLine("Chiste guardado satisfactoriamente.");
            }
            else
            {
                Console.WriteLine("Ya existe un chiste igual almacenado en el archivo.");
            }
        }

        public List<Joke> BuscarPorPalabraClave(string palabraClave)
        {
            var chistes = CargarChistesArchivo();
            return chistes.Where(j => j.Value.Contains(palabraClave, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private List<Joke> CargarChistesArchivo()
        {
            if (File.Exists(_jokesFilePath))
            {
                var json = File.ReadAllText(_jokesFilePath);
                return JsonConvert.DeserializeObject<List<Joke>>(json) ?? new List<Joke>();
            }

            return new List<Joke>();
        }

        private void GuardarChistesArchivo(List<Joke> chistes)
        {
            var json = JsonConvert.SerializeObject(chistes, Formatting.Indented);
            File.WriteAllText(_jokesFilePath, json);
        }
    }
}
