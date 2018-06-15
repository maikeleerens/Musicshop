using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Circustrein.Models;

namespace Circustrein
{
    class Logic
    {
        private List<Wagon> wagons;
        private Train train;

        public Logic()
        {
            wagons = new List<Wagon> { new Wagon() };
            train = new Train();
        }

        public Train CreateWagons(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                bool AnimalPlaced = false;
                foreach (Wagon wagon in wagons)
                {
                    if (wagon.AnimalFits(animal))
                    {
                        wagon.AddAnimal(animal);
                        AnimalPlaced = true;
                    }
                }

                if (!AnimalPlaced)
                {
                    if (!CheckWagonsForSpace(animal))
                    {
                        Wagon newWagon = new Wagon();
                        newWagon.AddAnimal(animal);
                        wagons.Add(newWagon);
                    }
                }
            }
            train.AddWagons(wagons);
            return train;
        }

        public bool CheckWagonsForSpace(Animal animal)
        {
            bool AnimalPlaced = false;
            foreach (Wagon wagon in wagons)
            {
                if (wagon.AnimalFits(animal))
                {
                    wagon.AddAnimal(animal);
                    AnimalPlaced = true;
                }
                else
                {                    
                    AnimalPlaced = false;
                }
            }
            return AnimalPlaced;
        }
    }
}
