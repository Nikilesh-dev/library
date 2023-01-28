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

namespace library
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1= new Window1();
            window1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Settings settings  = new Settings();
            if(txtUname.Text == settings.Username && txtpass.Password == settings.Password)
            {
                settings.Username = txtUname.Text;
                Window3 window3 = new Window3();    
                window3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid user Name and password");
            }
        }
    }
}
