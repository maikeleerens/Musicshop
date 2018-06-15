using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    class Animal
    {
        public bool IsCarnivore { get; set; }

        public Size AnimalSize { get; set; }

        public Animal(bool iscarnivore, Size size)
        {
            IsCarnivore = iscarnivore;
            AnimalSize = size;
        }

        public override string ToString()
        {
            return "Size: " + AnimalSize + ", " + "Carnivore: " + IsCarnivore;
        }
    }
}
