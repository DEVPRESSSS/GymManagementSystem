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

namespace GymManagementSystem.ViewModel
{
    /// <summary>
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Window
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //Go back to login

            LoginPage login = new LoginPage();

            login.Show();

            this.Hide();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {

                //it will allow the use to drag the form

                DragMove();
            }
        }

        private void SendOTP_Click(object sender, RoutedEventArgs e)
        {


            ChangePassword changePassword = new ChangePassword();
            changePassword.Show();

            this.Hide();
        }
    }
}
