using System;

namespace MyApplication {
    class Car { // creating a car class
        public string model; // creating a field
        public Car(string modelName) {  // creating a class constructor
            model = "Mustang"; // setting the initial value for model
        }

        static void Main(string[] args) {
            Car Ford = new Car("Mustang"); // creting an object of the car class 
            Console.WriteLine(Ford.model); // Printing the value of model
        }
    }
}