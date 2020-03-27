using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLourdeProjet2
{
    abstract class Location
    {
        private int numLocation;
        private DateTime dateLocation;
        private double montantRegle;
        private Vehicule leVehicule;

        public Location(int numLocation, DateTime dateLocation, double montantRegle, Vehicule leVehicule)
        {
            this.numLocation = numLocation;
            this.dateLocation = dateLocation;
            this.montantRegle = montantRegle;
            this.leVehicule = leVehicule;
        }

        public Vehicule LeVehicule
        {
            get { return leVehicule; }
        }

        public double MontantRegle
        {
            get { return montantRegle; }
        }
    }
}
