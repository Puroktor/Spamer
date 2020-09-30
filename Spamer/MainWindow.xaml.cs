using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Forms;

namespace Spamer
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(1);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                SendKeys.SendWait(text.Text);
                SendKeys.SendWait("{ENTER}");
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            process.Text = "В процессе...";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            process.Text = "";
        }
    }
}
