using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MethodOverloading
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Method to add three integers
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // Method to concatenate two strings
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        // Method to concatenate three strings
        public string Add(string str1, string str2, string str3)
        {
            return str1 + str2 + str3;
        }
    }

    public class CalculatorManager : MonoBehaviour
    {
        void Start()
        {
            Calculator calculator = new Calculator();

            // Calls the appropriate Add method based on arguments
            int sum1 = calculator.Add(1, 2);
            int sum2 = calculator.Add(1, 2, 3);
            string result1 = calculator.Add("Hello ", "World");
            string result2 = calculator.Add("Hello ", "beautiful ", "world");

            Debug.Log("Sum 1: " + sum1);         // Output: Sum 1: 3
            Debug.Log("Sum 2: " + sum2);         // Output: Sum 2: 6
            Debug.Log("Result 1: " + result1);   // Output: Result 1: Hello World
            Debug.Log("Result 2: " + result2);   // Output: Result 2: Hello beautiful world
        }
    }
}
