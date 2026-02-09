// See https://aka.ms/new-console-template for more information
int friends = 5;

friends = friends + 1;
//friends += 1; ###prefered way###
//friends++;

//friends = friends - 1;
//friends -= 1;
//friends--;

//friends = friends * 2;
//friends *= 2;

//friends = friends / 2;
//friends /= 2;

//int remainder = friends % 2;
//Console.WriteLine(remainder);

Console.WriteLine(friends);

// math operations
double x = 3;
double y = 5;

double a = Math.Pow(x, 2); // 3**2
double b = Math.Sqrt(x); //Square root
double c = Math.Abs(x); //absoulte positive of the num
double d = Math.Round(x); //Rounds up and down
double e = Math.Ceiling(x); //always rounds up
double f = Math.Floor(x); // always rounds down
double g = Math.Max(x, y); //Hightest valuse between 2 numbers
double h = Math.Min(x, y); //same as above but reverse


Console.WriteLine(a);

Console.ReadKey();