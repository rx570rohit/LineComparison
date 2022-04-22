using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCmpMain
    {
        public static void Main(String[] arg)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            LineCal Line1 = new LineCal(x1, y1, x2, y2);
            Console.WriteLine();

            Console.WriteLine("Length of Line1: "+Line1.linecal());
        }
    }
}
