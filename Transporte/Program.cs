using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
 internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int[] pasajerosT = new int[5];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Cantidad de pasajeros taxi Nro {i}");
                pasajerosT[i-1] = int.Parse(Console.ReadLine());
            }

            int[] pasajerosBus = new int[5];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Cantidad de pasajeros en Bus Nro {i}");
                pasajerosBus[i-1] = int.Parse(Console.ReadLine());
            }

            List<Taxi> pasajerosTs = new List<Taxi>
            {
                new Taxi(pasajerosT[0]),
                new Taxi(pasajerosT[1]),
                new Taxi(pasajerosT[2]),
                new Taxi(pasajerosT[3]),
                new Taxi(pasajerosT[4]),
            };

            int f = 0;
            foreach (Taxi var in pasajerosTs)
            {
                f++;
                Console.WriteLine("El taxi Nro{0} lleva {1} pasajero/os", f, var.CantidadPasajeros);
            }

            List<Bus> pasajerosBuses = new List<Bus>
            {
                new Bus(pasajerosBus[0]),
                new Bus(pasajerosBus[1]),
                new Bus(pasajerosBus[2]),
                new Bus(pasajerosBus[3]),
                new Bus(pasajerosBus[4]),

             };

            int d = 0;
            foreach (Bus var in pasajerosBuses)
            {
                d++;
                Console.WriteLine("El Bus Nro{0} lleva {1} pasajero/os", d, var.CantidadPasajeros);
            }
            Console.ReadLine();
        }

       

       
    }
}
