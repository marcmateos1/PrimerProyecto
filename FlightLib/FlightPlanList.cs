using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
