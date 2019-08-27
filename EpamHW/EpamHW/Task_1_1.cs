using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_1_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Rectangle
    {
        public double LengthA { get; set; } = 0;

        public double LengthB { get; set; } = 0;

        public Rectangle(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
        {
            this.LengthA = topLeftX - bottomRightX;
            if (LengthA < 0)
            {
                LengthA = LengthA * (-1);
            }

            LengthB = topLeftY - bottomRightY;
            if (LengthB < 0)
            {
                LengthB = LengthB * (-1);
            }
        }

        public double Perimeter()
        {
            return 2 * (LengthA + LengthB);
        }

        public double Square()
        {
            return LengthA * LengthB;
        }
    }
}
