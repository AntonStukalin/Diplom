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
using static Diplom.Tasks;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Lession1.xaml
    /// </summary>
    public partial class Lession1 : Window
    {
        public Lession1()
        {
            InitializeComponent();
            

            RichTextBox rtb = new RichTextBox();
            Paragraph p = rtb.Document.Blocks.FirstBlock as Paragraph;

            p.LineHeight = 12;
            p.Margin = new Thickness(12);

            switch (id)
            {
                case 1:
                    StreamReader streamReader1 = new StreamReader(@"C:\Users\Администратор\source\repos\Diplom\Diplom\Resources\Лекция.txt");
                    LessionBox.Text = streamReader1.ReadToEnd();
                    streamReader1.Close();
                    break;
                case 2:
                    StreamReader streamReader2 = new StreamReader(@"C:\Users\Администратор\source\repos\Diplom\Diplom\Resources\Задачи_на_скорость.txt");
                    LessionBox.Text = streamReader2.ReadToEnd();
                    streamReader2.Close();
                    break;
                
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Owner = this;
            Close();
        }
    }
}
