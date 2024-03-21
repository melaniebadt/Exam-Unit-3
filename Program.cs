using System;
using Task1;
using Task2;

public class Programm
{
    public static void Main(string[] args)
    {
        FunctionsArePopping testFunctions = new FunctionsArePopping();
        testFunctions.RunTests();

        FlattenThoseNumbers flattenedArray = new FlattenThoseNumbers();
        flattenedArray.Execution();
    }
}

