using GenerateCardWPFPractice;
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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }



        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void logOutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            //new CardNumber object
            CardNumber testCard = new CardNumber();

            //Converting Card Digits into one String to display to User:
            //first half of Card Number to String: "7 55555"
            string a = string.Concat(testCard.Card[0], " ", testCard.Card[1], testCard.Card[2], testCard.Card[3], testCard.Card[4], testCard.Card[5], " ");

            //second half of Card Number to String
            //start at first account number digit, add each following account number digit to string
            string b = Convert.ToString(testCard.Card[6]);

            for (int i = 7; i < testCard.CardLength - 1; i++)
            {
                b = b + Convert.ToString(testCard.Card[i]);
            }

            //check dig
            string c = string.Concat(" ", testCard.Card[testCard.CardLength]);

            //combine the above strings / parts of card number into one String "ccNumber"
            string ccNumber = a + b + c;
            //Console.WriteLine(ccNumber);
            //Console.ReadLine();

            MessageBox.Show(string.Format("Your Card Number is: \r\n{0}", ccNumber));
        }
    }
}
