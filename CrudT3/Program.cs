using T3_Crud;
using System;
using System.Windows.Forms;


namespace T3_Crud
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Configurar el modelo de un solo subproceso para la aplicaci�n de Windows Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Iniciar la aplicaci�n con Form1
        }
    }
}
