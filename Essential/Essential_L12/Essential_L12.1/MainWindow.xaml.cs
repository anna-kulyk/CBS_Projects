using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Threading;
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

namespace Essential_L12._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer();

            _timer.Interval = new TimeSpan(0, 0, 0, 1);
            _timer.Tick += OnTimerTick;

            _timer.Start();
            _timer.IsEnabled = false;
        }

        private void OnTimerTick(object s, EventArgs e)
        {
            var currentTime = timerLabel.Content as string;
            if (string.IsNullOrEmpty(currentTime))
            {
                _timer.IsEnabled = false;
                MessageBox.Show("TIMER IS NOT CORRECT!!!1");
            }

            var time = TimeSpan.Parse(currentTime);
            time = time.Add(_timer.Interval);

            timerLabel.Content = string.Format("{0:D2}:{1:D2}:{2:D2}", time.Hours, time.Minutes, time.Seconds);
        }

        private void OnStartClick(object s, EventArgs e)
        {
            _timer.IsEnabled = true;
        }

        private void OnPauseClick(object s, EventArgs e)
        {
            _timer.IsEnabled = false;
        }

        private void OnStopClick(object s, EventArgs e)
        {
            _timer.IsEnabled = false;
            timerLabel.Content = "00:00:00";
        }
    }
}
