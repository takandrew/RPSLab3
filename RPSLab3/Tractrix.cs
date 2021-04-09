using System;

namespace RPSLab3
{
    public static class Tractrix
    {
        public static double TractrixBuild(double y, double aCoefficient) //Расчет координат X
        {
            return (aCoefficient * Math.Log((aCoefficient + Math.Sqrt(
                Math.Pow(aCoefficient, 2) - Math.Pow(y, 2))) / y) -
                Math.Sqrt(Math.Pow(aCoefficient, 2) - Math.Pow(y, 2)));
        }
    }
}
