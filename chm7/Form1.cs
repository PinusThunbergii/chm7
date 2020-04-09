using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chm7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        double x0;
        double y0;
        double a;
        double b;
        int n;
        double h;
        double[] xi_array;
        double[] yi_array;

        double[] xi_array_mod;
        double[] yi_array_mod;

        double[] xi_array_anal;
        double[] yi_array_anal;

        delegate double Function(double x, double y);
        delegate double DFunction(double x, double y, double c);
        double function(double x, double y)
        {
            return Math.Cos(1.5d * x + y) + (x - y);
            //return 1.0d - 0.05d * x * Math.Exp(x);
        }

        double analytical_y(double x, double y, double c)
        {
            return c - 0.05d * Math.Exp(x) * x + x + 0.05d * Math.Exp(x);
        }

        void calculate_analitical(DFunction dFunction, double x0, double y0, double c, double h, int n, out double[] xi_array, out double[] yi_array)
        {
            xi_array = new double[n];
            yi_array = new double[n];
            for (int i = 0; i < n; i++)
            {
                xi_array[i] = x0 + h * i;
                yi_array[i] = dFunction(xi_array[i], 0, c);
            }
        }

        void euler_method(Function function, double x0, double y0, double h, int n, out double[] xi_array, out double[] yi_array)
        {
            xi_array = new double[n];
            yi_array = new double[n];
            xi_array[0] = x0;
            yi_array[0] = y0;
            for (int i = 1; i < n; i++)
            {
                xi_array[i] = x0 + h * i;
                yi_array[i] = yi_array[i - 1] + h * function(xi_array[i - 1], yi_array[i - 1]);
            }
        }
        void runge_kutta_method(Function function, double x0, double y0, double h, int n, out double[] xi_array, out double[] yi_array)
        {
            xi_array = new double[n];
            yi_array = new double[n];
            xi_array[0] = x0;
            yi_array[0] = y0;
            double[] k = new double[4];
            for (int i = 1; i < n; i++)
            {
                xi_array[i] = x0 + h * i;
                k[0] = function(xi_array[i - 1], yi_array[i - 1]);
                k[1] = function(xi_array[i - 1] + h / 2.0d, yi_array[i - 1] + h * k[0] / 2.0d);
                k[2] = function(xi_array[i - 1] + h / 2.0d, yi_array[i - 1] + h * k[1] / 2.0d);
                k[3] = function(xi_array[i - 1] + h, yi_array[i - 1] + h * k[0]);
                yi_array[i] = yi_array[i - 1] + h / 6.0d * (k[0] + 2.0d * k[1] + 2.0d * k[2] + k[3]);
            }
        }

        void euler_method_modified(Function function, double x0, double y0, double h, int n, out double[] xi_array, out double[] yi_array)
        {
            xi_array = new double[n];
            yi_array = new double[n];
            xi_array[0] = x0;
            yi_array[0] = y0;
            for (int i = 1; i < n; i++)
            {
                xi_array[i] = x0 + h * i;
                double y_star = yi_array[i - 1] + function(xi_array[i - 1], yi_array[i - 1]);
                yi_array[i] = yi_array[i - 1] + h / 2 * (function(xi_array[i - 1], yi_array[i - 1]) + function(xi_array[i], y_star));
            }
        }

        void CalculateButton_OnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                if (!Double.TryParse(x0TextBox.Text, out x0) || !Double.TryParse(y0TextBox.Text, out y0)
                    || !Int32.TryParse(nTextBox.Text, out n) || !Double.TryParse(aTextBox.Text, out a)
                    || !Double.TryParse(bTextBox.Text, out b))
                {
                    throw new Exception("Input invalid!!!");
                }
                h = Math.Abs((b - a) / (double)n);
                hTextBox.Text = h.ToString();

                runge_kutta_method(function, x0, y0, h, n, out xi_array, out yi_array);
                //euler_method_modified(function, x0, y0, h, n, out xi_array_mod, out yi_array_mod);
                //calculate_analitical(analytical_y, x0, y0, -0.341218031767503d, h, n, out xi_array_anal, out yi_array_anal);

                dataGridView.Rows.Clear();
                chart.Series[0].Points.Clear();
                //chart.Series[1].Points.Clear();
                for (int i = 0; i < n; i++)
                {
                    dataGridView.Rows.Add(i, xi_array[i], yi_array[i]);
                    chart.Series[0].Points.AddXY(xi_array[i], yi_array[i]);
                    //chart.Series[1].Points.AddXY(xi_array_mod[i], yi_array_mod[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
