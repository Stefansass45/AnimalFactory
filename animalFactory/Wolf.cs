using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalFactory
{
    internal class Wolf : IAnimal
    {
        public string getCommonName()
        {
            return "Wolf";
        }

        public string getGenus()
        {
            return "Canis";
        }

        public string getSpecies()
        {
            return "Lupis";
        }
    }
}
