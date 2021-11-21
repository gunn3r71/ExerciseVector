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

        public int this[char coordenada] 
        {
            get
            {
                return coordenada switch
                {
                    'X' => X,
                    'Y' => Y,
                    _ => -1,
                };
            }
            set
            {
                switch (coordenada)
                {
                    case 'X':
                        X = value;
                        break;
                    case 'Y':
                        Y = value;
                        break;
                    default:
                        X = 0;
                        Y = 0;
                        break;
                }
            }
        }

        public static Vector operator +(Vector a, Vector b) => new(a.X + b.X, a.Y + b.Y);

        public static Vector operator *(Vector a, int m) => new(a.X * m, a.Y * m);

        public static implicit operator string(Vector a) => $"({a.X},{a.Y})";
    }
}
