using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorypattern
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow";
        }
    }

    public class Dog:IAnimal
    {
        public string Speak()
        {
            return "Bow Bow";
        }
    }

    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }

    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "Squawck";
        }
    }
}
