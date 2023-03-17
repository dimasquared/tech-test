class App
{
    static void Main()
    {
        Dot dotA = new Dot("A");
        Dot dotB = new Dot("B");
        Dot dotC = new Dot("C");
        dotA.ReadCoordinates();
        dotB.ReadCoordinates();
        dotC.ReadCoordinates();

        Console.WriteLine("");

        Triangle triangle = new Triangle(dotA, dotB, dotC);
        Console.WriteLine($"Lenght of {nameof(triangle.AB)} is: {triangle.AB}");
        Console.WriteLine($"Lenght of {nameof(triangle.BC)} is: {triangle.BC}");
        Console.WriteLine($"Lenght of {nameof(triangle.AC)} is: {triangle.AC}\n");

        if (triangle.IsEquilateral())
            Console.WriteLine("Triangle IS 'Equilateral'");
        else
            Console.WriteLine("Triangle IS NOT 'Equilateral'");

        if (triangle.IsIsosceles())
            Console.WriteLine("Triangle IS 'Isosceles'");
        else
            Console.WriteLine("Triangle IS NOT 'Isosceles'");

        if (triangle.IsRight())
            Console.WriteLine("Triangle IS 'Right'\n");
        else
            Console.WriteLine("Triangle IS NOT 'Right'\n");

        Console.WriteLine($"Perimeter: {triangle.Perimeter}\n");
        Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");

        for (int i = 0; i < triangle.Perimeter; i += 2)
        {
            Console.WriteLine(i);
        }

        Console.Write("\nPress any key to close...");
        Console.ReadKey();
    }
}

class Dot
{
    public string Name { get; }
    public double X { get; private set; }
    public double Y { get; private set; }

    public Dot(string name)
    {
        Name = name;
    }

    public void ReadCoordinates()
    {
        X = ReadCoordinate("x");
        Y = ReadCoordinate("y");
    }

    private double ReadCoordinate(string axisName)
    {
        double result;

        do
        {
            Console.WriteLine($"Enter {axisName} coordinate of dot {Name}");
        } while (!Double.TryParse(Console.ReadLine(), out result));

        return result;
    }
}

class Triangle
{
    public double AB { get; }
    public double BC { get; }
    public double AC { get; }
    public double Perimeter { get; }

    public Triangle(Dot a, Dot b, Dot c)
    {
        AB = CalculateSideLength(a, b);
        BC = CalculateSideLength(b, c);
        AC = CalculateSideLength(a, c);
        Perimeter = CalculatePerimeter();
    }

    public bool IsEquilateral()
    {
        bool result = AB == BC && BC == AC;
        return result;
    }

    public bool IsIsosceles()
    {
        bool result = AB == BC || AB == AC || BC == AC;
        return result;
    }

    public bool IsRight()
    {
        if (IsEquilateral())
        {
            return false;
        }

        List<double> sidesSquared = new List<double>() { Math.Pow(AB, 2), Math.Pow(BC, 2), Math.Pow(AC, 2) };

        double maxSideSquared = sidesSquared.Max();
        double sumSidesSquared = sidesSquared.Sum();
        double sumSmallerSidesSquared = sumSidesSquared - maxSideSquared;

        bool result = maxSideSquared == sumSmallerSidesSquared;
        return result;
    }

    private double CalculatePerimeter()
    {
        double perimeter = AB + BC + AC;
        return perimeter;
    }

    private double CalculateSideLength(Dot dot1, Dot dot2)
    {
        double result = Math.Pow(Math.Pow(dot2.X - dot1.X, 2) + Math.Pow(dot2.Y - dot1.Y, 2), 0.5);
        return result;
    }
}