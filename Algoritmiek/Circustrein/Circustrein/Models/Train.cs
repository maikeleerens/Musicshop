using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    class Train
    {
        public List<Wagon> Wagons { get; }

        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }

        public void AddWagon(Wagon wagon)
        {
            Wagons.Add(wagon);
        }
    }    
}
