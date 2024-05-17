using Report.Connect;
using Report.Pages;
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

namespace Report.Windows
{
    /// <summary>
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Window
    {
        public authorization()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var User = conn.db.Users.FirstOrDefault(w => w.login == tbLogin.Text && w.password == tbPassword.Password);
                if (User != null) 
                {

                    if (User.login == "admin")
                    {
                        MessageBox.Show("Вы вошли под администратором!");
                    }
                    else
                    {
                        //tbName.Text = User.FIO;

                        MessageBox.Show($"Добро пожаловать {User.FIO}!");
                        elder w = new elder();
                        w.txt = User.FIO; //определение имени пользователя и его перенос на главную форму
                        w.txt1 = Convert.ToString(User.idGroup); //определение группы пользователя и его перенос на главную форму

                        w.Show();
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Не правильно введен логин или пароль!");
                    tbLogin.Text = "";
                    tbPassword.Password = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка" + ex);
            }

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        
    }
}
