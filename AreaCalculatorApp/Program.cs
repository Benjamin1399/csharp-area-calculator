using AreaCalculatorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace AreaCalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string done;

            do
            {
                Console.WriteLine("Which shape would you like the area for: (Circle, Triangle, Rectangle, Square) ");
                string shape = Console.ReadLine();

                if (shape.ToLower() == "circle")
                {
                    Console.WriteLine("Enter radius: ");
                    string radiusText = Console.ReadLine();

                    double.TryParse(radiusText, out double radius);

                    CircleModel circle = new CircleModel();
                    circle.Radius = radius;

                    Console.WriteLine($"Area of circle is: {circle.CalculateArea()}");
                }
                else if (shape.ToLower() == "triangle")
                {
                    Console.WriteLine("Enter base: ");
                    string baseText = Console.ReadLine();
                    double.TryParse(baseText, out double baseValue);

                    Console.WriteLine("Enter height: ");
                    string heightText = Console.ReadLine();

                    double.TryParse(heightText, out double height);

                    TriangleModel triangle = new TriangleModel();
                    triangle.Base = baseValue;
                    triangle.Height = height;


                    Console.WriteLine($"Area of Triangle is: {triangle.CalculateArea()}");
                }
                else if (shape.ToLower() == "rectangle")
                {
                    Console.WriteLine("Enter Length: ");
                    string lengthText = Console.ReadLine();
                    double.TryParse(lengthText, out double length);

                    Console.WriteLine("Enter height: ");
                    string heightText = Console.ReadLine();
                    double.TryParse(heightText, out double height);

                    RectangleModel rectangle = new RectangleModel();
                    rectangle.Length = length;
                    rectangle.Height = height;


                    Console.WriteLine($"Area of Rectangle is: {rectangle.CalculateArea()}");
                }
                else if (shape.ToLower() == "square")
                {
                    Console.WriteLine("Enter length: ");
                    string lengthText = Console.ReadLine();

                    double.TryParse(lengthText, out double length);

                    SquareModel square = new SquareModel();
                    square.Length = length;

                    Console.WriteLine($"Area of Square is: {square.CalculateArea()}");
                }

                Console.WriteLine("Done? (yes/no) ");
                done = Console.ReadLine();

            } while (done.ToLower() == "no");
        }
    }
}
