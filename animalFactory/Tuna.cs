using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalFactory
{
    internal class Tuna : IAnimal
    {
        public string getCommonName()
        {
            return "Tuna";
        }

        public string getGenus()
        {
            return "Thannus";
        }

        public string getSpecies()
        {
            return "Scombridae";
        }
    }
}

