using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    class LocationAvecChauffeur : Location
    {
        private FormuleAvecChauffeur laFormuleAvecChauffeur;

        public LocationAvecChauffeur(int numLocation, DateTime dateLocation, double montantRegle, Vehicule leVehicule, FormuleAvecChauffeur laFormuleAvecChauffeur) :base(numLocation, dateLocation, montantRegle, leVehicule)
        {
            this.laFormuleAvecChauffeur = laFormuleAvecChauffeur;
        }
    }
}
