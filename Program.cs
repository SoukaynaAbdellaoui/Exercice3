using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    public class Point
    {
        private int x, y;
        //definir le setter de x
        public void setx(int x)
        {
            this.x = x;
        }
        //definir le getter de x
        public int getx()
        {
            return x;
        }
        //definir le setter de x
        public void sety(int y)
        {
            this.y = y;
        }
        //deffinir le getter de y
        public int gety()
        {
            return y;
        }
        public Point()
        {
        }
        //definition du constructeur 
        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }


        public static double Distance(double x1, double y1, double x2, double y2)
            => Math.Sqrt(Math.Sqrt(y2 - y1) + Math.Sqrt(x2 - x1));

        public override bool Equals(object obj)
        {
            return Equals(obj as Point);
        }

        public bool Equals(Point other)
        {
            return !(other is null) &&
                   x == other.x &&
                   y == other.y;
        }

        public static bool operator ==(Point left, Point right)
        {
            return EqualityComparer<Point>.Default.Equals(left, right);
        }

        public static bool operator !=(Point left, Point right)
        {
            return !(left == right);
        }
        public int GetX()
        {
            return x;
        }

        public void Translate(Point p, int pasx, int pasy, int nb)
        {
            p.x = p.x + pasx;
            p.y = p.y + pasy;

        }
  
    }
     static void Main(string[] args)
    {
        Point P = new Point();
        Action<string> msgr = s => Console.WriteLine(s);
        Action<string> msg = s => Console.Write(s);
        //-------------------------------------------------
        Console.WriteLine("Calcul de la distance d'un point dans le plan :");
        Console.WriteLine("Entrez l'abscisse (x) du point: "); P.setx(int.Parse(Console.ReadLine()));
        Console.WriteLine("Entrez l'ordonnée (y) du point: "); P.sety(int.Parse(Console.ReadLine()));
        Console.WriteLine("La distance du point est: " + P.Distance());

        Console.ReadKey();
    }
}

   


