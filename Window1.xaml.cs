using System;
using System.Collections.Generic;
using System.IO;
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

namespace library
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            String Fname = txtFanme.Text;
            String Lname = txtLanme.Text;
            String Mail1 = txtMail.Text;
            String User = txtUser.Text;
            String Pass1 = txtpass.Text;
            String Pass2 = txtpass1.Text;
            String Number = txtnum.Text;

            String Name = Fname + Lname;


           

            String builder = "";
            char[] chars = { '@', '.' };
         
            char[] Mail = Mail1.ToCharArray();

            for (int i = 0; i < Mail.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (Mail[i] == chars[j])
                    {

                        builder = "OK";

                    }

                }
            }
            String file = Path.Combine("A:\\File", User + ".txt");
            

            bool yes = File.Exists(file);

            if (yes == true)
            {
                MessageBox.Show("UserName Already exists","Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }else if (Fname != null && Lname!= null && builder =="OK" && User != null && Pass1 == Pass2) {

                Settings settings = new Settings();
                settings.Name = Name;
                settings.Number = Number;
                settings.Mail = Mail1;
                settings.Username = User;
                settings.Password = Pass2;
                settings.Save();
                String Details = "Name :" + Name + "UserName : " + User + "Mail : " + Mail1 + "Phone number : " + Number;
                File.WriteAllText(file, Details);

                MessageBoxResult result =  MessageBox.Show("Sucessfully Register", "Registeration", MessageBoxButton.OK, MessageBoxImage.Information);

                if (result == MessageBoxResult.OK)
                {
                    MainWindow main = new MainWindow();
                    main.Show();
                }

            }
            else
            {
                MessageBox.Show("Please provid valid Details","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }



        }
    }
}
