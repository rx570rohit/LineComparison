using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineCal
    {
        int x1, x2, y1, y2;

        Double line;
        public LineCal(int x1, int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public Double linecal()
        {
            return Math.Sqrt(Math.Pow((this.x2 - this.x1), 2));
        }

    }
}
