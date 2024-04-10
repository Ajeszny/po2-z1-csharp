using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO2_1
{
    struct Point
    {
        public double x;
        public double y;
    }

    internal class ImaginaryRootsException : Exception
    {

    }
    internal class Program
    {
        static Point Solve(double a, double b, double c)
        {
            Point p = new Point();
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                throw new ImaginaryRootsException();
            }
            p.x = (Math.Sqrt(delta) - b) / 2*a;
            p.y = (- Math.Sqrt(delta) - b) / 2 * a;
            return p;
        }
        static void Main(string[] args)
        {
            double a, b, c;
            a = Convert.ToDouble(args[0]);
            b = Convert.ToDouble(args[1]);
            c = Convert.ToDouble(args[2]);
            Point p = new Point();
            try
            {
                p = Solve(a, b, c);
            } catch (ImaginaryRootsException e)
            {
                Console.WriteLine("Imaginary roots caught!");
            }
            Console.WriteLine(p.x + " " + p.y);
            
        }
    }
}
