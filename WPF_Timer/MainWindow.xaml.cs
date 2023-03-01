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
using System.Windows.Threading;

namespace WPF_Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DateTime currentTime;
        public DateTime clockInTime;
        public DateTime clockOutTime;
        public TimeSpan timeWorked;
        DispatcherTimer timer = new DispatcherTimer();
        public List<PayLog> pay = new List<PayLog>();

        public MainWindow()
        {
            InitializeComponent();

            // Disables "Clock Out" button...
            btn_clockOut.IsEnabled= false;

            // Creates a timer.
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            // Realtime clock
            currentTime = DateTime.Now;
            lbl_currentTime.Content = currentTime.ToString("h:mm:ss tt");
        }

        private void clock_In(object sender, RoutedEventArgs e)
        {
            // Checks to see if the hourly pay box has correct input
            int parsedValue;
            if (!int.TryParse(txtBox_hourlyPay.Text, out parsedValue))
            {
                MessageBox.Show("Set your hourly pay!");
            }
            else
            {
                // Adds current time to clockedIn label and disables clockIn button and enables clockOut button
                clockInTime = currentTime;
                lbl_clockIn.Content = clockInTime.ToString("h:mm:ss tt");
                btn_clockIn.IsEnabled = false;
                btn_clockOut.IsEnabled = true;
            }
        }

        private void clock_out(object sender, RoutedEventArgs e)
        {
            // Checks to see if the hourly pay box has correct input
            int parsedValue;
            if (!int.TryParse(txtBox_hourlyPay.Text, out parsedValue))
            {
                MessageBox.Show("Set your hourly pay!");
            }
            else
            {
                // Adds current time to clockedOut label and disables clockOut button and enables clockIn Button.
                clockOutTime = currentTime;
                lbl_clockOut.Content = clockOutTime.ToString("h:mm:ss tt");
                btn_clockIn.IsEnabled = true;
                btn_clockOut.IsEnabled = false;

                //Grabs the number from txtBox_hourlyPay and assigns to pay...
                int payRate = Int32.Parse(txtBox_hourlyPay.Text);

                // Finds timeWorked by subtracting clockInTime from clockOutTime and displays results
                timeWorked = clockOutTime.Subtract(clockInTime);
                decimal totalPay = (decimal)(Math.Round(timeWorked.TotalHours, 3) * payRate);
                lbl_payResults.Content = "You make " + totalPay.ToString("C") + " by working for " + timeWorked.ToString(@"hh\:mm");
            }
        }

        // Opens the help window...
        private void help_Clicked(object sender, RoutedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

    }
}
