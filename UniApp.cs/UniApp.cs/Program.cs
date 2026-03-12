using Microsoft.Win32;
using System.Diagnostics.Contracts;
using UniApp.cs;



Console.WriteLine("Hello, World!");
bool running = true;
while (running) 
{
    Console.WriteLine("--Menu---");
    Console.WriteLine("1. Opprett kurs");
    Console.WriteLine("2. Meld student til kurs");
    Console.WriteLine("3. Print kurs og deltagere");
    Console.WriteLine("4. Søk på kurs");
    Console.WriteLine("5. Søk på bok");
    Console.WriteLine("6. Lån bok");
    Console.WriteLine("7. Returner bok");
    Console.WriteLine("8. Registrer bok");
    Console.WriteLine("0. Avslutt");
    Console.WriteLine("ta en valg: ");
   
   string input = Console.ReadLine();
   int valg;

    if (int.TryParse(input, out valg))
    { 
        switch (valg) 
        {
            case 1:
                Console.WriteLine("dfsdf");
                

                break;
            case 2:
                Console.WriteLine("2");
                break;
            case 3:
                Console.WriteLine("3");
                break;
            case 4:
                Console.WriteLine("4");
                break;
            case 5:
                Console.WriteLine("5");
                break;
            case 6:
                Console.WriteLine("6");
                break;
            case 7:
                Console.WriteLine("7");    
                break;
            case 8:
                Console.WriteLine("8");
                break;
            case 0:
                Console.WriteLine("0");
                break;

            default:
                Console.WriteLine("ditt valget var ugyldig!");
                break;
        }
    }
    else 
    {
        Console.WriteLine("skriv inn et tall.");

    }
    
    


}


