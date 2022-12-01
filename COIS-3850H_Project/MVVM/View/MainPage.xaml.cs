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
using System.Windows.Shapes;

namespace COIS_3850H_Project.MVVM.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Form_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton != MouseButton.Left)
            {
                return;
            }
            downPoint = new Point(Mouse.GetPosition(Application.Current.MainWindow).X, Mouse.GetPosition(Application.Current.MainWindow).Y);
        }

        public void Form_MouseMove(object sender, MouseEventArgs e)
        {

            if (downPoint == new Point(0, 0))
            {
                return;
            }
            var location = new Point(Left + Mouse.GetPosition(Application.Current.MainWindow).X - downPoint.X, Top + Mouse.GetPosition(Application.Current.MainWindow).Y - downPoint.Y);
            Left = location.X;
            Top = location.Y;
        }

        public void Form_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton != MouseButton.Left)
            {
                return;
            }
            downPoint = new Point(0, 0);
        }

        public Point downPoint = new Point(0, 0);


        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void payButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void showAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void paymentButton_Click(object sender, RoutedEventArgs e)
        {
            Payment paymentPage = new Payment();
            paymentPage.Show();
            this.Close();
        }

        private void myCardsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Close();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void activityButton_Click(object sender, RoutedEventArgs e)
        {
            UsageStatisticsPage usageStatisticsPage = new UsageStatisticsPage();
            usageStatisticsPage.Show();
            this.Close();
        }
    }
}
