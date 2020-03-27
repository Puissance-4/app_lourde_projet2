using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppLourdeProjet2
{
    class LocationSansChauffeur : Location
    {
        private double nbKmDepart;
        private double nbKmRetour;

        public LocationSansChauffeur (int numLocation, DateTime dateLocation, double montantRegle, double nbKmDepart, double nbKmRetour, Vehicule leVehicule, FormuleSansChauffeur laFormuleSansChauffeur) :base(numLocation, dateLocation, montantRegle, leVehicule)
        {
            this.nbKmDepart = nbKmDepart;
            this.nbKmRetour = nbKmRetour;
        }

        public double NbKmRetour
        {
            set { nbKmRetour = value; }
        }

        public double getMontantDepasForfait()
        {
            double montantDepasForfait = nbKmDepart - nbKmRetour;
            return montantDepasForfait;
        }
    }
}
