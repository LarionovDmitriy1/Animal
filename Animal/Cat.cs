using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat : Animal1
    {
       
        public override void Eat()
        {
            Console.WriteLine($"Кот жрёт {_food}");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} гавкнул");
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
            Console.WriteLine($"Имя кота - {_name}");
            Console.WriteLine($"Место кота - {_location}");
            Console.WriteLine($"Порода кота - {_breed}");
            Console.WriteLine($"Возраст кота - {_age}");
            Console.WriteLine();
        }

        public override void SetColor()
        {
            _color = "Зелёный";
        }

        public override void SetAge()
        {
            _age = 3;
        }

        public override void SetBreed()
        {
            _breed = "Мейнкун";
        }

        public override void SetName()
        {
            _name = "Кiт";
        }

        public override void SetLocation()
        {
            _location = "Туалет";
        }

        public override void SetEat()
        {
            _food = "китикет";
        }
    }
}
