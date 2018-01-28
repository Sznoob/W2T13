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
            int[] credits = new int[6];
            int number;
            bool result;


            Console.WriteLine("Give credits between 0 to 5. ");
            do
            {
                Console.WriteLine("Give credit: ");
                string line = Console.ReadLine();
                result = Int32.TryParse(line, out number);

                switch (number)
                {
                case 0: credits[0]++; break;
                case 1: credits[1]++; break;
                case 2: credits[2]++; break;
                case 3: credits[3]++; break;
                case 4: credits[4]++; break;
                case 5: credits[5]++; break;
                }

            } while (result);

            Console.WriteLine("Credits: ");
            for (int i = 0; i < credits.Length; i++)
            {
                Console.Write(i + " : ");
                for (int k = 0; k < credits[i]; k++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
