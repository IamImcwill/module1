
namespace Module1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter the radius of the circle:");
        //    if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0) 
        //    {
        //        double area = CalculateCircleArea(radius);

        //        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        //    }
        //}

        //static double CalculateCircleArea(double radius)
        //{
        //    return Math.PI * Math.Pow(radius, 2);
        //}
        static void Main(string[] args)
        {
            Console.Write("Enter the base length of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out double baseLength) && baseLength > 0)
            {
                Console.Write("Enter the height of the triangle: ");
                if (double.TryParse(Console.ReadLine(), out double height) && height > 0)
                {
                    double area = CalculateTriangleArea(baseLength, height);
                    Console.WriteLine($"The area of the triangle with base length {baseLength} and height {height} is: {area}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number for the height.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number for the base length.");
            }
        }

        static double CalculateTriangleArea(double baseLength, double height)
        {
            // Formula: Area = 0.5 * baseLength * height
            return 0.5 * baseLength * height;
        }
    }
}




