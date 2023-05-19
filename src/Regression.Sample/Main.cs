using System;
using System.Drawing;
using System.Windows.Forms;

namespace Regression.Sample
{
    public partial class Main : Form
    {
        static readonly double[] XVector = new[] { 100d, 205, 305, 402, 500 };
        static readonly double[] YVector = new[] { 29.05, 27.41, 24.27, 21.73, 17.79 };

        public Main()
        {
            InitializeComponent();
        }


        void RunTest1(object sender, EventArgs e)
        {
            RunTest(txtTest1Actual, Test1);
        }

        

        void RunTest2(object sender, EventArgs e)
        {
            RunTest(txtTest2Actual, Test2);
        }

        (bool, string) Test1()
        {
            var poly = new Polynomial(XVector, YVector, Convert.ToInt32(txtTest1Order.Text));
            var passed = txtTest1Expected.Text == poly.Equation;
            return (passed, poly.Equation);
        }

        (bool, string) Test2()
        {
            var poly = new Polynomial(XVector, YVector, Convert.ToInt32(txtTest2Order.Text));
            var result = poly.Fit(205);
            var passed = txtTest2Expected.Text == result.ToString();
            return (passed, result.ToString());
        }

        void RunTest(TextBox txtResult, Func<(bool, string)> test)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                grpTest1.Enabled = false;
                var (passed, actual) = test();
                var result = passed ? "PASSED" : "FAILED";
                txtResult.Text = result + Environment.NewLine + actual;
                txtResult.ForeColor = passed ? Color.Green : Color.Red;
            }
            finally
            {
                grpTest1.Enabled = true;
                Cursor = Cursors.Default;
            }
        }
    }
}
