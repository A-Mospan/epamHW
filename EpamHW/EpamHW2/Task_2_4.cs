using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_2_4
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IDrawable
    {
        void Draw();

        void DrawAll(params IDrawable[] array);
    }
    public abstract class Figure : IDrawable
    {
        public int X { get; }

        public int Y { get; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }
        public abstract void Draw();

        public abstract void DrawAll(params IDrawable[] array);
    }
    public class Rectangle : Figure, IDrawable
    {
        public Rectangle(int x, int y)
         : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine(this.GetType());
        }
        public override void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
    public class Square : Figure, IDrawable
    {
        public Square(int x, int y)
         : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine(this.GetType());
        }

        public override void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }


}
