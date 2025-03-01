using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalFactory
{
    internal class Crocodile : IAnimal
    {
        public string getCommonName()
        {
            return "Crocodile";
        }

        public string getGenus()
        {
            return "Crocodylidae";
        }

        public string getSpecies()
        {
            return "Crocodylidae";
        }
    }
}
