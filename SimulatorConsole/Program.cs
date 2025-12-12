using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FlightLib;

namespace SimulatorConsole
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            try 
            {
                FlightPlanList lista = new FlightPlanList();

                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                string identificador = Console.ReadLine(); ;

                Console.WriteLine("Escribe la velocidad");
                double velocidad = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                string linea = Console.ReadLine();
                string[] trozos = linea.Split(' ');
                double ix = Convert.ToDouble(trozos[0]);
                double iy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea = Console.ReadLine();
                trozos = linea.Split(' ');
                double fx = Convert.ToDouble(trozos[0]);
                double fy = Convert.ToDouble(trozos[1]);

                Console.WriteLine("Escribe el nombre de la empresa:");
                string nom = Console.ReadLine();

                FlightPlan plan_a = new FlightPlan(identificador, ix, iy, fx, fy, velocidad, nom);


                //PLan del segundo vuelo
                Console.WriteLine("Escribe el identificador");
                //   string nombre = Console.ReadLine();
                string identificador_b = Console.ReadLine(); ;

                Console.WriteLine("Escribe la velocidad");
                double velocidad_b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escribe las coordenadas de la posición inicial, separadas por un blanco");
                string linea_b = Console.ReadLine();
                string[] trozos_b = linea_b.Split(' ');
                double ix_b = Convert.ToDouble(trozos_b[0]);
                double iy_b = Convert.ToDouble(trozos_b[1]);

                Console.WriteLine("Escribe las coordenadas de la posición final, separadas por un blanco");
                linea_b = Console.ReadLine();
                trozos_b = linea_b.Split(' ');
                double fx_b = Convert.ToDouble(trozos_b[0]);
                double fy_b = Convert.ToDouble(trozos_b[1]);

                Console.WriteLine("Escribe el nombre de la empresa:");
                string nom_b = Console.ReadLine();

                FlightPlan plan_b = new FlightPlan(identificador_b, ix_b, iy_b, fx_b, fy_b, velocidad_b, nom_b);

                lista.AddFlightPlan(plan_a);
                lista.AddFlightPlan(plan_b);


                lista.EscribeConsola();

                int ciclos = 100;
                int i = 0;
                int tiempo = 10;
                Boolean risc;

                while (i<ciclos)
                {
                    double currentDist = plan_a.DistanceTo(plan_b);
                    risc = plan_a.Conflicto(currentDist, 100);
                    if (risc==true)
                        Console.WriteLine("PELIGRO");

                    Console.ReadKey();

                    lista.Mover(tiempo);
                    lista.EscribeConsola();

 
                    i = i + 1;
                }
                Console.ReadKey();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Introduce bien los datos");
            }


            Console.ReadLine();
        }
    }
}
