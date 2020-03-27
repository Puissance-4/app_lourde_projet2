using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    class Modele
    {
        private int id;
        private string libelle;
        private double tarifKmSupplementaire;

        public Modele(int id, string libelle, float tarifKmSupplementaire)
        {
            this.id = id;
            this.libelle = libelle;
            this.tarifKmSupplementaire = tarifKmSupplementaire;
        }

        public double TarifKmSupplementaire
        {
            get { return tarifKmSupplementaire; }
        }
    }
}
