using Task1;
using Task2;
using Task3;
using Task4;

public class Programm
{
    public static void Main(string[] args)
    {
        FunctionsArePopping testFunctions = new FunctionsArePopping();
        testFunctions.RunTests();

        FlattenThoseNumbers flattenedArray = new FlattenThoseNumbers();
        flattenedArray.Execution();

        LeftRightUpDown calculation = new LeftRightUpDown();
        calculation.Execution();

        MyBooksTheyAreAMess sorting = new MyBooksTheyAreAMess();
        sorting.Execution();
    }
}

