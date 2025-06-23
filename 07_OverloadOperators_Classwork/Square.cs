namespace _07_OverloadOperators_Classwork
{
    internal class Square
    {
        public int A    { get; set; }   

        public Square() 
        {
            A = 1;
        } 
        public Square(int a )
        {
            A = a > 0 ? a : 1;
        }
        public override string ToString() 
        {
            return $"Square: A= {A}";
        }

        public static Square operator ++(Square s)
        {  
            return new Square (s.A+1); 
        }

        public static Square operator --(Square s)
        {
            return new Square(s.A-1);
        }
        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.A+s2.A);
        }

        public  static Square operator -(Square s1, Square s2)
        {
            return new Square(Math.Max(s1.A -s2.A,0));
        }
        public static Square operator *(Square s1, Square s2)
        {
            return new Square(s1.A * s2.A);
        }
        public static Square operator /(Square s1, Square s2) 
        {
            if(s2.A !=0)
                return new Square (s1.A / s2.A);
            return new Square(0);
        }

    }
}
