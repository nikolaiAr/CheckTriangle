using System;

namespace LibCheckTriangle
{
    public static class Triangle
    {
        public enum TypeTriangle { NotTriangle, Rectangle, AcuteTriangle, ObsuteTriangle }

        public static Enum CheckType(double sideA, double sideB, double sideC)
        {
            TypeTriangle triangle = TypeTriangle.NotTriangle;
            double[] arSide = CheckTriangle(sideA, sideB, sideC);
            if (0 != arSide[0])
            {
                double temp = Math.Pow(arSide[0], 2) + Math.Pow(arSide[1], 2) - Math.Pow(arSide[2], 2);
                switch (Math.Sign(temp))
                {
                    case 0:
                        triangle = TypeTriangle.Rectangle;
                        break;
                    case 1:
                        triangle = TypeTriangle.AcuteTriangle;
                        break;
                    case -1:
                        triangle = TypeTriangle.ObsuteTriangle;
                        break;
                }
            }
            return triangle;
        }

        static double[] CheckTriangle(double a, double b, double c)
        {
            Func<double, double, double, bool> check = (a1, a2, a3) => a1 + a2 > a3;
            double[] sideTr;
            if (check(a, b, c) & check(a, c, b) & check(b, c, a))
            {
                sideTr = new double[] { a, b, c };
                Array.Sort(sideTr);
            }
            else
            {
                sideTr = new double[1];
            }
            return sideTr;
        }
    }
}
