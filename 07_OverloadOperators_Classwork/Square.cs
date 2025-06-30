namespace _07_OverloadOperators_Classwork
{
    public class Square
    {
        public int A { get; set; }

        public Square()
        {
            A = 1;
        }
        public Square(int a)
        {
            A = a > 0 ? a : 1;
        }
        public override string ToString()
        {
            return "Square: A = " + A;
        }
        public static Square operator ++(Square s)
        {
            return new Square(s.A + 1);
        }
        public static Square operator --(Square s)
        {
            return new Square(s.A > 0 ? s.A - 1 : 0);
        }
        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.A + s2.A);
        }
        public static Square operator -(Square s1, Square s2)
        {
            return new Square(Math.Max(s1.A - s2.A, 0));
        }
        public static Square operator *(Square s1, Square s2)
        {
            return new Square(s1.A * s2.A);
        }
        public static Square operator /(Square s1, Square s2)
        {
            return new Square(s2.A != 0 ? s1.A / s2.A : 0);
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A >= s2.A;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            return s1.A == s2.A;
        }

        public static bool operator !=(Square s1, Square s2)
        {
            return s1.A != s2.A;
        }

        public override bool Equals(object obj)
        {
            if (obj is Square)
            {
                Square s = (Square)obj;
                return A == s.A;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return A.GetHashCode();
        }

        public static bool operator true(Square s)
        {
            return s.A != 0;
        }

        public static bool operator false(Square s)
        {
            return s.A == 0;
        }

        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }

        public static implicit operator int(Square s)
        {
            return s.A;
        }


    }
}
