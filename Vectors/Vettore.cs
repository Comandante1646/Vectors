using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    internal class Vettore
    {
        public double X { get; }
        public double Y { get; }

        public Vettore(double x, double y)
        {
            X = x; Y = y;
        }



        public override string ToString()
        {
            return string.Format("{0};{1}", X, Y);
        }



        public static Vettore Parse(string s)
        {
            string[] parte = s.Split(';');
            return new Vettore(double.Parse(parte[0]), double.Parse(parte[1]));
        }

        public static bool TryParse(string s, out Vettore v)
        {
            double x; double y;
            string[] parte = s.Split(';');
            if (parte.Length > 1 && double.TryParse(parte[0], out x) && double.TryParse(parte[1], out y))
            {
                v = new Vettore(x, y);
                return true;
            }
            else
            {
                v = null;
                return false;
            }
        }



        public static double Modulo(Vettore v)
        {
            return Math.Sqrt(v.X * v.X + v.Y * v.Y);
        }



        public static Vettore operator +(Vettore v)
        {
            return v;
        }



        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.X, -v.Y);
        }



        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X + v2.X, v1.Y + v2.Y);
        }



        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X - v2.X, v1.Y - v2.Y);
        }



        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }


        public static Vettore operator *(Vettore v1, double s)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }

        public static Vettore operator *(double s, Vettore v2)
        {
            return new Vettore(s * v2.X, s * v2.Y);
        }


        public static Vettore operator /(Vettore v1, double s)
        {
            return new Vettore(v1.X / s, v1.Y / s);
        }

        public static bool operator ==(Vettore v1, Vettore v2)
        {
            if (ReferenceEquals(v1, null))
            {
                return ReferenceEquals(v2, null);
            }
            else if (ReferenceEquals(v2, null))
            {
                return false;
            }
            else
            {
                return v1.X == v2.X && v1.Y == v2.Y;
            }
        }

        public static bool operator !=(Vettore v1, Vettore v2)
        {
            return !(v1 == v2);
        }
    }
}

