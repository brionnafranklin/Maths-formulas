using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths_formulas
{
    class Program
    {
        

        static void Main(string[] args)
        {
            functionA(7);
            functionB(2, 5, -3);
            functionC(5, 6, 7);
            functionD();
            functionE();
            functionF();
            functionG(1, 2, 3, 4, 5);

            Console.ReadLine();

        }

        static float functionA(float x)
        {
            //f(x) = x^2 + 2x - 7
            float y = x * x + 2 * x - 7;
            Console.WriteLine("f(x) = x ^ 2 + 2x - 7");
            Console.WriteLine("answer: " + y);
            return y;
        }

        static float functionB(float a, float b, float c)
        {
            //f(a,b,c) = (-b +- square root(b^2 -4ac))/2a
            float part1 = Convert.ToSingle(Math.Pow(b, 2));
            float part2 = 4 * (a * c);
            float part3 = Convert.ToSingle(Math.Sqrt(part1 - part2));
            float part4 = (b * -1);
            float part5 = part4 + part3;
            float part6 = part4 - part3;
            float y = part5 / (2 * a);
            float y2 = part6 / (2 * a);

            Console.WriteLine("f(a,b,c) = (-b +- square root(b^2 -4ac))/2a");
            Console.WriteLine("answer: " + y + " or " + y2);

            return y;
        }

        static float functionC(float s, float e, float t)
        {
            //𝐿(𝑠, 𝑒,𝑡) = 𝑠 + 𝑡(𝑒 − 𝑠)
            float y = s + (t * (e - s));
            Console.WriteLine("L(s, e, t) = s + t(e − s)");
            Console.WriteLine("answer: " + y);
            return y;
        }

        static float functionD()
        {
            //𝐷(𝑃1, 𝑃2) = squareroot((x2 - x1)^2 + (y2 - y1)^2)
            Point P1 = new Point(1, 2);
            Point P2 = new Point(3, 4);

            float part1 = P2.getX() - P1.getX();
            float part2 = P2.getY() - P1.getY();
            float part3 = Convert.ToSingle(Math.Pow(part1, 2));
            float part4 = Convert.ToSingle(Math.Pow(part2, 2));
            float part5 = part3 + part4;
            float y = Convert.ToSingle(Math.Sqrt(part5));
            Console.WriteLine("D(P1, P2) = squareroot((x2 - x1)^2 + (y2 - y1)^2)");
            Console.WriteLine("answer: " + y);
            return y;
        }

        static float functionE()
        {
            //Inner(P,Q) = Px*Qx + Py*Qx + Pz*Qz
            _3DPoint P = new _3DPoint(1, 2, 3);
            _3DPoint Q = new _3DPoint(4, 5, 6);

            float part1 = P.getX() * Q.getX();
            float part2 = P.getY() * Q.getY();
            float part3 = P.getZ() * Q.getZ();
            float y = part1 + part2 + part3;
            Console.WriteLine("Inner(P,Q) = Px*Qx + Py*Qx + Pz*Qz");
            Console.WriteLine("answer: " + y);
            return y;
        }

        static float functionF()
        {
            //D(P, X0) = (a*x0 + b*y0 + c*z0 + d) / squareroot(a^2 + b^2 + c^2)
            _3DPoint X0 = new _3DPoint(1, 2, 3);
            Plane P = new Plane(4, 5, 6, 7);

            float part1 =  P.getA() * X0.getX();
            float part2 = P.getB() * X0.getY();
            float part3 = P.getC() * X0.getZ();
            float part4 = part1 + part2 + part3 + P.getD();
            float part5 = Convert.ToSingle(Math.Pow(P.getA(), 2));
            float part6 = Convert.ToSingle(Math.Pow(P.getB(), 2));
            float part7 = Convert.ToSingle(Math.Pow(P.getC(), 2));
            float part8 = part5 + part6 + part7;
            float part9 = Convert.ToSingle(Math.Sqrt(part8));
            float y = part4 / part9;
            Console.WriteLine("D(P, X0) = (a*x0 + b*y0 + c*z0 + d) / squareroot(a^2 + b^2 + c^2)");
            Console.WriteLine("answer: " + y);
            return y;
        }
        static float functionG(float t, float P0, float P1, float P2, float P3)
        {
            //B(t, P0, P1, P2, P3) = (1 - t)^3 * P0 + 3*(1 -t) * t^2 * P2 + t^3 * P3
            float part1 = Convert.ToSingle(Math.Pow(1 - t, 3));
            float part2 = part1 * P0;
            float part3 = Convert.ToSingle(Math.Pow(1 - t, 2));
            float part4 = part3 * 3 * t * P1;
            float part5 = Convert.ToSingle(Math.Pow(1 - t, 2)) * 3 * t * P2 ;
            float part6 = Convert.ToSingle(Math.Pow(t, 3)) * P3;
            float y = part2 + part4 + part5 + part6;
            Console.WriteLine("B(t, P0, P1, P2, P3) = (1 - t)^3 * P0 + 3*(1 -t) * t^2 * P2 + t^3 * P3");
            Console.WriteLine("answer: " + y);
            return y;
        }
    }
}


