using System;

namespace ROOM_CALCULATOR
{
    public class RoomCalculator
    {
        public static void Main(string[] args)
        {
            const double MEDIUM_MIN = 251;
            const double LARGE_MIN = 650;

            Console.WriteLine();
            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

            Console.Write("Please enter Length: ");
            var length = double.Parse(Console.ReadLine());

            Console.Write("Please enter Width: ");
            var width = double.Parse(Console.ReadLine());

            Console.Write("Please enter Height: ");
            var height = double.Parse(Console.ReadLine());

            var area = length * width;
            var perimeter = 2 * (length + width);
            var volumn = length * width * height;

            Console.WriteLine();
            Console.WriteLine("Classroom area = " + Math.Round(area, 3));
            Console.WriteLine("Classroom perimeter = " + Math.Round(perimeter, 3));
            Console.WriteLine("Classroom volumn = " + Math.Round(volumn, 3));

            if (area >= LARGE_MIN)
            {
                Console.WriteLine("This is a large size classroom.");
            }
            else if (area >= MEDIUM_MIN)
            {
                Console.WriteLine("This is a medium size classroom.");
            }
            else
            {
                Console.WriteLine("This is a small size classroom");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using the Room Detail Generator!");
        }
    }
}
