using Lib.Controller;
using Lib.View;
namespace Lib
{
     static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CAutentificare administratorC = new CAutentificare();
            Application.Run(administratorC.AccesAutentificareView());
        }
    }
}
  