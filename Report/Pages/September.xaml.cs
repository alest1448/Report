using Report.Connect;
using Report.Windows;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Report.Pages
{
    /// <summary>
    /// Логика взаимодействия для September.xaml
    /// </summary>
    public partial class September : Page
    {
        public string txt
        {
            get { return tbNum.Text; }
            set { tbNum.Text = value; }
        }

        public September()
        {
            InitializeComponent();

           dg.ItemsSource = Connect.conn.db.SemestrOne.ToList();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            var Row = conn.db.SemestrOne.Where(w => w.Name == tbName.Text).FirstOrDefault();
            Row.Sept1 = Convert.ToInt32(tb01.Text);
            Row.Sept2 = Convert.ToInt32(tb02.Text);
            Row.Sept3 = Convert.ToInt32(tb03.Text);
            Row.Sept4 = Convert.ToInt32(tb04.Text);
            Row.Sept5 = Convert.ToInt32(tb05.Text);
            Row.Sept6 = Convert.ToInt32(tb06.Text);
            Row.Sept7 = Convert.ToInt32(tb07.Text);
            Row.Sept8 = Convert.ToInt32(tb08.Text);
            Row.Sept9 = Convert.ToInt32(tb09.Text);
            Row.Sept10 = Convert.ToInt32(tb10.Text);
            Row.Sept11 = Convert.ToInt32(tb11.Text);
            Row.Sept12 = Convert.ToInt32(tb12.Text);
            Row.Sept13 = Convert.ToInt32(tb13.Text);
            Row.Sept14 = Convert.ToInt32(tb14.Text);
            Row.Sept15 = Convert.ToInt32(tb15.Text);
            Row.Sept16 = Convert.ToInt32(tb16.Text);
            Row.Sept17 = Convert.ToInt32(tb17.Text);
            Row.Sept18 = Convert.ToInt32(tb18.Text);
            Row.Sept19 = Convert.ToInt32(tb19.Text);
            Row.Sept20 = Convert.ToInt32(tb20.Text);
            Row.Sept21 = Convert.ToInt32(tb21.Text);
            Row.Sept22 = Convert.ToInt32(tb22.Text);
            Row.Sept23 = Convert.ToInt32(tb23.Text);
            Row.Sept24 = Convert.ToInt32(tb24.Text);
            Row.Sept25 = Convert.ToInt32(tb25.Text);
            Row.Sept26 = Convert.ToInt32(tb26.Text);
            Row.Sept27 = Convert.ToInt32(tb27.Text);
            Row.Sept28 = Convert.ToInt32(tb28.Text);
            Row.Sept29 = Convert.ToInt32(tb29.Text);
            Row.Sept30 = Convert.ToInt32(tb30.Text);

            conn.db.SaveChanges();
            dg.ItemsSource = conn.db.SemestrOne.ToList();
            MessageBox.Show("Данные обновлены!");



        }
    }
}
