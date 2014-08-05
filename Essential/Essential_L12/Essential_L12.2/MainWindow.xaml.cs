using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Essential_L12._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            double op1 = Convert.ToDouble(operand1.Text);
            double op2 = Convert.ToDouble(operand2.Text);
            double r = 0;
            Button clickedButton = (Button)sender;
            switch((string)clickedButton.Content)
            {
                case "+":
                    {
                        r = Add(op1, op2);
                        break;
                    }
                case "-":
                    {
                        r = Subtract(op1, op2);
                        break;
                    }
                case "*":
                    {
                        r = Multiply(op1, op2);
                        break;
                    }
                case "/":
                    {
                        if (op2 == 0)
                        {
                            MessageBox.Show("ERROR: You cannot divide by zero!");
                        }
                        else
                        {
                            r = Divide(op1, op2);
                        }                        
                        break;
                    }
            }            
            result.Text = Convert.ToString(r);
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
