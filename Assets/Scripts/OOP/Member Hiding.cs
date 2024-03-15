using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemberHiding
{
    using UnityEngine;

    public class Animal
    {
        // Base version of the MakeSound method
        public virtual void MakeSound()
        {
            Debug.Log("Animal makes a generic sound");
        }
    }

    public class Dog : Animal
    {
        // Overrides the Animal version
        public override void MakeSound()
        {
            Debug.Log("Dog barks");
        }
    }

    public class Cat : Animal
    {
        // Overrides the Animal version
        public override void MakeSound()
        {
            Debug.Log("Cat meows");
        }
    }

    public class Zoo : MonoBehaviour
    {
        void Start()
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            // Each reference invokes its respective overridden method
            genericAnimal.MakeSound(); // Output: Animal makes a generic sound
            dog.MakeSound();           // Output: Dog barks
            cat.MakeSound();           // Output: Cat meows
        }
    }

}
