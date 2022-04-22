using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 1000.0;
            double theta = 45.0;
            Console.WriteLine("r={0:E};theta={1:F}", r, theta);
            theta = theta * Math.PI / 180;
            double x = r * Math.Sin(theta);
            double y = r * Math.Cos(theta);
            Console.WriteLine("x={0:0.000};y={1:0.000}", x, y);
            Console.ReadKey();
        }
    }
}
