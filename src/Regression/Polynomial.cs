using System;
using System.Reflection;

namespace Regression
{
    public class Polynomial
    {
        object _coef;
        int _order;
        Assembly _assembly;
        Type _vectorType;
        Type _matrixType;

        public Polynomial(double[] xData, double[] yData, int order)
        {
            _assembly = Assembly.LoadFrom("MathNet.Iridium.dll"); 
            _vectorType = _assembly.GetType("MathNet.Numerics.LinearAlgebra.Vector");
            _matrixType = _assembly.GetType("MathNet.Numerics.LinearAlgebra.Matrix");

            _order = order;
            _coef = BuildRegression(xData, yData, order);
        }

        object BuildRegression(double[] xData, double[] yData, int order)
        {
            if (xData.Length != yData.Length)
            {
                throw new IndexOutOfRangeException();
            }

            var n = xData.Length;

            var matrixCtor = _matrixType.GetConstructor(new Type[] { typeof(int), typeof(int) });
            var a = matrixCtor.Invoke(new object[] { n, order + 1 });

            for (var i = 0; i < n; i++)
            {
                var x = xData[i];
                var row = new double[_order + 1];
                for (var i1 = 0; i1 <= _order; i1++)
                    row[i1] = Math.Pow(x, i1);

                var vectorCtor = _vectorType.GetConstructor(new Type[] { typeof(double[]) });
                var vandermondeRow = vectorCtor.Invoke(new object[] { row });

                var setRowVectorMethod = _matrixType.GetMethod("SetRowVector");
                setRowVectorMethod.Invoke(a, new object[] { vandermondeRow, i });
            }

            var transposeMethod = _matrixType.GetMethod("Transpose", new Type[] { _matrixType });
            var at = transposeMethod.Invoke(null, new object[] { a });

            var matrixCtor2 = _matrixType.GetConstructor(new Type[] { typeof(double[]), typeof(int) });
            var y2 = matrixCtor2.Invoke(new object[] { yData, n });

            var multiplyOperator = _matrixType.GetMethod("op_Multiply", new Type[] { _matrixType, _matrixType });
            var solveMethod = _matrixType.GetMethod("Solve");

            var result = solveMethod.Invoke(multiplyOperator.Invoke(null, new object[] { at, a }), new object[] { multiplyOperator.Invoke(null, new object[] { at, y2 }) });

            var getColumnVectorMethod = _matrixType.GetMethod("GetColumnVector");
            return getColumnVectorMethod.Invoke(result, new object[] { 0 });
        }

        public double Fit(double x)
        {
            var row = new double[_order + 1];
            for (var i = 0; i <= _order; i++)
                row[i] = Math.Pow(x, i);

            var vectorCtor = _vectorType.GetConstructor(new Type[] { typeof(double[]) });
            var rowVector = vectorCtor.Invoke(new object[] { row });

            var scalarProductMethod = _vectorType.GetMethod("ScalarProduct");
            return (double)scalarProductMethod.Invoke(null, new object[] { rowVector, _coef });
        }
        public string Equation
        {
            get
            {
                var equation = "";
                var lengthProperty = _vectorType.GetProperty("Length");
                var indexerProperty = _vectorType.GetProperty("Item");

                for (var i = (int)lengthProperty.GetValue(_coef) - 1; i >= 0; i--)
                {
                    var part = string.Format("{0}{1}", indexerProperty.GetValue(_coef, new object[] { i }), GetPowerSymbol(i - 1));
                    equation += equation.Length == 0 ? string.Format("y = {0}", part) : string.Format(" + {0}", part);
                }
                return equation;
            }
        }

        static string GetPowerSymbol(int i)
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
