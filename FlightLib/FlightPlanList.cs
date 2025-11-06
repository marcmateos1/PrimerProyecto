using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector= new FlightPlan[10];
        int number = 0;

        public void Clean()
        {
            this.vector = new FlightPlan[10];
            number = 0;
        }
        public int AddFlightPlan(FlightPlan p)
        {
            if (number == 10)
            {
                return -1;
            }
            else 
            {
                vector[number] = p;
                number = number + 1;
                return 0;
            }
        }
        public int NumElementosLista()
        {
            return number;
        }
        public FlightPlan GetFlightPlan(int i)
        {
            if (i<0 || i >= number)
            {
                return null;
            }
            else
            {
                return vector[i];
            }
        }
        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(tiempo);
                i++;
            }
        }

        public FlightPlan SearchID(string ID)
        {
            for (int i = 0; i < number; i++)
            {
                if (vector[i].GetId() == ID)
                {
                    return vector[i];
                }
            }
            return null;
        }
        public void EscribeConsola()
        {
            int i = 0;
            while (i<number)
            {
                vector[i].EscribeConsola();
                i++;
            }
        }

        public int CargarLista(string filename)
        {
            try //Comprueba que existe un archivo con ese nombre o con el formato adecuado
            {
                StreamReader r = new StreamReader(filename);
                string linea = r.ReadLine();
                while (linea != null)
                {
                    string[] trozos = linea.Split(' ');
                    FlightPlan plan = new FlightPlan(trozos[0], Convert.ToDouble(trozos[1]), Convert.ToDouble(trozos[2]), Convert.ToDouble(trozos[3]), Convert.ToDouble(trozos[4]), Convert.ToDouble(trozos[5]));
                    this.AddFlightPlan(plan);
                    linea = r.ReadLine(); //Por cada linea que lee crea un nuevo Flight plan con los parametros que se encuentran separados por un espacio
                }

                r.Close();
                return 0;
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
            catch
            {
                return -2;
            }
        }
         
        public void GuardarPlan(string filename)
        {
            StreamWriter w = new StreamWriter(filename+".txt"); //Guarda el archivo con este nombre.
            for(int i = 0; i < number; i++)
            {
                w.WriteLine(this.GetFlightPlan(i).GetId() + " " +this.GetFlightPlan(i).GetCurrentPosition().GetX().ToString() + " " +this.GetFlightPlan(i).GetCurrentPosition().GetY().ToString() + " " +this.GetFlightPlan(i).GetFinalPosition().GetX().ToString() + " " +this.GetFlightPlan(i).GetFinalPosition().GetY().ToString() + " " +this.GetFlightPlan(i).GetVelocidad().ToString());
            }
            w.Close(); //Escribe cada avion en una linea diferente con sus parametros separados por espacio. La posicion inicial de los aviones guardados es la actual que tenian, para poder seguir donde lo dejastes.
        }

        public bool LlegadoDestino()
        {
            int llegado = 0;
            for(int i = 0; i < number; i++)
            {
                if (this.GetFlightPlan(i).GetCurrentPosition() == this.GetFlightPlan(i).GetFinalPosition())
                {
                    llegado++;
                }
            }
            if(llegado == number) //Todos los aviones han llegado, es decir, su posicion actual es la final
            {
                return true;
            }
            return false;
        }
    }
}
