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
    }
}
