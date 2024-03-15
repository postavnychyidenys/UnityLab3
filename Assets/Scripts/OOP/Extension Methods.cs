using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

    public class StringManipulator : MonoBehaviour
    {
        void Start()
        {
            string originalString = "Hello, world!";
            string reversedString = originalString.Reverse();
            Debug.Log("Original string: " + originalString);
            Debug.Log("Reversed string: " + reversedString);
        }
    }
}
