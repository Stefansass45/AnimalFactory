using animalFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalFactory
{
    public class AnimalFactory
    {
        public IAnimal returnInstance;
        public IAnimal GetAnimal(String AnimalType)
        {
            if (AnimalType.ToLower().Equals("Wolf"))
            {
                returnInstance = new Wolf();
            }
            else if (AnimalType.ToLower().Equals("Tuna"))
            {
                returnInstance = new Tuna();
            }
            else if (AnimalType.ToLower().Equals("Crocodile"))
            {
                returnInstance = new Crocodile();
            }
            else
            {
                returnInstance = new Cat();
            }
            return returnInstance;
        }
    }

}
