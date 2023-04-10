using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Turism.Models
{
    internal class Planificari
    {

        private int idVizita;
        private int idLocalitate;
        private string frecventa;
        private DateTime dataStart;
        private DateTime dataEnd;
        private int ziua;

        public Planificari(int idvizita, int idlocalitate, string frecventa, DateTime dataStart, DateTime dataEnd)
        {

            this.idVizita = idvizita;
            this.idLocalitate = idlocalitate;
            this.frecventa = frecventa;
            this.dataStart = dataStart;
            this.dataEnd = dataEnd;

        }

        public int getIdVizita()
        {
            return idVizita;
        }

        public int getIdLocalitate()
        {
            return idLocalitate;
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
