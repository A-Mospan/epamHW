namespace epam_task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Circle
    {
        private const double PI  = 3.14;

        public double Circle_Length(double radius)
        {
            return 2 * PI * radius;
        }

        public double Circle_Area(double radius)
        {
            return PI * radius * radius;
        }

    }
}