﻿using System;
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
using Xamarin.Forms;

namespace COIS_3850H_Project.MVVM.View
{
    /// <summary>
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
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

        private void activityButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void paymentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
        private void txtCard_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCard.Text) && txtCard.Text.Length > 0)
                textCard.Visibility = Visibility.Collapsed;
            else
                textCard.Visibility = Visibility.Visible;
        }

        private void textCard_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtCard.Focus();
        }



        private void txtCardPin_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCardPin.Text) && txtCardPin.Text.Length > 0)
                textCardPin.Visibility = Visibility.Collapsed;
            else
                textCardPin.Visibility = Visibility.Visible;
        }

        private void textCardPin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtCardPin.Focus();
        }

        private void txtAmount_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAmount.Text) && txtAmount.Text.Length > 0)
                textAmount.Visibility = Visibility.Collapsed;
            else
                textAmount.Visibility = Visibility.Visible;
        }

        private void textAmount_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtAmount.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please , Enter the Deposit Amount, Try Again");
            }
            else if(txtCardPin.Text == "")
            {
                MessageBox.Show("Please, Enter the Card Pin, Try Again");

            }
            else if(txtCard.Text == "")
            {
                MessageBox.Show("Please , Enter the Card Number, Try Again");
            }
            else
            {
                MessageBox.Show("You Amount $" + txtAmount.Text + " has been succesfully deposited");
            }
        }
    }
}

