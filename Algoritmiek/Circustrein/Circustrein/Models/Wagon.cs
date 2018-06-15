using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    class Wagon
    {
        private List<Animal> Animals;
        private int AnimalCounter;
        private Animal carnivore;

        public Wagon()
        {
            Animals = new List<Animal>();
            AnimalCounter = 0;
            carnivore = null;
        }

        public void AddAnimal(Animal animal)
        {
            AnimalCounter += Convert.ToInt32(animal.AnimalSize);
            Animals.Add(animal);

            if (animal.IsCarnivore)
            {
                carnivore = animal;
            }
        }

        public bool AnimalFits(Animal animal)
        {
            if (AnimalCounter + Convert.ToInt32(animal.AnimalSize) > 10)
            {
                return false;
            }
            else if (carnivore != null && animal.IsCarnivore)
            {
                return false;
            }
            else if (carnivore != null && Convert.ToInt32(animal.AnimalSize) <= Convert.ToInt32(carnivore.AnimalSize))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
