using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Horse : Animal1
    {
        public override void Eat()
        {
            Console.WriteLine($"Конина жрёт {_food}");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"{_name} ржёт");
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
            Console.WriteLine($"Имя лошади - {_name}");
            Console.WriteLine($"Место лошади - {_location}");
            Console.WriteLine($"Порода лошади - {_breed}");
            Console.WriteLine($"Возраст лошади - {_age}");
            Console.WriteLine();
        }

        public override void SetColor()
        {
            _color = "Фиолетовая";
        }

        public override void SetAge()
        {
            _age = 233;
        }

        public override void SetBreed()
        {
            _breed = "Пони";
        }

        public override void SetName()
        {
            _name = "Антонина";
        }

        public override void SetLocation()
        {
            _location = "Будка";
        }

        public override void SetEat()
        {
            _food = "овец";
        }
    }
}
