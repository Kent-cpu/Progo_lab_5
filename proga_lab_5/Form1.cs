using System;
using System.Collections.Generic;
using System.Threading;
using MathNet.Symbolics;
using System.Windows.Forms;
using ZedGraph;

namespace proga_lab_5
{
    public partial class Form1 : Form
    {
        double lBorder = 0, rBorder = 0, accuracy = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public double calculateValuePoint(double value)
        {
            double result = 0;
            var variables = new Dictionary<string, FloatingPoint> { { "x", value } };
            var formula = Infix.ParseOrThrow(function.Text);
            result = Evaluate.Evaluate(variables, formula).RealValue;
            return result;
        }

        public bool validation()
        {
            if (double.TryParse(leftBorder.Text, out lBorder) && double.TryParse(rightBorder.Text, out rBorder)
                        && double.TryParse(accuracyField.Text, out accuracy) && function.Text.Length > 0)
            {
                if (lBorder >= rBorder)
                {
                    MessageBox.Show("Значение a должно быть меньше значения b");
                    return false;
                }
                else if (accuracy <= 0)
                {
                    MessageBox.Show("Точность должна быть больше 0");
                    return false;
                }
                else if (rBorder - lBorder < accuracy)
                {
                    MessageBox.Show("Границы функции меньше точности, измените входные данные");
                    return false;
                }
                return true;
            }
            return false;
        }

        public void drawGraph(ZedGraphControl controlGraph)
        {

            new Thread(() =>
            {
                try
                {
                    GraphPane mypane = controlGraph.GraphPane;
                    PointPairList list = new PointPairList();
                    Invoke((Action)(() =>
                    {
                        mypane.CurveList.Clear();
                        mypane.XAxis.MajorGrid.IsVisible = true;
                        mypane.XAxis.MinorGrid.IsVisible = true;
                        mypane.YAxis.MajorGrid.IsVisible = true;
                    }));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неверная функция или слишком большие границы");
                }

            }).Start();
        }

        public int OptimalSplitsCentralRectangle()
        {
            double smallerSquare = 1;
            double largerSquare = 0;
            int splits = 2;

            while (Math.Abs(largerSquare - smallerSquare) > accuracy)
            {
                double splitStep = (rBorder - lBorder) / splits;
                double x1 = lBorder;
                double x2 = lBorder;
                double smallerSum = 0;
                double largerSum = 0;

                for (int counter = 0; counter < splits; ++counter)
                {
                    smallerSum += calculateValuePoint((2 * x1 + splitStep) / 2);
                    x1 += splitStep;
                }

                for (int counter = 0; counter < splits * 2; ++counter)
                {
                    largerSum += calculateValuePoint((2 * x2 + splitStep / 2) / 2);
                    x2 += splitStep / 2;
                }
                smallerSquare = splitStep * smallerSum;
                largerSquare = (splitStep / 2) * largerSum;
                splits *= 2;
            }
            centralRectangleAnswer.Text = splits.ToString();
            return splits;
        }

        public double CentralRectangle()
        {
            int n = OptimalSplitsCentralRectangle();
            var h = (rBorder - lBorder) / n;
            var sum = (calculateValuePoint(lBorder) + calculateValuePoint(rBorder)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = lBorder + h * i;
                sum += calculateValuePoint(x);
            }

            var result = h * sum;
            return result;
        }

        public int OptimalSplitsTrapezium()
        {
            double smallerSquare = 1;
            double largerSquare = 0;
            int splits = 2;

            while (Math.Abs(largerSquare - smallerSquare) > accuracy)
            {
                double splitStep = (rBorder - lBorder) / splits;
                double x1 = lBorder;
                double x2 = lBorder;
                double smallerSum = 0;
                double largerSum = 0;

                for (int counter = 1; counter < splits; ++counter)
                {
                    x1 += splitStep;
                    smallerSum += calculateValuePoint(x1);
                }

                for (int counter = 1; counter < splits * 2; ++counter)
                {
                    x2 += splitStep / 2;
                    largerSum += calculateValuePoint(x2);
                }

                smallerSquare = splitStep * ((calculateValuePoint(lBorder) + calculateValuePoint(rBorder)) / 2 + smallerSum);
                largerSquare = (splitStep / 2) * ((calculateValuePoint(lBorder) + calculateValuePoint(rBorder)) / 2 + largerSum);
                splits *= 2;
            }
            return splits;
        }


