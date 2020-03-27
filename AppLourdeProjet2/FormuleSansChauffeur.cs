using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    class FormuleSansChauffeur : Formule
    {
        private int duree;
        private double nbKmInclus;

        public FormuleSansChauffeur(int id, string libelle, int duree, double nbKmInclus) :base(id, libelle)
        {
            this.duree = duree;
            this.nbKmInclus = nbKmInclus;
        }

        public double NbKmInclus
        {
            get { return nbKmInclus; }
        }

        public int Duree
        {
            get { return duree; }
        }
    }
}
