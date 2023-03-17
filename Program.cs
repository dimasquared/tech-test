

class App
{
    static void Main()
    {
        double xA = Triangle.ReadCoordinate("A", "x");
        double yA = Triangle.ReadCoordinate("A", "y");
        double xB = Triangle.ReadCoordinate("B", "x");
        double yB = Triangle.ReadCoordinate("B", "y");
        double xC = Triangle.ReadCoordinate("C", "x");
        double yC = Triangle.ReadCoordinate("C", "y");
        
        Console.WriteLine("");
        
        double ab = Triangle.CalculateSideLength("ab", xA, yA, xB, yB);
        double bc = Triangle.CalculateSideLength("bс", xB, yB, xC, yC);
        double ac = Triangle.CalculateSideLength("aс", xA, yA, xC, yC);

        Triangle.IfEquilateral(ab, bc, ac);
        Triangle.IfIsosceles(ab, bc, ac);
        Triangle.IfRight(ab, bc, ac);

        double perimeter = Triangle.CalculatePerimeter(ab, bc, ac);
        
        
        
        Triangle.FindEvenNumbers(perimeter);
        
        Console.Write("\nPress any key to close...");
        Console.ReadKey();

    }
}


class Triangle
{
    public static double ReadCoordinate(string dotName, string coordinate)
    {
        double x = 0;
        
        do
        {
            Console.WriteLine($"Enter {coordinate} coordinate of dot {dotName}");
        } while (!Double.TryParse(Console.ReadLine(), out x));

        return x;
    }

    public static double CalculateSideLength(string sideName, double x1, double y1, double x2, double y2)
    {
        double sideLength = 0;
   
        sideLength = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);
        Console.WriteLine($"Lenght of {sideName.ToUpper()} is: {sideLength}");
        
        return sideLength;
    }

    public static void IfEquilateral(double sideLength1, double sideLength2, double sideLength3)
    {
        if (sideLength1 == sideLength2 && sideLength2 == sideLength3)
        {
            Console.WriteLine("\nTriangle IS 'Equilateral'");
        }
        else Console.WriteLine("\nTriangle IS NOT 'Equilateral'");
    }

    public static void IfIsosceles(double sideLength1, double sideLength2, double sideLength3)
    {
        if (sideLength1 == sideLength2 || sideLength1 == sideLength3 || sideLength3 == sideLength2)
        {
            Console.WriteLine("Triangle IS 'Isosceles'");
        }
        else Console.WriteLine("Triangle IS NOT 'Isosceles'");
    }

    public static void IfRight(double sideLength1, double sideLength2, double sideLength3)
    {
        if (sideLength1 == sideLength2 && sideLength2 == sideLength3)
        {
            Console.WriteLine("Triangle IS NOT 'Right'");
        }
        else
        {
            List<double> sides = new List<double>() { sideLength1, sideLength2, sideLength3 };
            List<double> sideSquared = new List<double>();
            
            foreach (var side in sides)
            {
                sideSquared.Add(Math.Pow(side, 2));
            }

            double maxSideSquared = sideSquared.Max();
            double sumSideSquared = sideSquared.Sum();
            double sumLessSideSquared = sumSideSquared - maxSideSquared;

            if (maxSideSquared == sumLessSideSquared)
            {
                Console.WriteLine("Triangle IS 'Right'\n");
            }
            else Console.WriteLine("Triangle IS NOT 'Right'\n");
        }
    }

    public static double CalculatePerimeter(double sideLength1, double sideLength2, double sideLength3)
    {
        double perimeter = sideLength1 + sideLength2 + sideLength3;
        Console.WriteLine($"Perimeter: {perimeter}\n");

        return perimeter;
    }

    public static void FindEvenNumbers(double perimeter)
    {
        for (int i = 0; i < perimeter; i += 2)
        {
            Console.WriteLine(i);
        }
    }
}