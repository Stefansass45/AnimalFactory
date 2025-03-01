using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalFactory
{
    internal class Cat : IAnimal
    {
        public string getCommonName()
        {
            return "Cat";
        }

        public string getGenus()
        {
            return "Felis";
        }

        public string getSpecies()
        {
            return "Catus";
        }
    }
}
