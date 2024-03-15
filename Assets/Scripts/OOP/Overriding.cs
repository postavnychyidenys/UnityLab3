using UnityEngine;

namespace Overriding
{
    public class Animal
    {
        public Animal()
        {
            Debug.Log("Animal constructor called");
        }

        public virtual void MakeSound()
        {
            Debug.Log("Generic animal sound");
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            Debug.Log("Dog constructor called");
        }

        public override void MakeSound()
        {
            Debug.Log("Woof!");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            Debug.Log("Cat constructor called");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }
    }

    public class AnimalFarm : MonoBehaviour
    {
        void Start()
        {
            Dog myDog = new Dog();
            myDog.MakeSound();  // Output: Woof!

            Cat myCat = new Cat();
            myCat.MakeSound();  // Output: Meow!

            // Polymorphism
            Animal genericAnimal = new Dog();
            genericAnimal.MakeSound();  // Output: Woof!

            genericAnimal = new Cat();
            genericAnimal.MakeSound();  // Output: Meow!
        }
    }

}
