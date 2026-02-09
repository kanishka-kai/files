/* methods are reuseble code that can be invoked () these pranteses when invoking a
 * method is basiccly calling each other to execute a process. 
 * i used the older architype to easier follow
 * 
 * 
 * 
 * 
 * 
 * 
 */


using System;


namespace Methods.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Kai";
            int age = 21;

            SingHappyBirthday(name, age); // this a method in python called a function
            // here name and age is parameters where we want the method below should have access to it
            Console.ReadKey();
        }


        static void SingHappyBirthday(String name, int age) 
        {
            Console.WriteLine("happy birthday to you");
            Console.WriteLine("happy birthday dear " + name);
            Console.WriteLine("happy birthday to you!");
            Console.WriteLine("now you are " + age + " years old");
            Console.WriteLine();

        }

    }
}

// method overloading is where methods share the same name but has diffrent parameters