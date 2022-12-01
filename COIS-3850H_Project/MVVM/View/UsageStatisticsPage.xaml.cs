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
    /// Interaction logic for UsageStatisticsPage.xaml
    /// </summary>
    public partial class UsageStatisticsPage : Window
    {
        public UsageStatisticsPage()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void myCardsButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }

        private void paymentButton_Click(object sender, RoutedEventArgs e)
        {
            Payment paymentPage = new Payment();
            paymentPage.Show();
            this.Close();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Close();
        }

        private void activityButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
