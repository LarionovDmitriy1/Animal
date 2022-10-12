using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal1
    {
        protected string _food;
        protected string _location;
        protected string _breed;
        protected string _name;
        protected string _color;
        protected int _age;

        public abstract void MakeNoise();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void GetInfo();
        public abstract void SetColor();
        public abstract void SetAge();
        public abstract void SetBreed();
        public abstract void SetName();
        public abstract void SetLocation();
        public abstract void SetEat();

    }
}
