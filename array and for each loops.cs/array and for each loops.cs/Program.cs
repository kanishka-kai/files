// See https://aka.ms/new-console-template for more information


/*Arrays have fixed storage lists are flexible in storage to call an array 
 * first decalare the data type then brackets []
 * 
 * array is a varible that can store multiple values
 * 
 */


//string[] cars = { "Tesla", "corvette", "mustang" };
string[] cars = new string[3];

cars[0] = "BMW";
cars[1] = "Corvette";
cars[2] = "Mustang";

for (int i = 0; i < cars.Length; i++)

Console.WriteLine(cars[i]);

//Console.WriteLine(cars[0]);

//foreach (string car in cars)  foreach loop is simpler but less flexible as forloop
//    Console.WriteLine(car);

Console.ReadKey();











Console.ReadKey();
