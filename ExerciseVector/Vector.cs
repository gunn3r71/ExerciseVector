namespace ExerciseVector
{
    public struct Vector
    {
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public static Vector operator +(Vector a, Vector b) => new(a.X + b.X, a.Y + b.Y);

        public static Vector operator *(Vector a, int m) => new(a.X * m, a.Y * m);
    }
}
