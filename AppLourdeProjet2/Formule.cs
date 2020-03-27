using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    abstract class Formule
    {
        private int id;
        private string libelle;

        public Formule(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }

        public string Libelle
        {
            get { return libelle; }
        }
    }
}
