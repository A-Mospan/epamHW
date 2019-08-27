using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epam_task_3_3
{

    class Program
    {
        public static List<string> myStr = new List<string>(150);
        static void Main(string[] args)
        {

            for (int i = 0; i < myStr.Capacity; i++)
            {
                myStr.Add(Path.GetRandomFileName().Substring(0, 4).ToUpper());
            }
            Console.WriteLine($"Generated strings: {myStr.Count}");
            myStr.RemoveAll(p => p[0] == 'Z');
            myStr.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine($"After removing Z-strings: {myStr.Count}");
            Console.WriteLine($"Enter page number of strings list: (from 1 to {Math.Ceiling(myStr.Count / 5.0)} )");
            int pageNumber = 0;
            try
            {
                pageNumber = Convert.ToInt32(Console.ReadLine());
                if (pageNumber > Math.Ceiling(myStr.Count / 5.0) || pageNumber < 0)
                    Console.WriteLine("Error. Page doesn't exist");
                else
                    DisplayPage(pageNumber - 1);
            }
            catch (Exception)
            {
                Console.WriteLine("Error. You do not enter number.");
            }
            Console.ReadLine();

        }
        public static void DisplayPage(int pageNumber)
        {
            for (int i = pageNumber * 5; i < pageNumber * 5 + 5; i++)
            {
                try
                {
                    Console.WriteLine(myStr[i]);
                }
                catch (Exception)
                {
                    break;
                }
            }
        }
    }
}