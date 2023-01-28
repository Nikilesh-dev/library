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

namespace library
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {

            

            InitializeComponent();
            

            Settings settings = new Settings();

            lblname.Content = settings.Username;
            lblbook1.Content = settings.Availability.ToString();
            lblbook2.Content = settings.Availabilityt.ToString();
            lblbook3.Content = settings.Availability2.ToString();
            lblbook4.Content = settings.Availability3.ToString();
            lblbook5.Content = settings.Availability4.ToString();
            lblbook6.Content = settings.Availability5.ToString();
            lblbook7.Content = settings.Availability6.ToString();
            lblbook8.Content = settings.Availability7.ToString();


            //Window2 window2 = new Window2();
            //lblname.Content = window2.txtUname;

            
        }

        
        private void take_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability;

          MessageBoxResult result =   MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability = Availability;
                    settings.Save();
                    lblbook1.Content = Availability.ToString();
                }
            }
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability = Availability;
                    settings.Save();
                    lblbook1.Content = Availability.ToString();
                }
            }
        }

        private void take1_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availabilityt;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availabilityt = Availability;
                    settings.Save();
                    lblbook2.Content = Availability.ToString();
                }
            }
        }

        private void Return1_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availabilityt;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availabilityt = Availability;
                    settings.Save();
                    lblbook2.Content = Availability.ToString();
                }
            }
        }

        private void take2_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability2;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability2 = Availability;
                    settings.Save();
                    lblbook3.Content = Availability.ToString();
                }
            }
        }

        private void Return2_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability2;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability2 = Availability;
                    settings.Save();
                    lblbook3.Content = Availability.ToString();
                }
            }
        }

        private void take3_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability3;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability3 = Availability;
                    settings.Save();
                    lblbook4.Content = Availability.ToString();
                }
            }
        }

        private void Return3_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability3;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability3 = Availability;
                    settings.Save();
                    lblbook4.Content = Availability.ToString();
                }
            }
        }

        private void take4_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability4;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability4 = Availability;
                    settings.Save();
                    lblbook5.Content = Availability.ToString();
                }
            }
        }

        private void Return4_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability4;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability4 = Availability;
                    settings.Save();
                    lblbook5.Content = Availability.ToString();
                }
            }
        }

        private void take5_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability5;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability5 = Availability;
                    settings.Save();
                    lblbook6.Content = Availability.ToString();
                }
            }
        }

        private void Return5_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability5;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability5 = Availability;
                    settings.Save();
                    lblbook6.Content = Availability.ToString();
                }
            }
        }

        private void take6_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability6;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability6 = Availability;
                    settings.Save();
                    lblbook7.Content = Availability.ToString();
                }
            }
        }

        private void Return6_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability6;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability6 = Availability;
                    settings.Save();
                    lblbook7.Content = Availability.ToString();
                }
            }
        }

        private void take7_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();

            int Availability = settings.Availability7;

            MessageBoxResult result = MessageBox.Show("Do You Wish to take this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);


            if (result == MessageBoxResult.Yes)
            {
                if (Availability <= 20)
                {
                    Availability--;




                    settings.Availability7 = Availability;
                    settings.Save();
                    lblbook8.Content = Availability.ToString();
                }
            }
        }

        private void Return7_Click(object sender, RoutedEventArgs e)
        {

            Settings settings = new Settings();

            int Availability = settings.Availability7;

            MessageBoxResult result = MessageBox.Show("Do You Wish to Return this book ?", "BOOKS", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if (result == MessageBoxResult.Yes)
            {
                if (Availability < 20)
                {
                    Availability++;




                    settings.Availability7 = Availability;
                    settings.Save();
                    lblbook8.Content = Availability.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do You Wish to Logout?", "LOGOUT", MessageBoxButton.YesNo, MessageBoxImage.Information);

            if(result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
           
        }
    }
}
