using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position currentPosition; // posicion actual
        Position initalPosition; // posicion inicial
        Position finalPosition; // posicion final
        double velocidad;

        // Constructor
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.currentPosition = new Position(cpx, cpy);
            this.initalPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }


        // Metodos
        //Gets i Sets
        
        public void SetId(string id)
        { this.id = id; }
        public void SetCurrentPosition(Position currentPosition)
        { this.currentPosition = currentPosition; }
        public void SetInitialPosition(Position initialPosition)
        { this.initalPosition = initialPosition; }
        public void SetFinalPosition(Position finalPosition)
        { this.finalPosition = finalPosition; }
        public void SetVelocidad(double velocidad)
        { this.velocidad = velocidad; }
        
        public string GetId()
        { return this.id;}
        public Position GetCurrentPosition()
        { return this.currentPosition;}
        public Position GetInitialPosition()
        { return this.initalPosition;}
        public Position GetFinalPosition()
        { return this.finalPosition;}
        public double GetVelocidad()
        { return this.velocidad;}
        public double GetDistanciaRestante()
        { return currentPosition.Distancia(finalPosition); }



        //FUNCIONES I MÉTODOS DE LA CLASE FLIGHTPLAN

        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            
            if (hipotenusa <= 1e-9)
            {
                currentPosition = finalPosition;
                return;
            }
            
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            // Modificar MoverVuelo para que no se pase del destino
            if (currentPosition.Distancia(nextPosition) < hipotenusa)
                currentPosition = nextPosition;
            else
                currentPosition = finalPosition;

        }


        //Calcula la distancia entre dos vuelos
        public double DistanceTo(FlightPlan plan)
        {
            Position p1 = this.currentPosition;
            Position p2 = plan.currentPosition;

            double distance = p1.Distancia(p2);
            return distance;
        }


        // Hacer un metodo que diga si un vuelo ha llegado a su destino
        public bool HasArrived()
        {
            return currentPosition.GetX() == finalPosition.GetX() &&
           currentPosition.GetY() == finalPosition.GetY();
        }


        // Si hay conflicto, reducir la velocidad de uno hasta que no haya conflicto o la velocidad sea 0
        public int ReducirVelocidad(FlightPlan plan2, double distanciaSeguridad)
        {
            double velocidad_0 = plan2.GetVelocidad();
            while (this.PredecirConflicto(plan2, distanciaSeguridad))
            {
                double nuevaVelocidad = this.velocidad * 0.99; //Reduce la velocidad de un vuelo de 1% en 1% hasta que ya no haya conflicto
                this.velocidad = nuevaVelocidad;
                double dist = this.DistanceTo(plan2);
                if (nuevaVelocidad < 10e-10)
                {
                    plan2.SetVelocidad(velocidad_0);
                    return 0;
                }
            }
            return 1;
        }


        // Hacer que el programa principal lea datos de dos vuelos y una distancia de seguidad y detecte el conflicto cuándo los vuelos están mas cerca de esa distancia
        public bool Conflicto(double currentDist, double distanciaSeguridad)
        {
            bool conclicto = false;

            if (currentDist < distanciaSeguridad) //que la distancia entre dos vuelos sea menor a la de seguridad
                conclicto = true;

            return conclicto;
        }


        public bool PredecirConflicto(FlightPlan plan2, double distanciaSeguridad)
        {
            //Predice si habrá conflicto según la fórmula analítica de la distancia derivada, que da una parábola con la distancia minima que habrá durante la simulacion.
            Position pa0 = this.initalPosition;
            Position paF = this.finalPosition;
            double dA = pa0.Distancia(paF);
            double tA = dA / (this.velocidad / 60); //minutos
            double vaX = (this.velocidad / 60) * (paF.GetX() - pa0.GetX()) / dA;
            double vaY = (this.velocidad / 60) * (paF.GetY() - pa0.GetY()) / dA;

            Position pb0 = plan2.initalPosition;
            Position pbF = plan2.finalPosition;
            double dB = pb0.Distancia(pbF);
            double tB = dB / (plan2.velocidad / 60);
            double vbX = (plan2.velocidad / 60) * (pbF.GetX() - pb0.GetX()) / dB;
            double vbY = (plan2.velocidad / 60) * (pbF.GetY() - pb0.GetY()) / dB;

            double x0 = pa0.GetX() - pb0.GetX();
            double y0 = pa0.GetY() - pb0.GetY();
            double vX = vaX - vbX;
            double vY = vaY - vbY;

            double a = vX * vX + vY * vY;
            double b = 2 * (x0 * vX + y0 * vY);

            if (Math.Abs(a) == 0)
            {
                return pa0.Distancia(pb0) < distanciaSeguridad;
            }

            double t_min = -b / (2 * a);
            double T_common = Math.Min(tA, tB);
            double t_check;

            if (t_min < 0)
            {
                t_check = 0;
            }
            else if (t_min > T_common)
            {
                t_check = T_common;
            }
            else
            {
                t_check = t_min;
            }

            //Si la distancia mínima es menor a la de segiridad devuelve false
            double paX_min = pa0.GetX() + vaX * t_check;
            double paY_min = pa0.GetY() + vaY * t_check;
            Position pa_min = new Position(paX_min, paY_min);
            double pbX_min = pb0.GetX() + vbX * t_check;
            double pbY_min = pb0.GetY() + vbY * t_check;
            Position pb_min = new Position(pbX_min, pbY_min);

            return pa_min.Distancia(pb_min) < distanciaSeguridad;
        }


        public void EscribeConsola()
        // Escribe en consola los datos del plan de vuelo
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Datos del vuelo: ");
            Console.WriteLine("Identificador: {0}", id);
            Console.WriteLine("Velocidad: {0:F2}", velocidad);
            Console.WriteLine("Posición actual: ({0:F2}, {1:F2})", currentPosition.GetX(), currentPosition.GetY());
            Console.WriteLine("Distancia restante: {0:F2}", GetDistanciaRestante());
            if (this.HasArrived())
                Console.WriteLine("Ha llegado al destino");
            Console.WriteLine("******************************");
        }


        public void Restart()
        {
            // Reinicia la posición actual a la posición inicial
            this.currentPosition = new Position(this.initalPosition.GetX(), this.initalPosition.GetY());
        }


        public FlightPlan Clone()
        {
            // Creamos copias nuevas de las posiciones (para no compartir las mismas referencias)
            Position copiaCurrent = new Position(this.currentPosition.GetX(), this.currentPosition.GetY());
            Position copiaInitial = new Position(this.initalPosition.GetX(), this.initalPosition.GetY());
            Position copiaFinal = new Position(this.finalPosition.GetX(), this.finalPosition.GetY());

            // Creamos un nuevo FlightPlan con los mismos datos
            FlightPlan clon;

            // Si company está vacía, usar constructor antiguo (para compatibilidad). Si no, usar el de 7 parámetros.
            clon = new FlightPlan(this.id, copiaCurrent.GetX(), copiaCurrent.GetY(), copiaFinal.GetX(), copiaFinal.GetY(), this.velocidad);

            // Sobrescribimos las posiciones con las copias
            clon.currentPosition = copiaCurrent;
            clon.initalPosition = copiaInitial;
            clon.finalPosition = copiaFinal;

            return clon;
        }
    }
}