using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_2_3
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
        public virtual void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
    public class Rectangle : Figure
    {
        public Rectangle(int X, int Y)
         : base(X, Y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
    public class Square : Figure
    {
        public Square(int X, int Y)
         : base(X, Y) { }

        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }


}
