using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
 internal class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Conteo de pasajeros");
            Console.WriteLine("1. Carga los datos");
            Console.WriteLine("2. Imprime datos en pantalla");
            Console.WriteLine("3. Salir");
            Console.WriteLine(" Ingrese una opcion y presione Enter");
            int opcion = int.Parse(Console.ReadLine());
            int[] pasajerosT = new int[5];
            int[] pasajerosBus = new int[5];
            while (opcion != 3)
            {
                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < 6; i++)
                        {
                            try
                            {
                                Console.WriteLine($"Cargue la cantidad de pasajeros en taxi Nro. {i}");
                                pasajerosT[i - 1] = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("El valor ingresado no es correcto, intente de nuevo");
                                pasajerosT[i - 1] = int.Parse(Console.ReadLine());
                            }

                            for (int i = V; i < 6; i++)
                            {
                                try
                                {
                                    Console.WriteLine($"Cargue la cantidad de pasajeros en Bus N° {i}");
                                    pasajerosBus[i - 1] = int.Parse(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("El valor ingresado no es correcto, intente nuevamente");
                                    pasajerosBus[i - 1] = int.Parse(Console.ReadLine());
                                }
                            }
                            Console.WriteLine("Hemos finalizado con la carga de pasajeros");
                            break;
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
            }

        


           

            
           

           

       

       
    }

