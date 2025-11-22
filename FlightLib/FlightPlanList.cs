using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlanList
    {
        //Parametros
        FlightPlan[] vector= new FlightPlan[10];
        int number = 0;

        private void EnsureCapacity() //Ver la longitud de la lista
        {
            if (number >= vector.Length)
            {
                FlightPlan[] nuevo = new FlightPlan[vector.Length * 2];
                Array.Copy(vector, nuevo, vector.Length);
                vector = nuevo;
            }
        }

        public void Clean()
        {
            this.vector = new FlightPlan[10];
            number = 0; //borra todos los elementos de la lista
        }

        //Método para poner un flightplan a la lista
        public int AddFlightPlan(FlightPlan p)
        {
            EnsureCapacity();
            vector[number] = p; //Si la lista no está llena, añade el plan dado como parametro y aumenta el contador
            number = number + 1;
            return 0;
        }
        public int NumElementosLista() //retorna la longitud de la llista
        {
            return number;
        }
        public FlightPlan GetFlightPlan(int i) //metodo getflightplan (get de un valor de la lista)
        {
            if (i<0 || i >= number)
            {
                return null;
            }
            else
            {
                return vector[i]; //Retorna el plan en la posicion dada como parametro
            }
        }
        public FlightPlan SearchID(string ID)//Busca segun la ID del avion, y cuando lo encuentra lo devuelve y acaba el bucle
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


        //OTROS MÉTODOS DE LA CLASE FLIGHTPLANLIST

        public void Mover(double tiempo) //método para mover los flightplans
        {
            int i = 0;
            while (i < number)
            { 
                vector[i].Mover(tiempo); //Mueve según la formula de MRU
                i++;
            }
        }

        public bool LlegadoDestino() //saber cuando todos los aviones llegan al destino
        {
            int llegado = 0;
            for (int i = 0; i < number; i++)
            {
                if (this.GetFlightPlan(i).GetCurrentPosition() == this.GetFlightPlan(i).GetFinalPosition())
                {
                    llegado++;
                }
            }
            if (llegado == number) //Todos los aviones han llegado, es decir, su posicion actual es la final
            {
                return true;
            }
            return false;
        }

        public void EscribeConsola()
        {
            int i = 0;
            while (i<number)
            {
                vector[i].EscribeConsola(); //Escribe todos los parametros en la consola
                i++;
            }
        }


        //METODOS CON RELACiÓN A FLIGHTPLANS EN UN ARXIVO TXT
        public int CargarLista(string filename) //Carga la lista de flightplans des de un archivo txt
        {
            try //Comprueba que existe un archivo con ese nombre o con el formato adecuado
            {
                StreamReader r = new StreamReader(filename);
                string linea = r.ReadLine(); //Que ignore saltos de linea o otros al inicio y final del programa
                while (linea != null)
                {
                    linea = linea.Trim('\n', '\r',' ','\t');
                    if (linea.Length == 0)
                    {
                        linea = r.ReadLine();
                        continue;
                    }

                    string[] trozos = linea.Split(' ','\t');
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

        public void GuardarPlan(string filename)//guarda el flightplan a larxiu
        {
            StreamWriter w = new StreamWriter(filename + ".txt"); //Guarda el archivo con este nombre.
            for (int i = 0; i < number; i++)
            {
                w.WriteLine(this.GetFlightPlan(i).GetId() + " " + this.GetFlightPlan(i).GetCurrentPosition().GetX().ToString() + " " + this.GetFlightPlan(i).GetCurrentPosition().GetY().ToString() + " " + this.GetFlightPlan(i).GetFinalPosition().GetX().ToString() + " " + this.GetFlightPlan(i).GetFinalPosition().GetY().ToString() + " " + this.GetFlightPlan(i).GetVelocidad().ToString());
            }
            w.Close(); //Escribe cada avion en una linea diferente con sus parametros separados por espacio. La posicion inicial de los aviones guardados es la actual que tenian, para poder seguir donde lo dejastes.
        }


        public FlightPlanList GiveLista() //Crea un objeto nuevo con los mismos valores para tener un backup de la lista original
        {
            FlightPlanList clon = new FlightPlanList();
            for (int i = 0; i < this.number; i++)
            {
                FlightPlan planCopia = this.GetFlightPlan(i).Clone();
                clon.AddFlightPlan(planCopia);
            }
            return clon;
        }
    }
}