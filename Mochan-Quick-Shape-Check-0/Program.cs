using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mochan_Quick_Shape_Check_0
{
    class Program
    {
        static void Main()
        {
            //This is not meant to be proper. I just gotta make this real fast and use it once or twice.
            Console.WriteLine("Triangles clockwise. Small squares reading style. Finish row 1 before 2.");
            Console.WriteLine();

            var path = @"D:\Projects\Mochan_Projects\College\Pattern_Hell_0\Repeat.txt";

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            Console.WriteLine();
            Console.WriteLine("You have {0} elements in your text file. It should be 28.", lines.Length);
            Console.WriteLine();

            foreach (var number in lines.GroupBy(x => x))
            {
                Console.WriteLine(number.Key + " repeats " + (number.Count() - 1) + " times");
            }
            Console.ReadKey();
        }
    }
}
