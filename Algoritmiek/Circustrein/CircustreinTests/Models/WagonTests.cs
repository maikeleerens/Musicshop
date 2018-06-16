using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using Circustrein.Models;
using System.Linq;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        Wagon wagon;

        [TestInitialize]
        public void TestInitialize()
        {
            wagon = new Wagon();
        }

        [TestMethod()]
        public void AddOneAnimalTest()
        {
            wagon.AddAnimal(new Animal(true, Size.Medium));

            int amount = wagon.GetAnimals().Count();
            Animal animal = wagon.GetAnimals()[0];

            Assert.AreEqual(1, amount);
            Assert.AreEqual(new Animal(true, Size.Medium).IsCarnivore, animal.IsCarnivore);
            Assert.AreEqual(new Animal(true, Size.Medium).AnimalSize, animal.AnimalSize);
        }

        [TestMethod()]
        public void AddOneHundredAnimalTest()
        {
            for (int i = 0; i < 99; i++)
            {
                wagon.AddAnimal(new Animal(true, Size.Large));
            }
            wagon.AddAnimal(new Animal(true, Size.Medium));

            int amount = wagon.GetAnimals().Count();
            Animal animal1 = wagon.GetAnimals()[0];
            Animal animal2 = wagon.GetAnimals()[99];

            Assert.AreEqual(100, amount);
            Assert.AreEqual(new Animal(true, Size.Large).IsCarnivore, animal1.IsCarnivore);
            Assert.AreEqual(new Animal(true, Size.Large).AnimalSize, animal1.AnimalSize);

            Assert.AreEqual(new Animal(true, Size.Medium).IsCarnivore, animal2.IsCarnivore);
            Assert.AreEqual(new Animal(true, Size.Medium).AnimalSize, animal2.AnimalSize);
        }

        [TestMethod()]
        public void AnimalFitsTest()
        {
            Assert.IsTrue(wagon.AnimalFits(new Animal(false, Size.Large)));
        }

        [TestMethod()]
        public void AnimalDoesNotFitTest()
        {
            wagon.AddAnimal(new Animal(false, Size.Medium));
            wagon.AddAnimal(new Animal(false, Size.Medium));

            Assert.IsFalse(wagon.AnimalFits(new Animal(false, Size.Large)));
        }

        [TestMethod()]
        public void WagonContainsCarnivore()
        {
            wagon.AddAnimal(new Animal(true, Size.Medium));            

            Assert.IsNotNull(wagon.carnivore);
        }    

    [TestMethod()]
        public void CarnivoreDoesNotFitTest()
        {
            wagon.AddAnimal(new Animal(true, Size.Large));

            Assert.IsFalse(wagon.AnimalFits(new Animal(false, Size.Medium)));
        }
    }
}