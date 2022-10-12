using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dog : Animal1
    {
        public override void Eat()
        {
            Console.WriteLine($"Собака кушает {_food}");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} мявкнул");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{_name} спит");
        }
        public override void GetInfo()
        {
            SetName();
            SetLocation();
            SetBreed();
            SetAge();
            Console.WriteLine();
            Console.WriteLine($"Имя собаки - {_name}");
            Console.WriteLine($"Место собаки - {_location}");
            Console.WriteLine($"Порода собаки - {_breed}");
            Console.WriteLine($"Возраст собаки - {_age}");
            Console.WriteLine();
        }

        public override void SetColor()
        {
            _color = "Салатовый";
        }

        public override void SetAge()
        {
            _age = 53;
        }

        public override void SetBreed()
        {
            _breed = "Кега";
        }

        public override void SetName()
        {
            _name = "Взорвалась";
        }

        public override void SetLocation()
        {
            _location = "Парковка";
        }

        public override void SetEat()
        {
            _food = "иво";
        }
    }
}
