using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome Message
            Console.WriteLine("\nWelcome To Radius!");
            Console.WriteLine();


            // Declare Variables
            bool loop = true;
            List<CircleClass> CircleList = new List<CircleClass>();

            while (loop)
            //Request information
            {
                Console.Write("Enter the radius, here: ");
                CircleList.Add(new CircleClass(GetValidDouble()));
                Console.WriteLine($"Circumference; {CircleList.Last().GetFormatedCircumference1()}");
                Console.WriteLine($"Area: {CircleList.Last().GetFormattedArea()}");

            }

            public static double GetValidDouble()
            {
                double input;
                while (!double.TryParse(Console.ReadLine()), out input))
                {
                    Console.WriteLine("This is not a valid number. Try again, now: ");

                }
                return input;
           }

                        
          
        }
    }
}

