using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 130;
            double x2 = 135;
            double x3 = 140;
            double y1 = 99;
            double y2 = 100;
            double y3 = 99;
            double detA = -(x1 - x2) * (x2 - x3) * (x3 - x1);
            double detAa = y1 * x2 + y2 * x3 + y3 * x1 - x2 * y3 - x3 * y1 - x1 * y2;
            double detAb = (x1 * x1) * y2 + (x2 * x2) * y3 + (x3 * x3) * y1 - y1 * (x2 * x2) - y2 * (x3 * x3) - y3 * (x1 * x1);
            double detAc = (x1 * x1) * x2 * y3 + (x2 * x2) * x3 * y1 + (x3 * x3) * x1 * y2 - y1 * x2 * (x3 * x3) - y2 * x3 * (x1 * x1) - y3 * x1 * (x2 * x2);
            double a = detAa / detA;
            double b = detAb / detA;
            double c = detAc / detA;
            double p = -b / 2 / a;
        }
    }
}
