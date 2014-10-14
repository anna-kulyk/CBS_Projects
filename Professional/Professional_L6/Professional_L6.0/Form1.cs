using System;
using System.Reflection;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Professional_L6._0
{
    public partial class Form1 : Form
    {
        /*
         * Создайте программу-рефлектор, которая позволит получить информацию о сборке 
         * и входящих в ее состав типах. Для основы можно использовать программу- рефлектор из урока.
        */

        Assembly assembly = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                try
                {
                    assembly = Assembly.LoadFile(path);
                    textBox1.Text += "Assembly " + path + " is loaded successfully" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message); ;
                }

                textBox1.Text += "List of all types in assembly: " + assembly.FullName + Environment.NewLine + Environment.NewLine;

                Type[] types = assembly.GetTypes();

                foreach (var type in types)
                {
                    textBox1.Text += "Type: " + type + Environment.NewLine;
                    var methods = type.GetMethods();
                    if (methods != null)
                    {
                        foreach (var method in methods)
                        {
                            textBox1.Text += "Method: " + method + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
