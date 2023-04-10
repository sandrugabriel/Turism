using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turism.Controllers;

namespace Turism
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Turism());

            ControllerPlanificari controllerPlanificari = new ControllerPlanificari();
            controllerPlanificari.afisare();
        }
    }
}
