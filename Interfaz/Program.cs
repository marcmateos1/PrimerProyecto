
using System;
using System.Windows.Forms;

namespace Interfaz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
        ApplicationConfiguration.Initialize();

        // Crear y mostrar el formulario de inicio de sesión
        InicioSesionRegistro loginForm = new InicioSesionRegistro();
        Application.Run(loginForm);
        }
    }
}