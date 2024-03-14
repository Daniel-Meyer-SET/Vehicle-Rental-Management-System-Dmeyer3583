using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class Motorcycle : Vehicle
    {
        private string fuelType;
        private bool hasFairing;

        public string FuelType { get { return fuelType; } set { fuelType = value; } }
        public bool HasFairing { get {  return hasFairing; } set {  hasFairing = value; } }

    }
}
