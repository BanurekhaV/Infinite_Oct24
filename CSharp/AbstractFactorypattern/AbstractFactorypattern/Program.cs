using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorypattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalfactory = null;
            string sound = null;

            //create factory objects
            Console.WriteLine("Enter the type of Animal (Land/Sea)");
            string atype = Console.ReadLine();
            animalfactory = AnimalFactory.CreateAnimalFactory(atype);
            Console.WriteLine("Animal Type Chosen is " + " " + animalfactory.GetType().Name);

            //create animal objects
            Console.WriteLine("Enter the Actual Animal");
            string animalname = Console.ReadLine();

            animal = animalfactory.GetAnimal(animalname);
            Console.WriteLine($"Animal Chosen is  {animalname}");

            sound = animal.Speak();
            Console.WriteLine($"The Sound of the {animal} comming from the Factory {animalfactory} is {sound}");
            Console.Read();
        }
    }
}
