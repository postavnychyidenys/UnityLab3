using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    public class Vehicle
    {
        public string type;

        public Vehicle()
        {
            type = "generic";
            Debug.Log("Vehicle constructor called");
        }

        public Vehicle(string newType)
        {
            type = newType;
            Debug.Log("Vehicle constructor called with type: " + type);
        }

        public void StartEngine()
        {
            Debug.Log("Starting the " + type + " vehicle engine.");
        }
    }

    public class Car : Vehicle
    {
        public Car() : base("car")
        {
            Debug.Log("Car constructor called");
        }
    }

    public class Truck : Vehicle
    {
        public Truck() : base("truck")
        {
            Debug.Log("Truck constructor called");
        }
    }

    public class VehicleManager : MonoBehaviour
    {
        void Start()
        {
            Vehicle genericVehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle truck = new Truck();

            genericVehicle.StartEngine();
            car.StartEngine();
            truck.StartEngine();
        }
    }
}
