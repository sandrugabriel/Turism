using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Turism.Models;

namespace Turism.Controllers
{
    internal class ControllerPlanificari
    {

        private List<Planificare> planificarii;

        public ControllerPlanificari()
        {

            planificarii = new List<Planificare>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath + @"/planificari.txt";
            StreamReader stream= new StreamReader(path);

            string text;

            while((text = stream.ReadLine())!= null)
            {

                Planificare planificare= new Planificare(text);

                planificarii.Add(planificare);

            }

            stream.Close();


        }

        public void afisare()
        {

            for(int i=0;i<planificarii.Count;i++)
            {
                MessageBox.Show(planificarii[i].getIdVizita().ToString());
            }

        }

    }
}
