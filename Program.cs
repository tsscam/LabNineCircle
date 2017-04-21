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
            string str = new string('*', 20);
            CircleClass Circle1 = new CircleClass();
            Circle1.Radius1 = 0;
            Circle1.Circumference1 = 0;
            Circle1.Area1 = 0;
            Circle1.FormatedCircumference1 = 0;
            Circle1.FormattedNumber1 = 0;
            Circle1.FormattedArea1 = 0;

            //Math functions
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            //double area = 2 * pi * Radius1;

            //Request from User

            Console.Write("Enter the radius");
            Circle1.Radius1 = int.Parse(Console.ReadLine());

            // Contin
            //while (true)
            //{
            //    Console.WriteLine("\nEnter the RADIUS: ");

            //}
        }
    }
}

