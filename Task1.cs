namespace Task1;

public class FunctionsArePopping
{
    double Square(double number)
    {
        return number * number;
    }

    double InchToMM(double number)
    {
        return number * 25.4;
    }

    double Root(double number)
    {
        return Math.Sqrt(number);
    }

    double Cube(double number)
    {
        return number * number * number;
    }

    double AreaOfCircle(double number)
    {
        return 3.14159 * number * number;
    }

    string PersonalGreeting(string name)
    {
        return $"Hello {name}";
    }
    public void RunTests()
    {
        Console.WriteLine("🌼Functions are a popping🌼");

        TestDouble(4, Square(2), "Square of 2");
        TestDouble(127, InchToMM(5), "5 Inches converted to mm ");
        TestDouble(10, Root(100), "Root of 100");
        TestDouble(27, Cube(3), "Cube of 3");
        TestDouble(50.26544, AreaOfCircle(4), "Area of a circle given a radius of 4");
        TestString("Hello Bob", PersonalGreeting("Bob"), "Personal Greeting");
    }

    void TestDouble(double expected, double actual, string description = "Test")
    {
        if (expected == actual)
        {
            Console.WriteLine($"🟢 {description}, result {actual}");
        }
        else
        {
            Console.WriteLine($"🔴 {description}, expected {expected}, received {actual}");
        }
    }

    void TestString(string expected, string actual, string description = "Test")
    {
        if (expected == actual)
        {
            Console.WriteLine($"🟢 {description}, result {actual}");
        }
        else
        {
            Console.WriteLine($"🔴 {description}, expected {expected}, received {actual}");
        }
    }
}