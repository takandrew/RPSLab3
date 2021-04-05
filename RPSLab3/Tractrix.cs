using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLab3
{
    static class Tractrix
    {
        public static double TractrixBuild(double y, double aCoefficient)
        {
            return (aCoefficient * Math.Log((aCoefficient + Math.Pow(
                (Math.Pow(aCoefficient, 2) - Math.Pow(y, 2)), 0.5)) / y) -
                Math.Pow((Math.Pow(aCoefficient, 2) - Math.Pow(y, 2)), 0.5));
        }
    }
}