        public void Trapezium()
        {
            new Thread(() =>
            {
                int n = OptimalSplitsTrapezium();
                double x, h, s;
                h = (rBorder - lBorder) / n;
                s = (calculateValuePoint(lBorder) + calculateValuePoint(rBorder)) / 2;
                for (x = lBorder + h; x < rBorder; x += h)
                {
                    s += calculateValuePoint(x);
                }
                double result = s * h;
                Invoke((Action)(() =>
                {
                    trapeziumAnswer.Text = result.ToString() + " " + n;
                }));

            }).Start();
            
        }

        public int OptimalSplitsSimpson()
        {
            double smallerSquare = 1;
            double largerSquare = 0;
            int splits = 2;

            while (Math.Abs(largerSquare - smallerSquare) > accuracy)
            {
                double splitStep = (rBorder - lBorder) / splits;
                double x1 = lBorder;
                double x2 = lBorder;
                double smallerEvenSum = 0;
                double largerEvenSum = 0;
                double smallerOddSum = 0;
                double largerOddSum = 0;

                for (int counter = 1; counter < splits; ++counter)
                {
                    if (counter % 2 == 1)
                    {
                        x1 += splitStep;
                        smallerOddSum += calculateValuePoint(x1);
                    }

                    else
                    {
                        x1 += splitStep;
                        smallerEvenSum += calculateValuePoint(x1);
                    }
                }

                for (int counter = 1; counter < splits * 2; ++counter)
                {
                    if (counter % 2 == 1)
                    {
                        x2 += splitStep / 2;
                        largerOddSum += calculateValuePoint(x2);
                    }

                    else
                    {
                        x2 += splitStep / 2;
                        largerEvenSum += calculateValuePoint(x2);
                    }
                }
                smallerSquare = (splitStep / 3) * (calculateValuePoint(lBorder) + 4 * smallerOddSum + 2 * smallerEvenSum + calculateValuePoint(rBorder));
                largerSquare = (splitStep / 6) * (calculateValuePoint(lBorder) + 4 * largerOddSum + 2 * largerEvenSum + calculateValuePoint(rBorder));
                splits *= 2;
            }
            return splits;
        }

        public void Simpson()
        {
            new Thread(() =>
            {
                int n = OptimalSplitsSimpson();
                var h = (rBorder - lBorder) / n;
                var sum1 = 0d;
                var sum2 = 0d;
                for (var k = 1; k <= n; k++)
                {
                    var xk = lBorder + k * h;
                    if (k <= n - 1)
                    {
                        sum1 += calculateValuePoint(xk);
                    }

                    var xk_1 = lBorder + (k - 1) * h;
                    sum2 += calculateValuePoint((xk + xk_1) / 2);
                }

                var result = h / 3d * (1d / 2d * calculateValuePoint(lBorder) + sum1 + 2 * sum2 + 1d / 2d * calculateValuePoint(rBorder));
                Invoke((Action)(() =>
                {
                    simpsonAnswer.Text = result.ToString() + " " + n;
                }));
            }).Start();
        }


        public void changeLaunchMethod()
        {
            if(rectangleMethodCheck.Checked == true)
            {
                CentralRectangle();
            }

            if(trapeziumMethod.Checked == true)
            {
                Trapezium();
                //label2.Text = Trapezium().ToString();
            }

            if(simpsonMethodCheck.Checked == true)
            {
                Simpson();
                //label3.Text = Simpson().ToString();
            }
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (validation())
            {
                changeLaunchMethod();
            }
        }
    }
}
