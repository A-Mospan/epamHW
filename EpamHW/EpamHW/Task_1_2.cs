using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Rectangle
    {
        private double lengthA = 0;

        private double lengthB = 0;

        public double Perimetr => 2 * (lengthA + lengthB);

        public double Square => lengthA * lengthB;

        public Rectangle(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
        {
            lengthA = topLeftX - bottomRightX;
            if (lengthA < 0)
            {
                lengthA = lengthA * (-1);
            }

            lengthB = topLeftY - bottomRightY;
            if (lengthB < 0)
            {
                lengthB = lengthB * (-1);
            }
        }

    }
}