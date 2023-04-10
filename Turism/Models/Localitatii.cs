using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turism.Models
{
    internal class Localitatii
    {

        private int id;
        private string text;

        public Localitatii(int id, string text) {
        
            this.id = id;
            this.text = text;

        }

        public int getId() { 
            return id; 
        }

        public string getText()
        {

            return text;
        }

    }
}
