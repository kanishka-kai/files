using System;
using System.Collections.Generic;
using System.Text;

namespace UniApp.cs
{
    abstract class Bruker
    {
        string name;
        string epost;
    }

    class Student:Bruker
    {
        int studentId;
        // list over kurs er student meldt opp i 
        
    }

    class UtVekslingStudent:Student
    {
        string land;
        string hjemmeuniversitet;
        // start and end date for the duration of stay.
    }

    class Ansatt : Bruker
    {    
        int ansattId;
        string stilling;
        string avdeling;
    }
}
