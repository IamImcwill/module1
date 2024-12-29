
namespace Module1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            if (double.TryParse(Console.ReadLine(), out double radius) && radius >= 0) 
            {
                double area = CalculateCircleArea(radius);

                Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
            }
        }

        static double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
