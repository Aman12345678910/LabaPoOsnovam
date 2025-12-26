using System;

namespace LabaChestyaya
{
    public static class GuessGame
    {
        public static double CalculateFunction(double a, double b)
        {
            double d = Math.Log(b, 5);
            double c = Math.Sqrt(Math.Cos(a));
            return Math.Pow(Math.Sin(d / c), 2);
        }
    }
}