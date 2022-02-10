using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;  // pi value can never be changed 
            

            Console.Write("Enter radius: ");  // User enters a radius 
            double radious = Convert.ToDouble(Console.ReadLine());  // Converts users input to a double 
            double Area = pi * radious * radious;   // Formula for Area of a circle 
            double result = Math.Round(Area, 1, MidpointRounding.AwayFromZero);   // Answer is then rounded to the first decimal point 

            Console.WriteLine("Area of a circle: " + result); // displays the answer to area of the circle 
            Console.ReadKey();
        }
    }
}
