using System;
using System.IO;
using System.IO.IsolatedStorage;
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

namespace Professional_L3._3
{
    // Создайте приложение WPF Application, позволяющее пользователям сохранять данные в изолированное хранилище.
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
            using (IsolatedStorageFile isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.User | IsolatedStorageScope.Domain | IsolatedStorageScope.Assembly, null, null))
            {
                isoStore.CreateDirectory("Professional_L3.3");
                IsolatedStorageFileStream isfs = isoStore.OpenFile("Professional_L3.3/HereIAm.txt", FileMode.OpenOrCreate, FileAccess.Write);
                using (StreamWriter sw = new StreamWriter(isfs))
                {
                    string line = _textBox.Text;
                    sw.BaseStream.Position = sw.BaseStream.Length;
                    sw.WriteLine(line);
                }                
            }
            _textBox.Clear();
        }

        
    }
}
