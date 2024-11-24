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

namespace GymManagementSystem.ViewModel
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        //This will allow the form to be drag by the user
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

            //Check if the user click the left click
            if (e.LeftButton == MouseButtonState.Pressed)
            {

               DragMove();  
            }
        }

      

        private void Passwordtxt_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Passwordtxt.Password.Length > 0) // Check if the password field is not empty
            {
                Eye.Visibility = Visibility.Visible; // Show the eye icon
                PasswordErrorMessage.Text = "";
                Passwordtxt.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#727272"));
                Passwordtxt.BorderThickness = new Thickness(0, 0, 0, 2);
            }
            else
            {
                Eye.Visibility = Visibility.Collapsed; // Hide the eye icon
            }
        }
         
        private void Eye_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if(Passwordtxt.Visibility== Visibility.Visible)
            {
                PasswordUnmask.Text = Passwordtxt.Password;
                PasswordUnmask.Visibility = Visibility.Visible;
                Passwordtxt.Visibility = Visibility.Hidden;

            }
            else
            {

                PasswordUnmask.Visibility = Visibility.Collapsed;

                Passwordtxt.Visibility = Visibility.Visible;

            }

        }

        private void login()
        {

            string username= Usernametxt.Text;

            string password= Passwordtxt.Password;


            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {

                MessageBox.Show("All fields are required!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);


            }
            else
            {
                if (string.IsNullOrEmpty(username))
                {

                    UsernameErrorMessage.Text = "Username is required";
                    Usernametxt.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    Usernametxt.BorderThickness = new Thickness(0, 0, 0, 2);

                }
                else if ((string.IsNullOrEmpty(password)))
                {
                    PasswordErrorMessage.Text = "Password is required";
                    Passwordtxt.BorderBrush = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                    Passwordtxt.BorderThickness = new Thickness(0, 0, 0, 2);
                }
                else
                {

                    if(username== "Admin" && password == "123")
                    {


                        MainWindow checkin = new MainWindow();
                        checkin.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Incorrect username or password!!!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        ClearTextBoxes();
                    }


                }



            }




        }

      
 

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        private void Usernametxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Usernametxt.Text.Length > 0)
            {

                UsernameErrorMessage.Text = "";
                Usernametxt.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#727272"));
                Usernametxt.BorderThickness = new Thickness(0, 0, 0, 2); 

            }
        }

        private void ClearTextBoxes()
        {

            Usernametxt.Text = "";
            Passwordtxt.Password = "";

            PasswordUnmask.Visibility = Visibility.Hidden;
            Passwordtxt.Visibility = Visibility.Visible;
            

        }

        private void Unhide()
        {


        }

        private void forgotpassword_MouseDown(object sender, MouseButtonEventArgs e)
        {


            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
            this.Hide();
        }

        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
