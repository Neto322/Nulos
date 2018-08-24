using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro Micarro = new Carro();
            Micarro.marca = "Tsuru";
            Micarro.kilometraje = 100000;
            Console.WriteLine("Carro de marca " + Micarro.marca);
            Console.WriteLine("Kilometraje " + Micarro.kilometraje);
            if (Micarro.midueño != null)
            {
                Console.WriteLine("Dueño " + Micarro.midueño.nombre);
            }else
            {
                Console.WriteLine("No hay dueño");
            }
            Console.ReadLine();       
        }
    }
}
