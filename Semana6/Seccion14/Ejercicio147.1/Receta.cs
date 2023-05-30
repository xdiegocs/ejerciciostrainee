using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion14_Ejercicio1
{
    public class Receta
    {
        public async Task HacerTortilla()
        {
            await PelarPatatas();
            await CortarPatatas();
            await BatirHuevos();
            await MezclarIngredientes();
            await CocinarTortilla();
        }

        private async Task PelarPatatas()
        {
            Console.WriteLine("Pelando las patatas...");
            await Task.Delay(2000);
            Console.WriteLine("Patatas peladas.");
        }

        private async Task CortarPatatas()
        {
            Console.WriteLine("Cortando las patatas...");
            await Task.Delay(1500);
            Console.WriteLine("Patatas cortadas.");
        }

        private async Task BatirHuevos()
        {
            Console.WriteLine("Batiendo los huevos...");
            await Task.Delay(1000);
            Console.WriteLine("Huevos batidos.");
        }

        private async Task MezclarIngredientes()
        {
            Console.WriteLine("Mezclando las patatas con los huevos...");
            await Task.Delay(2000);
            Console.WriteLine("Ingredientes mezclados.");
        }

        private async Task CocinarTortilla()
        {
            Console.WriteLine("Cocinando la tortilla...");
            await Task.Delay(3000);
            Console.WriteLine("¡La tortilla está lista!");
        }
    }
}
