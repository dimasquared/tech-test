

   Console.WriteLine("Enter x coordinate of dot A");
   Double.TryParse(Console.ReadLine(), out double xA);
   
   Console.WriteLine("Enter y coordinate of dot A"); 
   Double.TryParse(Console.ReadLine(), out double yA);
   
   Console.WriteLine("Enter x coordinate of dot B");
   Double.TryParse(Console.ReadLine(), out double xB);
   
   Console.WriteLine("Enter y coordinate of dot B");
   Double.TryParse(Console.ReadLine(), out double yB);
   
   Console.WriteLine("Enter x coordinate of dot C");
   Double.TryParse(Console.ReadLine(), out double xC);
   
   Console.WriteLine("Enter y coordinate of dot C");
   Double.TryParse(Console.ReadLine(), out double yC);

   double ab = 0;
   double bc = 0;
   double ac = 0;
   
   ab = Math.Pow(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2), 0.5);
   Console.WriteLine($"\nLenght of AB is: {ab}");
   
   bc = Math.Pow(Math.Pow(xC - xB, 2) + Math.Pow(yC - yB, 2), 0.5);
   Console.WriteLine($"Lenght of BC is: {bc}");
   
   ac = Math.Pow(Math.Pow(xC - xA, 2) + Math.Pow(yC - yA, 2), 0.5);
   Console.WriteLine($"Lenght of AC is: {ac}\n");

   if (ab == bc && bc == ac)
   {
       Console.WriteLine("Triangle IS 'Equilateral'");
       Console.WriteLine("Triangle IS 'Isosceles'");
       Console.WriteLine("Triangle IS NOT 'Right'\n");
   }
   else
   {
       Console.WriteLine("Triangle IS NOT 'Equilateral'");
       
       if (ab == bc || bc == ac || ab == ac)
       {
           Console.WriteLine("Triangle IS 'Isosceles'");
       }
       else Console.WriteLine("Triangle IS NOT 'Isosceles'");
       
       if (ab > bc && ab > ac)
       {
           if (Math.Pow(ab, 2) == Math.Pow(bc, 2) + Math.Pow(ac, 2))
           {
               Console.WriteLine("Triangle IS 'Right'\n");
           }
           else Console.WriteLine("Triangle IS NOT 'Right'\n");
       }
       else
       {
           if (bc > ab && bc > ac)
           {
               if (Math.Pow(bc, 2) == Math.Pow(ab, 2) + Math.Pow(ac, 2))
               {
                   Console.WriteLine("Triangle IS 'Right'\n");
               }
               else Console.WriteLine("Triangle IS NOT 'Right'\n");
           }
           else
           {
               if (Math.Pow(ac, 2) == Math.Pow(ab, 2) + Math.Pow(bc, 2))
               {
                   Console.WriteLine("Triangle IS 'Right'\n");
               }
               else Console.WriteLine("Triangle IS NOT 'Right'\n");
           }
       }
   }

   double perimeter = ab + bc + ac;
   Console.WriteLine($"Perimeter: {perimeter}\n");

   for (int i = 0; i < perimeter; i += 2)
   {
       Console.WriteLine(i);
   }
   
   