using System;
using System.Collections;
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
        public int CargarLista(string filename) //Carga la lista de flightplans desde un archivo txt
        {
            try
            {
                StreamReader r = new StreamReader(filename);
                string linea = r.ReadLine();
                while (linea != null)
                {
                    linea = linea.Trim('\n', '\r', ' ', '\t');
                    if (linea.Length == 0)
                    {
                        linea = r.ReadLine();
                        continue;
                    }

                    // Ignorar elementos vacíos al separar
                    string[] trozos = linea.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (trozos.Length < 6)
                    {
                        linea = r.ReadLine();
                        continue; // ignorar líneas inválidas
                    }

                    if (Convert.ToDouble(trozos[5]) >= 0)
                    {
                        string nombreEmpresa = trozos.Length > 6 ? trozos[6] : "DESCONOCIDO";

                        FlightPlan plan = new FlightPlan(
                            trozos[0],
                            Convert.ToDouble(trozos[1]),
                            Convert.ToDouble(trozos[2]),
                            Convert.ToDouble(trozos[3]),
                            Convert.ToDouble(trozos[4]),
                            Convert.ToDouble(trozos[5]),
                            nombreEmpresa
                        );

                        this.AddFlightPlan(plan);
                    }
                    else
                    {
                        return -3;
                    }

                    linea = r.ReadLine();
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

        //Reiniciar Todos los flightplans a su posicion original
        public void ReiniciarPlanes()
        {
            for (int i = 0; i < this.NumElementosLista(); i++)
            {
                FlightPlan plan = this.GetFlightPlan(i);
                plan.Restart();
            }
        }
        public void GuardarPlan(string filename)//guarda el flightplan a larxiu
        {
            StreamWriter w = new StreamWriter(filename + ".txt"); //Guarda el archivo con este nombre.
            for (int i = 0; i < number; i++)
            {
                w.WriteLine(this.GetFlightPlan(i).GetId() + " " + this.GetFlightPlan(i).GetCurrentPosition().GetX().ToString() + " " + this.GetFlightPlan(i).GetCurrentPosition().GetY().ToString() + " " + this.GetFlightPlan(i).GetOriginalFinalPosition().GetX().ToString() + " " + this.GetFlightPlan(i).GetOriginalFinalPosition().GetY().ToString() + " " + this.GetFlightPlan(i).GetVelocidad().ToString()+" "+this.GetFlightPlan(i).GetNom());
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
        
        public int Indice(FlightPlan plan)
        {
            int i = 0;
            bool found = false;
            while (i<number && !found)
            {
                if (vector[i] == plan)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }
            if (found)
            {
                return i;
            }
            else
            {
                return -1;
            }
        }

        public bool ComprobarDesvio(double distanciaSeguridad)
        {
            List<FlightPlan> desvios = new List<FlightPlan>();
            bool retomados = false;

            for (int i = 0; i < number; i++)
            {
                if (vector[i].GetFinalPosition() != vector[i].GetOriginalFinalPosition())
                {
                    desvios.Add(vector[i]); //Añade todos los aviones desviados a la lista (aquellos cuyo destino final haya sido modificado).
                }
            }

            foreach (FlightPlan plan in desvios)
            {
                for (int i = 0; i < number; i++)
                {
                    if (!plan.RetomarRumbo(vector[i], distanciaSeguridad)) //Compueba que puedan retomar su rumbo
                    {
                        retomados = true; //Para refrescar el panel si alguno lo retoma.
                    }
                }
            }
            return retomados;
        }

        public bool Desviados() //Busca si hay algun avion desviado
        {
            bool found = false;
            for (int i = 0; i < number; i++)
            {
                if (vector[i].GetFinalPosition() == vector[i].GetOriginalFinalPosition())
                {
                    found = true;
                }
            }
            return found;
        }
    }
}