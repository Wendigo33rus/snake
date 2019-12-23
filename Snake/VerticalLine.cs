using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<point> pList;

        public VerticalLine(int yLeft, int yRight, int x, char sym)
        {

            pList = new List<point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                point p = new point(x, y, sym);
                pList.Add(p);

            }

        }

        public void Draw()
        {

            foreach (point p in pList)
            {
                p.Draw();
            }
        }
    }
}
