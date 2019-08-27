using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_2_1
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Figure
    {
        public abstract void Draw();
    }
    public class Rectangle : Figure
    {
        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }
    public class Square : Figure
    {
        public override void Draw()
        {
            System.Console.WriteLine(this);
        }
    }


}