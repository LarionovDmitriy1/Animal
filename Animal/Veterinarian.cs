using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Veterinarian
    {
        public void TreatAnimal(Animal1 animal)
        {
            Console.WriteLine("Животное принято на приём");
            animal.GetInfo();

        }
    }
}
