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


        public List<string> getListLoc()
        {

            List<string> list = new List<string>();

            for(int i = 0; i < planificarii.Count; i++)
            {

                list.Add(planificarii[i].getLocalitate());

            }

            return list;
        }

        public List<string> getImgList(string loc)
        {

            for(int i = 0; i < planificarii.Count; i++)
            {
                if(planificarii[i].getLocalitate().Equals(loc))
                {
                  // MessageBox.Show(planificarii[i].getListImg().Count.ToString());

                     return planificarii[i].getListImg();

                }
            }
            return null;
        }

    }
}
