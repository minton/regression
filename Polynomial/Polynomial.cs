using System;
using MathNet.Numerics.LinearAlgebra;

namespace Regression
{
    public class Polynomial
    {
        readonly Vector _coef;
        readonly int _order;
        public Polynomial(double[] xData, double[] yData, int order)
        {
            _order = order;
            _coef = BuildRegression(xData, yData, order);
        }
        private Vector BuildRegression(Vector xData, Vector yData, int order)
        {
            if (xData.Length != yData.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var n = xData.Length;
            var a = new Matrix(n, order + 1);
            for (var i = 0; i < n; i++)
                a.SetRowVector(VandermondeRow(xData[i]), i);

            // Least Squares |y=A(x)*c| ...  tr(A)*y = tr(A)*A*c  ...  inv(tr(A)*A)*tr(A)*y = c
            // http://en.wikipedia.org/wiki/Total_least_squares
            // http://en.wikipedia.org/wiki/Curve_fitting
            var at = Matrix.Transpose(a);
            var y2 = new Matrix(yData, n);
            return (at * a).Solve(at * y2).GetColumnVector(0);
        }

        private Vector VandermondeRow(double x)
        {
            var row = new double[_order + 1];
            for (var i = 0; i <= _order; i++)
                row[i] = Math.Pow(x, i);
            return new Vector(row);
        }

        public double Fit(double x)
        {
            return Vector.ScalarProduct(VandermondeRow(x), _coef);
        }
        public string Equation
        {
            get
            {
                var equation = "";
                for (var i = _coef.Length - 1; i >= 0; i--)
                {
                    var part = string.Format("{0}{1}", _coef[i], GetPowerSymbol(i - 1));
                    equation += equation.Length == 0 ? string.Format("y = {0}", part) : string.Format(" + {0}", part);
                }
                return equation;
            }
        }
        private static string GetPowerSymbol(int i)
        {
            if (i < 0) return string.Empty;

            switch (i)
            {
                case 0:
                    return "x";
                case 1:
                    return "x²";
                case 2:
                    return "x³";
                default:
                    return string.Format("x^{0}", i + 1);
            }
        }
    }
}
