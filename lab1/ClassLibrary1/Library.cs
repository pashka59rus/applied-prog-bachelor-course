using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Line
    {
        internal double k, b;
        public Line(double k,double b)
        {
            this.k = k;
            this.b = b;
        }
    }

    public class Point
    {
        double x, y;
       public Point(double  x, double  y )
        { 
            this.x = x;
            this.y = y;
        }
        public static  void  print (Point c)
        {
            if (c!=null)
            {
                Console.WriteLine("{0} {1}", c.x, c.y);
            }

        }

    }

    public class Operation
    {
        
        public static Point intersection(Line a,Line b)
        {
            double y, x;
            if ((a.b == b.b) && (b.k == a.k))
            {
                Console.WriteLine("Прямые наложены друг на друга.");
                Console.WriteLine("Бесконечное множество точек пересечений.");
                return null;
            }
            if (a.k != b.k)
            {
                x = (b.b - a.b) / (a.k - b.k);
                y = (a.k * x + a.b);
                var c = new Point(x, y);
                return c;
            }
            else
            {
                Console.WriteLine("Прямые параллельны. Точек пересечения нет!");
                return null;
            }

        }
    }
}
