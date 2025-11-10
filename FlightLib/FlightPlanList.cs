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

        private void EnsureCapacity()
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
        public int AddFlightPlan(FlightPlan p)
        {
            EnsureCapacity();
            vector[number] = p; //Si la lista no está llena, añade el plan dado como parametro y aumenta el contador
            number = number + 1;
            return 0;
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
                return vector[i]; //Retorna el plan en la posicion dada como parametro
            }
        }
        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < number)
            {
                vector[i].Mover(tiempo); //Mueve según la formula de MRU
                i++;
            }
        }

        public FlightPlan SearchID(string ID)
        {
            for (int i = 0; i < number; i++)
            {
                if (vector[i].GetId() == ID)
                {
                    return vector[i]; //Busca segun la ID del avion, y cuando lo encuentra lo devuelve y acaba el bucle
                }
            }
            return null;
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

        public int CargarLista(string filename)
        {
            try //Comprueba que existe un archivo con ese nombre o con el formato adecuado
            {
                string[] lineas = File.ReadAllLines(filename);
                this.vector = new FlightPlan[10];
                number = 0;

                foreach (string lineaRaw in lineas)
                {
                    string linea = lineaRaw.Trim();
                    if (string.IsNullOrEmpty(linea)) continue;

                    string[] trozos;
                    // robustez!
                    if (linea.Contains(";"))
                        trozos = linea.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    else
                        trozos = linea.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    try
                    {
                        if (trozos.Length == 6)
                        {
                            // ID xi yi xf yf velocidad
                            string id = trozos[0];
                            double xi = Convert.ToDouble(trozos[1], CultureInfo.InvariantCulture);
                            double yi = Convert.ToDouble(trozos[2], CultureInfo.InvariantCulture);
                            double xf = Convert.ToDouble(trozos[3], CultureInfo.InvariantCulture);
                            double yf = Convert.ToDouble(trozos[4], CultureInfo.InvariantCulture);
                            double velocidad = Convert.ToDouble(trozos[5], CultureInfo.InvariantCulture);

                            FlightPlan plan = new FlightPlan(id, xi, yi, xf, yf, velocidad);
                            this.AddFlightPlan(plan);
                        }
                        else if (trozos.Length >= 7)
                        {
                            // ID company xi yi xf yf velocidad
                            string id = trozos[0];
                            string company = trozos[1];
                            double xi = Convert.ToDouble(trozos[2], CultureInfo.InvariantCulture);
                            double yi = Convert.ToDouble(trozos[3], CultureInfo.InvariantCulture);
                            double xf = Convert.ToDouble(trozos[4], CultureInfo.InvariantCulture);
                            double yf = Convert.ToDouble(trozos[5], CultureInfo.InvariantCulture);
                            double velocidad = Convert.ToDouble(trozos[6], CultureInfo.InvariantCulture);

                            FlightPlan plan = new FlightPlan(id, xi, yi, xf, yf, velocidad, company);
                            this.AddFlightPlan(plan);
                        }
                        else
                        {
                            // línea mal formada se ignorar
                            // podrías acumular errores para avisar al usuario
                            continue;
                        }
                    }
                    catch
                    {
                        // parse error -> ignorar línea y continuar
                        continue;
                    }
                }

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
        public FlightPlanList GiveLista()
        {
            //Crea un objeto nuevo con los mismos valores para tener un backup de la lista original
            FlightPlanList clon = new FlightPlanList();
            for(int i = 0; i < this.number; i++)
            {
                FlightPlan planCopia = this.GetFlightPlan(i).Clone();
                clon.AddFlightPlan(planCopia);
            }
            return clon;
        }
         
        public void GuardarPlan(string filename)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(filename))
                {
                    for (int i = 0; i < number; i++)
                    {
                        FlightPlan p = this.GetFlightPlan(i);
                        string id = p.GetId();
                        string comp = p.GetCompania();
                        if (string.IsNullOrEmpty(comp)) comp = ""; // no nulo
                        double cpx = p.GetCurrentPosition().GetX();
                        double cpy = p.GetCurrentPosition().GetY();
                        double fpx = p.GetFinalPosition().GetX();
                        double fpy = p.GetFinalPosition().GetY();
                        double vel = p.GetVelocidad();

                        // formato: ID;company;cpx;cpy;fpx;fpy;vel
                        w.WriteLine($"{id};{comp};{cpx.ToString(CultureInfo.InvariantCulture)};{cpy.ToString(CultureInfo.InvariantCulture)};{fpx.ToString(CultureInfo.InvariantCulture)};{fpy.ToString(CultureInfo.InvariantCulture)};{vel.ToString(CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch
            {
                // si hay error de IO, dejamos que el llamador lo capture
            }
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
