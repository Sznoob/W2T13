using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] points = new int[5];
            for (int i = 0; i < points.Length; i++)
            {
                Console.Write(" Give points {0}: ", i+1);
                string line = Console.ReadLine();
                int point;
                bool result = Int32.TryParse(line, out point);
                if (result)
                {
                    points[i] = point;
                }
                 else
                    Console.WriteLine("You didn't give a number! ");
            }
            Array.Sort(points);

            int sum = points[1] + points[2] + points[3];
            Console.WriteLine("Sum is: " + sum) ;

            Console.ReadLine();
        }
    }
}
