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
        private readonly Calculator newCalc = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newRequest = new OperationRequest();
            newRequest.Operand1 = Convert.ToDouble(operand1.Text);
            newRequest.Operand2 = Convert.ToDouble(operand2.Text);            
            Button clickedButton = (Button)sender;
            newRequest.Operation = ReadButton(clickedButton);
            var newResponse = newCalc.Calculate(newRequest);
            if (newResponse.Error == null)
            {
                result.Text = Convert.ToString(newResponse.Result); 
            }
            else
            {
                MessageBox.Show(newResponse.Error);
            }
        }

        private Operations ReadButton(Button button)
        {
            Operations operation;
            switch ((string)button.Content)
            {
                case "+":
                    {
                        operation = Operations.Add;
                        break;
                    }
                case "-":
                    {
                        operation = Operations.Subtract;
                        break;
                    }
                case "*":
                    {
                        operation = Operations.Multiply;
                        break;
                    }
                case "/":
                    {
                        operation = Operations.Divide;
                        break;
                    }
                default:
                    {
                        operation = Operations.None;
                        break;
                    }
            }
            return operation;
        }        
    }
}
