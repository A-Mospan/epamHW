using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public static class Circle
    {
        private const double PI = 3.14;

        public static double Circle_Length(double radius)
        {
            return 2 * PI * radius;
        }

        public static double Circle_Area(double radius)
        {
            return PI * radius * radius;
        }

    }
}