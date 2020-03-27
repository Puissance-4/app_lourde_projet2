using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    class Vehicule
    {
        private string immatriculation;
        private DateTime dateAchat;
        private Modele leModele;

        public Vehicule(string immatriculation, DateTime dateAchat, Modele leModele)
        {
            this.immatriculation = immatriculation;
            this.dateAchat = dateAchat;
            this.leModele = leModele;
        }

        public Modele LeModele {
            get { return leModele; }
        }
    }
}
