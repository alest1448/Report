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

namespace Report.Pages
{
    /// <summary>
    /// Логика взаимодействия для SimOne.xaml
    /// </summary>
    public partial class SimOne : Page
    {
        public SimOne()
        {
            InitializeComponent();
            
        }

        private void btAll_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btSept_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new September();

        }

        private void btOct_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new October();

        }

        private void btNovember_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new November();

        }
    }
}
