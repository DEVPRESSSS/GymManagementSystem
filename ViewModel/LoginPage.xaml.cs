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
            if (Passwordtxt.Password.Length > 0) 
            {
                Eye.Visibility = Visibility.Visible; 
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
                Eye.Visibility = Visibility.Collapsed;
                Eye2.Visibility = Visibility.Visible;

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

            //Cleart the username textbox
            Usernametxt.Text = "";

            //Clear the password box
            Passwordtxt.Password = "";

            //Set the passwordUnmask to hidden
            PasswordUnmask.Visibility = Visibility.Hidden;

            //Set the passwordtxt to be visible
            Passwordtxt.Visibility = Visibility.Visible;
            

        }

      

        private void forgotpassword_MouseDown(object sender, MouseButtonEventArgs e)
        {

            //this will open the forgot password if the user clicks it


            //Declare an instance of forgotpassword
           
            ForgotPassword forgotPassword = new ForgotPassword();

            //call the show method to show the form
            forgotPassword.Show();

            //close the login form
            this.Hide();
        }

      

        private void Eye2_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (PasswordUnmask.Visibility == Visibility.Visible)
            {
                Eye.Visibility = Visibility.Visible;
                Eye2.Visibility = Visibility.Collapsed;

                Passwordtxt.Password = PasswordUnmask.Text;
                Passwordtxt.Visibility = Visibility.Visible;
                PasswordUnmask.Visibility = Visibility.Hidden;

            }
        }

        private void PasswordUnmask_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(PasswordUnmask.Text.Length == 0)
            {

                Eye2.Visibility = Visibility.Hidden;


            }
            else
            {

                Eye2.Visibility = Visibility.Visible;

            }
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to close the application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);


            if (dialogResult == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown(0);


            }

        }
    }
}
