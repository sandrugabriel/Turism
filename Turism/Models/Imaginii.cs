using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turism.Models
{
    internal class Imaginii
    {

        private int idimagine;
        private int idLocalitate;
        private string caleFisier;

        public Imaginii(int idimagine, int idLocalitate, string caleFisier)
        {
            this.idimagine = idimagine;
            this.idLocalitate = idLocalitate;
            this.caleFisier = caleFisier;
        }

        public int getIdimagine()
        {
            return idimagine;
        }

        public int getIDLocalitate()
        {
            return idLocalitate;
        }

        public string getCaleFisier()
        {

            return caleFisier;
        }

    }
}
