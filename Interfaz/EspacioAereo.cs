using FlightLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class EspacioAereo : Form
    {

        //Atributos
        Interfaz.Principal principal;
        FlightPlanList miLista;
        int tiempoCiclo;
        float distanciaSeguridad;
        Stack<FlightPlanList> s = new Stack<FlightPlanList>();
        //vector de picture boxes para representar los aviones
        PictureBox[] vuelos;

        List<Position> finalPositionBackup = new List<Position>();
        List<int> indicesCambioRuta = new List<int>();


        //Constructor
        public EspacioAereo(Interfaz.Principal principal) //iniciar l'espai aeri
        {
            InitializeComponent();
            this.principal = principal;
        }


        //METODOS I FUNCIONWS NECESARIAS PARA LA SIMULACION

        private void DetectarYResolverConflictos()
        {
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                FlightPlan plan = miLista.GetFlightPlan(i);
                for (int j = 0; j + 1 < miLista.NumElementosLista(); j++)
                {
                    FlightPlan plan2 = miLista.GetFlightPlan(j);
                    if (plan != plan2)
                    {
                        bool a = false;
                        a = plan.PredecirConflicto(plan2, this.distanciaSeguridad);
                        if (a)
                        {
                            Conflicto nuevoFormulario = new Conflicto(miLista.GetFlightPlan(i).GetId(), miLista.GetFlightPlan(j).GetId());
                            DialogResult respuesta = nuevoFormulario.ShowDialog();
                            if (respuesta == DialogResult.Yes)
                            {
                                bool resultado = plan.ReducirVelocidad(plan2, distanciaSeguridad);
                                if (resultado)
                                {
                                    MessageBox.Show($"Se ha reducido la velocidad del vuelo {plan.GetId()} para evitar el conflicto.", "Conflicto resuelto automáticamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se ha podido solucionar el conflicto reduciendo la velocidad, se cambiaran las rutas.");
                                    finalPositionBackup.Add(plan.CambiarRumbo(plan2, distanciaSeguridad));
                                    int indice = miLista.Indice(plan);
                                    if (indice != -1)
                                    {
                                        indicesCambioRuta.Add(indice);
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }


        public void SetData(FlightPlanList f, int c, float distancia) //inicializar los datos
        {
            miLista = f;
            tiempoCiclo = c;
            distanciaSeguridad = distancia;
            if (miLista.NumElementosLista() != 0 && tiempoCiclo != 0 && distanciaSeguridad != 0)
            {
                DetectarYResolverConflictos();
            }
            else
            {
                MessageBox.Show("Asegurate de cargar los vuelos o introducir los parametros de seguridad");
            }

        }


        public void Reiniciar()//función reiniciar la simulación
        {
            Reloj.Stop();
            // Quitar todos los controles (vuelos, destinos, etc.)
            panel1.Controls.Clear();

            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                FlightPlan plan = miLista.GetFlightPlan(i);
                plan.Restart();
            }
            s.Clear(); // Limpiar la pila de estados
            // Volver a cargar los vuelos
            EspacioAereo_Load(this, EventArgs.Empty);
            MessageBox.Show("Es reinicia l'espai aeri");
            for(int i = 0; i<indicesCambioRuta.Count; i++)
            {
                miLista.GetFlightPlan(indicesCambioRuta[i]).SetFinalPosition(finalPositionBackup[i]);
            }
            indicesCambioRuta.Clear();
            finalPositionBackup.Clear();
            DetectarYResolverConflictos();
        }


        public void MoverFlightPlans(FlightPlanList miLista, int tiempo) //función para mover los flightplans una iteración
        {
            if (miLista == null) return;
            FlightPlanList backUpList = miLista.GiveLista();
            s.Push(backUpList);
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                // Representar vuelo de la posición i
                PictureBox p = new PictureBox();

                // Tamaño del elemento
                p.Width = 10;
                p.Height = 10;
                p.ClientSize = new Size(10, 10);

                FlightPlan plan = miLista.GetFlightPlan(i);
                plan.Mover(tiempo);
                int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 500.0);
                int y = (int)((plan.GetCurrentPosition().GetY() * panel1.Height / 500.0));
                vuelos[i].Location = new Point(x - p.Width / 2, y - p.Height / 2);
                panel1.Invalidate();

            }
        }


        public void BucleConflicto(bool a) //función para detectar conflicto
        {
            if (miLista == null) return;
            for (int i = 0; i < miLista.NumElementosLista(); i++)
            {
                FlightPlan plan = miLista.GetFlightPlan(i);
                for (int j = i + 1; j < miLista.NumElementosLista(); j++)
                {
                    FlightPlan plan2 = miLista.GetFlightPlan(j);
                    double dist = plan.DistanceTo(plan2);
                    a = (plan.DistanceTo(plan2) < distanciaSeguridad);
                    if (a)
                    {
                        Reloj.Stop();
                        MessageBox.Show("¡Conflicto detectado! La distancia entre los aviones es de " + dist.ToString("F2") + " unidades."); //missatge si hi ha conflicte
                        break;
                    }
                }
                if (a)
                {
                    Reloj.Stop(); //para la simulación si hay conflicto
                    break;
                }
            }
        }


        //METODOS I FUNCIONES DE CADA BOTÓN

        // Botón para cerrar sesión y volver al inicio de sesión
        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta EspacioAereo
            principal.Close(); // Cierra Principal
            string dbFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\SQLITEbd\basedatos.db");
            dbFile = Path.GetFullPath(dbFile);

            InicioSesionRegistro loginForm = new InicioSesionRegistro(dbFile);
            loginForm.Show();
        }


        private void EspacioAereo_Load(object sender, EventArgs e)//botón para cargar el espacio aéreo
        {
            RefrescarPanel();
        }

        private void RefrescarPanel()
        {
            try
            {
                if (miLista == null || miLista.NumElementosLista() == 0)
                {
                    // Nada que dibujar
                    return;
                }

                panel1.Controls.Clear(); // limpiar por si acaso
                vuelos = new PictureBox[miLista.NumElementosLista()];
                for (int i = 0; i < miLista.NumElementosLista(); i++)
                {
                    // Representar vuelo de la posición i
                    PictureBox p = new PictureBox();
                    FlightPlan plan = miLista.GetFlightPlan(i);

                    // Tamaño del elemento
                    p.Width = 10;
                    p.Height = 10;
                    p.ClientSize = new Size(10, 10);

                    // Calcular posición escalada
                    int x = (int)(plan.GetCurrentPosition().GetX() * panel1.Width / 500.0);
                    int y = (int)(plan.GetCurrentPosition().GetY() * panel1.Height / 500.0);

                    // Ajustar para centrar el círculo en las coordenadas
                    p.Location = new Point(x - p.Width / 2, y - p.Height / 2);


                    // Pero si querés que sea un CÍRCULO ROJO:
                    Bitmap bmp = new Bitmap(p.Width, p.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.FillEllipse(Brushes.Red, 0, 0, p.Width - 1, p.Height - 1);
                    }
                    p.Image = bmp;

                    // Guardar y agregar al panel
                    vuelos[i] = p;
                    panel1.Controls.Add(p);

                    // Crear el PictureBox del destino
                    PictureBox destino = new PictureBox();
                    destino.Width = 10;
                    destino.Height = 10;
                    destino.ClientSize = new Size(10, 10);

                    // Calcular posición del destino (escalar igual que el vuelo)
                    int xd = (int)(plan.GetFinalPosition().GetX() * panel1.Width / 500.0);
                    int yd = (int)(plan.GetFinalPosition().GetY() * panel1.Height / 500.0);

                    // Centrar la cruz en el punto destino
                    destino.Location = new Point(xd - destino.Width / 2, yd - destino.Height / 2);

                    // Dibujar una cruz
                    Bitmap bmp2 = new Bitmap(destino.Width, destino.Height);
                    using (Graphics g = Graphics.FromImage(bmp2))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        Pen pen = new Pen(Color.Blue, 2); // color y grosor de la cruz
                        g.DrawLine(pen, 0, destino.Height / 2, destino.Width, destino.Height / 2); // línea horizontal
                        g.DrawLine(pen, destino.Width / 2, 0, destino.Width / 2, destino.Height);  // línea vertical
                    }
                    destino.Image = bmp2;

                    // Agregar al panel
                    panel1.Controls.Add(destino);

                    // Evento de clic
                    p.Click += PictureBox_Click;

                    panel1.Invalidate();

                }
            }
            catch (Exception) { MessageBox.Show("Dades entrades no correctament"); }
        }

        private void botonMover_Click(object sender, EventArgs e)//botón para mover una iteración
        {
            bool b = miLista.LlegadoDestino();
            if (b == false)
            {
                MoverFlightPlans(miLista, tiempoCiclo);
                bool a = false;
                BucleConflicto(a);
            }
            else
            {
                MessageBox.Show("Tots els avions han arribat al seu destí.");//cuando llegan ya no se mueven más..
            }
            ComprobarDesvio();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)//botón para dibujar la elipse (dist seguridad) alrededor del avión
        {
            //Dibujar las rutas y las zonas de seguridad, así como los aviones en sus posiciones actuales y las líneas
            try
            {
                if (miLista == null) return;
                System.Drawing.Graphics graphics = e.Graphics;
                Pen rutaPen = new Pen(Color.Red);
                Pen zonaPen = new Pen(Color.Blue);
                int radio = (int)(distanciaSeguridad * panel1.Width / 1000);

                for (int i = 0; i < miLista.NumElementosLista(); i++)
                {
                    graphics.DrawLine(rutaPen, Convert.ToInt32(miLista.GetFlightPlan(i).GetInitialPosition().GetX() * panel1.Width / 500), Convert.ToInt32(miLista.GetFlightPlan(i).GetInitialPosition().GetY() * panel1.Height / 500), Convert.ToInt32(miLista.GetFlightPlan(i).GetFinalPosition().GetX() * panel1.Width / 500), Convert.ToInt32(miLista.GetFlightPlan(i).GetFinalPosition().GetY() * panel1.Height / 500));

                    int x = (int)(miLista.GetFlightPlan(i).GetCurrentPosition().GetX() * panel1.Width / 500);
                    int y = (int)(miLista.GetFlightPlan(i).GetCurrentPosition().GetY() * panel1.Height / 500);
                    graphics.DrawEllipse(zonaPen, x - radio, y - radio, radio * 2, radio * 2);

                }

                rutaPen.Dispose();
                zonaPen.Dispose();
            }
            catch
            {

            }


        }

        private void simularAut_Click(object sender, EventArgs e)// Boton para iniciar la simulacion automatica
        {
            Reloj.Interval = 100;
            Reloj.Start();

            if (finalPositionBackup != null)
            {
                reloj2.Interval = 100;
                reloj2.Start();
            }
        }

        private void Parar_Click(object sender, EventArgs e)// Boton para parar la simulacion automatica
        {
            Reloj.Stop();
        }

        private void Reloj_Tick_1(object sender, EventArgs e)// Si ha llegado al destino se para la simulación. Si no es así sigue automáticamente
        {
            if (miLista.LlegadoDestino())
            {
                Reloj.Stop();
                MessageBox.Show("Tots els avions han arribat al seu destí.");
            }
            else
            {
                //Mover los vuelos de la lista
                MoverFlightPlans(miLista, tiempoCiclo);
                panel1.Invalidate(); //Forzar al panel pintarse otra vez, para que pinte a cada movimiento del avion la zona de seguridad

                //Comprobar si hay conflicto
                bool a = false;
                BucleConflicto(a);
                panel1.Invalidate();
            }


        }


        private void Conflicte_Click(object sender, EventArgs e)// Detectar si hay conflicto
        {
            try
            {
                if (miLista != null && miLista.NumElementosLista() >= 2)
                {
                    bool a = miLista.GetFlightPlan(0).PredecirConflicto(miLista.GetFlightPlan(1), distanciaSeguridad);
                    if (a == true)
                    {
                        MessageBox.Show("Habrá conflicto en la trayectoria.");
                    }
                    else
                    {
                        MessageBox.Show("No hi haurà perill");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Dades no entrades correctament: no es pot trobar cap conflicte"); }
        }


        private void botonVolver_Click_1(object sender, EventArgs e)// botón para volver al menú principal
        {
            this.Close();
        }


        private void ButtonRestart_Click(object sender, EventArgs e)// botón para reiniciar la simulación
        {
            Reiniciar();
        }


        private void Retroceder_Click(object sender, EventArgs e) // botón para retroceder un paso/iteración en la simulación
        {
            if (s.Count > 0)
            {
                miLista = s.Pop();
                panel1.Controls.Clear();
                EspacioAereo_Load(this, EventArgs.Empty);
            }
            reloj2.Start();

        }


        private void ShowInfo_Click(object sender, EventArgs e)// botón para mostrar la información de los aviones al clicarlos
        {
            try
            {
                GridForAirspace nuevoFormulario = new GridForAirspace();
                nuevoFormulario.SetData(miLista);
                nuevoFormulario.Show();
            }
            catch (Exception) { MessageBox.Show("Dades no entrades correctament"); }
        }


        // Evento al clicar un PictureBox (avión)
        private void PictureBox_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < vuelos.Length)
            {
                if (vuelos[i] == sender)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }

            try
            {
                Informacion nuevoFormulario = new Informacion(this, miLista, i);
                nuevoFormulario.Show();
                miLista = nuevoFormulario.MyList();
            }
            catch
            {
                MessageBox.Show("Id no encontrada.");
            }
        }


        private void guardarBtn_Click(object sender, EventArgs e) // Botón para guardar la lista de vuelos en un archivo txt
        {
            Reloj.Stop();

            SaveFileDialog nuevoFormulario = new SaveFileDialog(); //Crea un nuevo formulario del tipo para guardar como
            nuevoFormulario.Title = "Guardar Lista de Vuelos";
            nuevoFormulario.Filter = "Archivos de Texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            nuevoFormulario.DefaultExt = "txt";
            nuevoFormulario.AddExtension = true; //Agrega .txt automáticamente si el usuario no lo escribe

            if (nuevoFormulario.ShowDialog() == DialogResult.OK) //El usuario guarda
            {
                string filePath = nuevoFormulario.FileName;
                miLista.GuardarPlan(filePath);
                MessageBox.Show("Lista guardada correctamente en: " + filePath);
            }

            //Reloj.Start();
        }

        private void ComprobarDesvio()
        {
            for (int i = 0; i < indicesCambioRuta.Count; i++)
            {
                for (int j = 0; j < miLista.NumElementosLista(); j++)
                {
                    if (j != indicesCambioRuta[i])
                    {
                        if (!miLista.GetFlightPlan(indicesCambioRuta[i]).RetomarRumbo(miLista.GetFlightPlan(j), distanciaSeguridad, finalPositionBackup[i]))
                        {
                            indicesEliminar.Push(i);
                            RefrescarPanel();
                        }
                    }
                }
            }
            while (0 < indicesEliminar.Count)
            {
                int i = indicesEliminar.Pop();
                indicesCambioRuta.RemoveAt(i);
                finalPositionBackup.RemoveAt(i);
            }
        }

        Stack<int> indicesEliminar = new Stack<int>();
        private void reloj2_Tick(object sender, EventArgs e) //Reloj usado para devolver al avion a su rumbo normal en caso de que se desvie (Asi no hay que hacer una comprobacion en cada tick en caso que no haya ningun desvio)
        {
            ComprobarDesvio();

            if (indicesCambioRuta.Count == 0)
            {
                reloj2.Stop();
            }

        }
    }
}