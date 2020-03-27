using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    class FormuleAvecChauffeur : Formule
    {
        private string lieu;
        private double tarif;

        public FormuleAvecChauffeur(int id, string libelle, string lieu, double tarif) :base(id, libelle)
        {
            this.lieu = lieu;
            this.tarif = tarif;
        }

        public string Lieu
        {
            get { return lieu; }
        }

        public double Tarif
        {
            get { return tarif; }
        }
    }
}
