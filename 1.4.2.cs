namespace epam_task_1_4_2
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public static class Rectangle
    {
        private static double lengthA = 0;

        private static double lengthB = 0;

        private static void Find_Sides(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
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

        public static double Perimeter(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
        {
            Find_Sides(topLeftX,topLeftY,bottomRightX,bottomRightY);
            return 2 * (lengthA + lengthB);
        }

        public static double Square(double topLeftX, double topLeftY, double bottomRightX, double bottomRightY)
        {
            Find_Sides(topLeftX,topLeftY,bottomRightX,bottomRightY);
            return lengthA * lengthB;
        }
    }
}