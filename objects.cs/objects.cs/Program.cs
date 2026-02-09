using System;


namespace objects.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human(); // creating an object using the blueprint class Human 
            Human human2 = new Human();
            
            /* here using constructors it would look like this
             * Car car1 = new Car("Ford","Mustang",2022,"red"); this is the paramenters sent to the special method Cars
             * 
             * 
             */

            human1.name = "Rick"; // assiging values to the objects.
            human1.age = 65;

            human2.name = "Morty";
            human2.age = 16;

            human1.Eat(); // telling what that object should do.
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }

    }
    class Human
    {
        public String name; // shows what the object has 
        public int age;//. name shows a waring because constructors are auto generated
        // constructors are special methods that has same name as the class they are inside of
        /*
         * 
         * for example
         * 
         * class Car
         * {
         *    String make;      these are what the objects have "charstrictics"
         *    String model;
         *    Int year;
         *    String color;
         * 
         * public Car(String make, String model, Int year, String color) the paramenters getting recived
         *{
         *      this.make = make;
         *      this.model = model;
         *      this.year = year;
         *      this.color = color;
         *
         *}
         * now that we have the charstrictics of the objects we use a method to
         * tell it what it should do in this instance drive
         *
         *public void Drive()
         *{
         *      Console.Writeline("you drive the " + make + " " + model);
         * 
         * 
         */


        public void Eat() // shows what an object can do
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()//.
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}