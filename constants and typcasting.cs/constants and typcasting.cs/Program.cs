/* to add more security and reinforcement to data stabilty the command 
 * (const) before declaration locks the value because computers read the last 
 * statement and overrides the previos statements when compliling code to console
 * in simpler techincal words "immutable"
 */

const double pi = 3.14159;

Console.WriteLine(pi);


/* Typecasting is changing one datatype to another f.exp. string to int
 * to do this the command
 * "Convert" and ToInt32,ToDouble,ToString is used depending what datatype is needed
 * #GetType is used to show what datatype the specified varible is.
 * 
 */

string a = "12"; //just because i converted the value to int doesnt mean the value
int b =Convert.ToInt32(a); // got deleted it just makes a copy in another datatype

Console.WriteLine(a);
Console.WriteLine(a.GetType());

Console.WriteLine(b);
Console.WriteLine(b.GetType());



Console.ReadKey();