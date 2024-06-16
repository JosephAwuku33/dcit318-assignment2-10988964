using System;

namespace OOP
{
    // Base class
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("An Animal Sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal myAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            // Call MakeSound() method on each instance
            myAnimal.MakeSound();  // Output: Some generic sound
            myDog.MakeSound();     // Output: Bark
            myCat.MakeSound();     // Output: Meow

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
