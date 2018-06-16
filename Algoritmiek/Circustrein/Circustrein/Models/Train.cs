using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Models
{
    public class Train
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

        public void AddWagons(List<Wagon> wagon)
        {
            Wagons.AddRange(wagon);
        }
    }    
}
