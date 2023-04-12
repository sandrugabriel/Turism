using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turism.Models
{
    internal class Planificare
    {
        private List<string> imaginii = new List<string>();
        private int idVizita;
        private string localitate;
        private string frecventa;
        private DateTime dataStart;
        private DateTime dataEnd;
        private int ziua;

        public Planificare(int idvizita, string localitate, string frecventa, DateTime dataStart, DateTime dataEnd, List<string> list)
        {

            this.idVizita = idvizita;
            this.localitate =  localitate;
            this.frecventa = frecventa;
            this.dataStart = dataStart;
            this.dataEnd = dataEnd;
            this.imaginii = list;

        }

        public Planificare(string text) { 
        
            string[] prop = text.Split('*');
            
            this.idVizita = int.Parse(prop[0]);
            this.localitate = prop[1];
            this.frecventa = prop[2];

            int dim = prop.Length;
            if (prop[2].Equals("ocazional"))
            { 
                this.dataStart = DateTime.Parse(prop[3]);
                this.dataEnd = DateTime.Parse(prop[4]);

                   

                for (int i = 5; i < dim; i++)
                {
                    this.imaginii.Add(prop[i]);
                   
                }

            }
            else
            {
                this.ziua = int.Parse(prop[3]);

                for (int i = 4; i < dim; i++)
                {
                    this.imaginii.Add(prop[i]);
                }
            }


        
        }

        public int getIdVizita()
        {
            return idVizita;
        }

        public string getFrecventa()
        {
            return frecventa;
        }

        public List<string> getListImg()
        {
           // MessageBox.Show(imaginii.Count.ToString());
            return imaginii;
        }

        public string getLocalitate()
        {
            return localitate;
        }

        public DateTime getDataStart()
        {
            return dataStart;
        }

        public DateTime getDataEnd()
        {
            return dataEnd;
        }

        public int getziua()
        {
            return ziua;
        }
    }
}
