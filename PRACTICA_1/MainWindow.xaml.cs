using System;
using System.Windows;

namespace PRACTICA_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double xValue = Convert.ToDouble(x.Text);
                double yValue = Convert.ToDouble(y.Text);
                CalculatorLogic calculator = new CalculatorLogic();

                if (oneuslovie.IsChecked == true)
                    one.Text = calculator.CalculateFormulaOne(xValue, yValue).ToString();
                else if (twouslovie.IsChecked == true)
                    one.Text = calculator.CalculateFormulaTwo(xValue, yValue).ToString();
                else if (threeuslovie.IsChecked == true)
                    one.Text = calculator.CalculateFormulaThree(xValue, yValue).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Ochistit_Click(object sender, RoutedEventArgs e)
        {
            x.Clear();
            y.Clear();
            one.Clear();
        }
    }

    public class CalculatorLogic
    {
        public double CalculateFormulaOne(double x, double y)
        {
            double ivan = Math.Sinh(x);

            if (y >= -1 && y <= x)
            {
                return Math.Sin((5 * ivan) + (3 * y * Math.Abs(ivan)));
            }
            else if (x > y)
            {
                return Math.Cos((3 * ivan) + (5 * y * Math.Abs(ivan)));
            }
            else
            {
                return Math.Pow((ivan + y), 2);
            }
        }

        public double CalculateFormulaTwo(double x, double y)
        {
            if (y >= -1 && y <= x)
            {
                return Math.Sin((5 * (x * x)) + (3 * y * Math.Abs(x * x)));
            }
            else if (x > y)
            {
                return Math.Cos((3 * (x * x)) + (5 * y * Math.Abs(x * x)));
            }
            else
            {
                return Math.Pow((x * x) + y, 2);
            }
        }

        public double CalculateFormulaThree(double x, double y)
        {
            if (y >= -1 && y <= x)
            {
                return Math.Sin((5 * Math.Exp(x)) + (3 * y * Math.Abs(Math.Exp(x))));
            }
            else if (x > y)
            {
                return Math.Cos((3 * Math.Exp(x)) + (5 * y * Math.Abs(Math.Exp(x))));
            }
            else
            {
                return Math.Pow((Math.Exp(x) + y), 2);
            }
        }
    }
}