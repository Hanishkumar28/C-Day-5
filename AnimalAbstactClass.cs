using System;
using System.Collections.Generic;
using System.Text;

namespace Day5
{
    public abstract class Animal
    {
        private string Name;
        public string SetName(string _name)
        {
            Name = _name;
            return Name;
        }
        public string GetName()
        {
            Console.WriteLine("Name of the Dog is "+Name);
            return Name;
        }
        public abstract void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is Eating");
        }
        static void Main()
        {
            Dog dog1 = new Dog();
            dog1.SetName("Puppy");
            dog1.GetName();
            dog1.Eat();
        }
    }
}