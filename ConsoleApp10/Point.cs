namespace ConsoleApp10
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"X: {X}, Y: {Y}";
        }

        //Comparisson operator overload > < == !=

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X && p1.Y > p2.Y;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X && p1.Y < p2.Y;
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X && p1.Y != p2.Y;
        }

        //casting overload
        public static bool operator true(Point p)
        {
            return p.X > 0 && p.Y > 0;
        }

        public static bool operator false(Point p)
        {
            return p.X <= 0 && p.Y <= 0;
        }

        //assigment overload
        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        //arithmetic overload
        public static Point operator +(Point p1, Point p2)
        {
            var newPoint = new Point
            {
                X = p1.X + p2.X,
                Y = p1.Y + p2.Y
            };
            return newPoint;
        }

        public static Point operator /(Point p1, Point p2)
        {
            if (p2.X == 0 || p2.Y == 0)
            {
                throw new DivideByZeroException();
            }
            var newPoint = new Point
            {
                X = p1.X / p2.X,
                Y = p1.Y / p2.Y
            };
            return newPoint;
        }

    }
}
