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
using System.IO;
using static Diplom.Lession1;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Tasks.xaml
    /// </summary>
    public partial class Tasks : Window
    {
        public static int id;
        public Tasks()
        {
            InitializeComponent();
            
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Lession_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
            Lession1 lession1 = new Lession1();
            lession1.Show();
        }

        private void Pr_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
            
        }

        private void Pr_2_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_3_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_3_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_3_2_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_4_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_4_2_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_4_5_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_5_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_5_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_6_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_6_2_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_7_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_8_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_9_10_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_11_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_11_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_12_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_13_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_13Sl_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_14_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_15_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_16_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_16_1_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_17_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_18_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_19_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_21_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_22_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_23_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_24_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_25_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void Pr_26_Click(object sender, RoutedEventArgs e)
        {
            id = 1;
        }

        private void FastTasks_Click(object sender, RoutedEventArgs e)
        {
            id = 2;
            Lession1 lession1 = new Lession1();
            lession1.Show();
        }

        private void BtnUsExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
