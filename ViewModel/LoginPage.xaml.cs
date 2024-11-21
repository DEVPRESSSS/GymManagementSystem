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
    }
}
