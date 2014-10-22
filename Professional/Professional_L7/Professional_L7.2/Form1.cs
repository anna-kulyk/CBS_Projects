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
                    textBox1.Clear();
                    textBox1.Text += "Assembly " + path + " is loaded successfully" + Environment.NewLine + Environment.NewLine;
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message); ;
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (assembly == null)
            {
                textBox1.Text += "Open the assembly!" + Environment.NewLine;
                return;
            }

            textBox1.Clear();

            textBox1.Text += "List of all types in assembly: " + assembly.FullName + Environment.NewLine + Environment.NewLine;

            Type[] types = assembly.GetTypes();
            
            foreach (var type in types)
            {
                textBox1.Text += "Type: " + type + Environment.NewLine;
                GetAttributes(type);

                if (checkedListBox1.GetItemChecked(2) == true)
                {
                    var constructors = type.GetConstructors();
                    if (constructors != null)
                    {
                        foreach (var constructor in constructors)
                        {
                            textBox1.Text += "Constructor: " + constructor + Environment.NewLine;
                            GetAttributes(constructor);
                        }
                    }
                }

                if (checkedListBox1.GetItemChecked(3) == true)
                {
                    var events = type.GetEvents();
                    if (events != null)
                    {
                        foreach (var _event in events)
                        {
                            textBox1.Text += "Event: " + _event + Environment.NewLine;
                            GetAttributes(_event);
                        }
                    }
                }

                if (checkedListBox1.GetItemChecked(4) == true)
                {
                    var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
                    if (fields != null)
                    {
                        foreach (var field in fields)
                        {
                            textBox1.Text += "Field: " + field + Environment.NewLine;
                            GetAttributes(field);
                        }
                    }
                }

                if (checkedListBox1.GetItemChecked(5) == true)
                {
                    var methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.Static);
                    if (methods != null)
                    {
                        foreach (var method in methods)
                        {
                            textBox1.Text += "Method: " + method + Environment.NewLine;
                            GetAttributes(method);                            
                        }
                    }
                }

                if (checkedListBox1.GetItemChecked(6) == true)
                {
                    var nestedTypes = type.GetNestedTypes();
                    if (nestedTypes != null)
                    {
                        foreach (var nestedType in nestedTypes)
                        {
                            textBox1.Text += "Nested Type: " + nestedType + Environment.NewLine;
                            GetAttributes(nestedType);
                        }
                    }
                }

                if (checkedListBox1.GetItemChecked(7) == true)
                {
                    var properties = type.GetProperties();
                    if (properties != null)
                    {
                        foreach (var property in properties)
                        {
                            textBox1.Text += "Property: " + property + Environment.NewLine;
                            GetAttributes(property);
                        }
                    }
                }
            }  
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var checkBox = sender as CheckedListBox;
            if (checkBox == null) return;

            if (checkBox.SelectedIndex != 0) return;

            if (checkedListBox1.GetItemChecked(0) == true)
            {
                for (int i = 1; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
            }
            else 
            {
                for (int i = 1; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void GetAttributes(MemberInfo type)
        {
            if (checkedListBox1.GetItemChecked(1) == true)
            {
                var attributes = type.GetCustomAttributes();
                if (attributes != null)
                {
                    foreach (var attribute in attributes)
                    {
                        textBox1.Text += "Attribute: " + attribute + Environment.NewLine;
                    }
                }
            }
        }
    }
}
