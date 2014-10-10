using System;
using System.Xml;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace Professional_L5._3
{
    public partial class Form1 : Form
    {

        private ListBox listBox1;
        private Button button1;
        private ColorDialog chooseColorDialog = new ColorDialog();

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (ReadSettings() == false)
                    listBox1.Items.Add("В файле конфигурации нет информации...");
                else
                    listBox1.Items.Add("Информация успешно загружена из файла конфигурации...");

                this.StartPosition = FormStartPosition.CenterScreen;
            }
            catch (Exception e)
            {
                listBox1.Items.Add("Возникала проблема при загрузке данных из файла конфигурации:");
                listBox1.Items.Add(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chooseColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = chooseColorDialog.Color;
            }
        }

        void SaveSettings()
        {
            XmlDocument doc = LoadConfigDocument();

            XmlNode node = doc.SelectSingleNode("//appSettings");

            string[] keys = new string[] {"BackGroundColor.R",
										  "BackGroundColor.G",
										  "BackGroundColor.B",
										  "X",
										  "Y",
										  "Window.Height",
										  "Window.Width",
										  "Window.State"};

            string[] values = new string[] {BackColor.R.ToString(),
                                            BackColor.G.ToString(),
                                            BackColor.B.ToString(),
                                            DesktopLocation.X.ToString(),
                                            DesktopLocation.Y.ToString(),
                                            Height.ToString(),
                                            Width.ToString(),
                                            WindowState.ToString()};

            for (int i = 0; i < keys.Length; i++)
            {
                XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

                if (element != null)
                {
                    element.SetAttribute("value", values[i]);
                }
                else
                {
                    element = doc.CreateElement("add");
                    element.SetAttribute("key", keys[i]);
                    element.SetAttribute("value", values[i]);
                    node.AppendChild(element);
                }                
            }

            doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
        }
        
        bool ReadSettings()
        {
            NameValueCollection appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count < 1)
            {
                return false;
            }

            //Color
            int red = Convert.ToInt32(appSettings["BackGroundColor.R"]);
            int green = Convert.ToInt32(appSettings["BackGroundColor.G"]);
            int blue = Convert.ToInt32(appSettings["BackGroundColor.B"]);

            this.BackColor = Color.FromArgb(red, green, blue);
            listBox1.Items.Add("Background color: " + BackColor.Name);

            //Location
            int x = Convert.ToInt32(appSettings["X"]);
            int y = Convert.ToInt32(appSettings["Y"]);

            this.DesktopLocation = new Point(x, y);
            listBox1.Items.Add("Location: " + DesktopLocation.ToString());

            //Size
            this.Height = Convert.ToInt32(appSettings["Window.Height"]);
            this.Width = Convert.ToInt32(appSettings["Window.Width"]);
            listBox1.Items.Add("Window size: " + new Size(Width, Height).ToString());
           
            //State
            string windowState = appSettings["Window.State"];
            this.WindowState = (FormWindowState)FormWindowState.Parse(WindowState.GetType(), windowState);
            listBox1.Items.Add("Window state: " + windowState);

            return true;
        }

        private static XmlDocument LoadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
                return doc;
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("No configuration file found.", ex);
            }            
        }
    }
}
