
using System;

class Point
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
    //definition du constructeur 
    public Point(int x = 0, int y = 0)
    {
        this.x = x;
        this.y = y;
    }

    static public double Distance(double x1, double y1, double x2, double y2)
        => Math.Sqrt(Sqrt(y2 - y1) + Sqrt(x2 - x1));

    private static int Sqrt(double v)
    {
        throw new NotImplementedException();
    }

}

class Program
{
    static void Main(string[] args)
    {
        Point P = new Point();
        Action<string> msgr = s => Console.WriteLine(s);
        Action<string> msg = s => Console.Write(s);
        //-------------------------------------------------
       Console.WriteLine("Calcul de la norme d'un point dans le plan :");
        Console.WriteLine("Entrez l'abscisse (x) du point: "); P.setx(int.Parse(Console.ReadLine()));
        Console.WriteLine("Entrez l'ordonnée (y) du point: "); P.sety(int.Parse(Console.ReadLine()));
        Console.WriteLine("La distance du point est: " + P.Distance());

        Console.ReadKey();
    }
}
