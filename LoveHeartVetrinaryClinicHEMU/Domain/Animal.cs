using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveHeartVetrinaryClinicHEMU.Domain
{
    class Animal
    {
        private string Name { get; }
        private string Species { get; }

        public Animal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetSpecies()
        {
            return Species;
        }
    }
}
