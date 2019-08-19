namespace epam_task_2_2
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
   
    public abstract class Figure
    {
        public int X { get; }

        public int Y { get; }

        public Figure(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public abstract void Draw();
    }
    public class Rectangle: Figure
    {
        public Rectangle(int x, int y)
         : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }
    }
    public class Square : Figure
    {
        public Square(int x, int y)
         : base(x, y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this.GetType());
        }
    }


}