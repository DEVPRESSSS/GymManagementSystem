using GymManagementSystem.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GymManagementSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainContentArea.Content = new Dashboard();

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {


            if(e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {


            MessageBoxResult msg= MessageBox.Show("Are you sure you want to exit?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Question);


            if (msg == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown(0);
            }
        }

     

        private void Dashboard_Click(object sender, RoutedEventArgs e)
        {


            //it opens the usercontrol named Dashboard
            MainContentArea.Content= new Dashboard();
        }

        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            //it opens the usercontrol named Employee
            MainContentArea.Content = new Employee();
        }

        private void Members_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Attendance_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Equipments_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {

        }

       
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult dialogResult= MessageBox.Show("Are you sure you want to close the application?","Confirmation",MessageBoxButton.YesNo,MessageBoxImage.Question); 


            if (dialogResult == MessageBoxResult.Yes)
            {

                Application.Current.Shutdown(0);


            }

        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {

            if(WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }
        }
    }
}