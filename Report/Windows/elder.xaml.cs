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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Report.Windows
{
    /// <summary>
    /// Логика взаимодействия для elder.xaml
    /// </summary>
    public partial class elder : Window
    {
        public elder()
        {
            InitializeComponent();
            Frame.Content = new general();

            
        }
        public string txt
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string txt1
        {
            get { return tbGroup.Text; }
            set { tbGroup.Text = value; }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btEx_Click(object sender, RoutedEventArgs e)
        {
            authorization a = new authorization();
            a.Show();
            this.Close();

        }

        private void btGeneral_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new general();

        }

        private void btSim1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new SimOne();
            September w = new September();
            w.txt = Convert.ToString(tbGroup.Text); //определение имени пользователя и его перенос на главную форму


        }

        private void btSimTwo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
