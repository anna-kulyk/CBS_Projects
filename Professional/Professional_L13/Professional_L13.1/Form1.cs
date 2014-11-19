using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;

namespace Professional_L13._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int a, b, c;

        private bool GetArguments()
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;           
        }

        private int Add(int a, int b)
        {
            return (a + b);
        }

        private void CallbackMethod(IAsyncResult ar)
        {
            var result = (AsyncResult)ar;

            var callerDelegate = (Func<int, int, int>)result.AsyncDelegate;

            TextBox tb3 = (TextBox)ar.AsyncState;

            c = callerDelegate.EndInvoke(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GetArguments())
            {
                var caller = new Func<int, int, int>(Add);

                IAsyncResult ar = caller.BeginInvoke(a, b, null, null);

                while (ar.IsCompleted == false)
                {
                    Thread.Sleep(20);
                }

                c = caller.EndInvoke(ar);

                textBox3.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GetArguments())
            {
                var caller = new Func<int, int, int>(Add);

                IAsyncResult ar = caller.BeginInvoke(a, b, null, null);

                c = caller.EndInvoke(ar);

                textBox3.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (GetArguments())
            {
                var caller = new Func<int, int, int>(Add);

                caller.BeginInvoke(a, b, CallbackMethod, null);

                Thread.Sleep(50);

                textBox3.Text = c.ToString();
            }            
        }
    }
}
