using System.Windows;
using System.Windows.Media;

namespace Diplom
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        ApplicationContext db;

        public Registration()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = textBoxEmail.Text.Trim();

            if (login.Length < 3)
            {
                textBoxLogin.ToolTip = "Поле введено некорректно";
                textBoxLogin.Background = Brushes.Red;
            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "Поле введено некорректно";
                passBox.Background = Brushes.Red;
            }
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "Поле введено некорректно";
                passBox_2.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Поле введено некорректно";
                textBoxEmail.Background = Brushes.Red;
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                Close();


                User user = new User(login, pass, email);

                db.Users.Add(user);
                db.SaveChanges();

                MessageBox.Show("Вы успешно зарегистрированы!");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
