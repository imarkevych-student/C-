using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OverloadOperators_Classwork
{
    public class Rectangle
    {
        public int A { get; set; }
        public int B { get; set; }

        public Rectangle()
        {
            A = 1;
            B = 1;
        }
        public Rectangle(int a, int b)
        {
            A = a > 0 ? a : 1;
            B = b > 0 ? b : 1;
        }
        public override string ToString()
        {
            return "Rectangle: A = " + A + ", B = " + B + ")";
        }
        public static Rectangle operator ++(Rectangle r)
        {
            return new Rectangle(r.A + 1, r.B + 1);
        }
        public static Rectangle operator --(Rectangle r)
        {
            int newA = r.A > 0 ? r.A - 1 : 0;
            int newB = r.B > 0 ? r.B - 1 : 0;
            return new Rectangle(newA, newB);
        }
        public static Rectangle operator +(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.A + r2.A, r1.B + r2.B);
        }
        public static Rectangle operator -(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(
                Math.Max(r1.A - r2.A, 0),
                Math.Max(r1.B - r2.B, 0)
            );
        }
        public static Rectangle operator *(Rectangle r1, Rectangle r2)
        {
            return new Rectangle(r1.A * r2.A, r1.B * r2.B);
        }
        public static Rectangle operator /(Rectangle r1, Rectangle r2)
        {
            int newA = r2.A != 0 ? r1.A / r2.A : 0;
            int newB = r2.B != 0 ? r2.B / r2.B : 0;
            return new Rectangle(newA, newB);
        }

        public static bool operator <(Rectangle r1, Rectangle r2)
        {
            return r1.A * r1.B < r2.A * r2.B;
        }
        public static bool operator >(Rectangle r1, Rectangle r2)
        {
            return r1.A * r1.B > r2.A * r2.B;
        }
        public static bool operator <=(Rectangle r1, Rectangle r2)
        {
            return r1.A * r1.B <= r2.A * r2.B;
        }
        public static bool operator >=(Rectangle r1, Rectangle r2)
        {
            return r1.A * r1.B >= r2.A * r2.B;
        }
        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            return r1.A == r2.A && r1.B == r2.B;
        }
        public static bool operator !=(Rectangle r1, Rectangle r2)
        {

            return !(r1 == r2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Rectangle)
            {
                Rectangle r = (Rectangle)obj;
                return A==r.A && B==r.B;
            }
            return false;            
        }
         public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode();
        }

        public static bool operator true(Rectangle r)
        {
            return r.A != 0 && r.B != 0;
        }
        public static bool operator false(Rectangle r)
        { 
            return r.A==0 || r.B==0;
        }
        public static explicit operator Square(Rectangle r)
        {
            int side = Math.Min(r.A,r.B);
            return new Square(side);

        }
        public static explicit operator int(Rectangle r)
        {
            return r.A*r.B;
        }
    }
}