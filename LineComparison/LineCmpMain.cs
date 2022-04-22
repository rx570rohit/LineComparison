using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCmpMain
    {    private int x1, y1, x2, y2;

        public void SetLine() {
            x1 = 0; y1 = 0; x2 = 0;y2 = 0;
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public static void Main(String[] arg)
        {
         
            LineCmpMain L1 = new LineCmpMain();
            LineCmpMain L2 = new LineCmpMain();
            LineCal line_Cal = new LineCal(); 
            Console.WriteLine("set line 1");
            L1.SetLine();
            Double Length_L1 = line_Cal.linecal(L1.x1,L1.y1,L2.x2,L2.y2);
            Console.WriteLine("set line 2");
            L2.SetLine();
            Double Length_L2 = line_Cal.linecal(L1.x1,L1.y1,L2.x2,L2.y2);
            Console.WriteLine(Length_L1);
            Console.WriteLine();
            Console.WriteLine(Length_L2);   
            Boolean result = Length_L1.Equals(Length_L2);
            Console.WriteLine(result);
        }
    }
}
