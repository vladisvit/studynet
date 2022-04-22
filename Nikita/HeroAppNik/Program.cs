using System;
public interface Idoublepoint
{
    int XYdoublepoint
    {
        get;
        set;
    }
}
public interface IPoint
{
    // Property signatures:
    int X
    {
        get;
        set;
    }

    int Y
    {
        get;
        set;
    }

    double Distance
    {
        get;
    }
}

class Point : IPoint, Idoublepoint
{
    // Constructor:
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Point(int x, int y, int xy)
    {
        X = x;
        Y = y;
        XYdoublepoint = xy;
    }

    // Property implementation:
    public int X { get; set; }

    public int Y { get; set; }

    // Property implementation
    public double Distance =>
       Math.Sqrt(X * X + Y * Y);

    public int XYdoublepoint { get; set; }
}
interface IPropertiesHero
{
    public int HP { get; set; }
    public int Height { get; set; }
    public int MovePosition { get; set; }
}
interface IMovingHero
{
    public int Velocity { get; set; }
    int UpSpeed();
    int DownSpeed();
}
class HeroClass : IPropertiesHero, IMovingHero
{
    public HeroClass(int hp, int height, int moveposition)
    {
        HP = hp;
        Height = height;
        MovePosition = moveposition;
    }
    public int HP { get; set; }
    public int Height { get; set; }
    public int Velocity { get; set; }
    public int MovePosition { get; set; }

    public int DownSpeed()
    {
        return --Velocity;
    }

    public int UpSpeed()
    {
        return ++Velocity;
    }
    public int MoveRight()
    {
        return ++MovePosition;
    }
    public int MoveLeft()
    {
        return --MovePosition;
    }
}
class MainClass
{
    static void PrintPoint(Point p)
    {
        Console.WriteLine("x={0}, y={1}, xy={2}", p.X, p.Y, p.XYdoublepoint);
    }

    static void Main()
    {
        var hero = new HeroClass(100, 150, 0); // third counter - initial position horizontally
        Console.Write($"Velocity = {hero.Velocity}; H-Position = {hero.MovePosition}");
        Console.Write("\r");
        var keyInfo = Console.ReadKey();
        while (keyInfo.Key != ConsoleKey.Escape)
        {
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {     
                case ConsoleKey.UpArrow:
                    hero.UpSpeed();
                    break;
                case ConsoleKey.DownArrow:
                    hero.DownSpeed();
                    break;
                case ConsoleKey.RightArrow:
                    hero.MoveRight();
                    break;
                case ConsoleKey.LeftArrow:
                    hero.MoveLeft();
                    break;
                default:
                    break;
            }
            Console.Write($"Velocity = {hero.Velocity}; H-Position = {hero.MovePosition}");
            Console.Write("\r");
        }
        //IPoint p = new Point(2, 3);
        //Idoublepoint pp = new Point(3, 4);
        //Point ppp = new Point(2, 6, 6);
        //pp.XYdoublepoint = 10;
        //Console.Write("My Point: ");
        //PrintPoint(ppp);
    }
}
// Output: My Point: x=2, y=3
