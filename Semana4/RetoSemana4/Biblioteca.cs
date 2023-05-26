using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Semana4
{
    internal class Biblioteca : IBiblioteca
    {
        private List<Material> _materiales;

        public Biblioteca()
        {
            _materiales = new List<Material>();
        }

        public void AgregarMaterial(Material material)
        {
            if (material.GetType() == typeof(Libro))
            {
                _materiales.Add(material);
                Console.WriteLine($"Se ha agregado el libro '{material.Titulo}' a la Biblioteca");
            }
            else if (material.GetType() == typeof(Revista))
            {
                _materiales.Add(material);
                Console.WriteLine($"Se ha agregado la revista '{material.Titulo}' a la Biblioteca");
            }
        }

        public List<Material> BuscarPorTitulo(string titulo)
        {
            List<Material> materialesEncontrados = new List<Material>();
            
            foreach (Material material in _materiales)
            {
                if (material.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    materialesEncontrados.Add(material);
                }
            }

            return materialesEncontrados;
        }

        public void DevolverMaterial(Material material)
        {
            if (material.GetType() == typeof(Libro))
            {
                material.Disponible = true;
                Console.WriteLine($"Se ha devuelto el libro '{material.Titulo}'");
            }
            else if (material.GetType() == typeof(Revista))
            {
                material.Disponible = false;
                Console.WriteLine("Las revistas no se pueden devolver");
            }
        }

        public void PrestarMaterial(Material material)
        {
            if (material.GetType() == typeof(Libro))
            {
                if (material.Disponible == true)
                {
                    material.Disponible = false;
                    Console.WriteLine($"Se ha prestado el libro '{material.Titulo}'");
                }
                else
                {
                    Console.WriteLine($"El libro '{material.Titulo}' no está disponible");
                }      
            }
            else if (material.GetType() == typeof(Revista))
            {
                material.Disponible = false;
                Console.WriteLine($"Se ha prestado la revista '{material.Titulo}'");
            }
        }        
    }
}
