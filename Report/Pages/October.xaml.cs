using Report.Connect;
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
    /// Логика взаимодействия для October.xaml
    /// </summary>
    public partial class October : Page
    {
        public October()
        {
            InitializeComponent();
            dg.ItemsSource = Connect.conn.db.SemestrOne.ToList();

        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Row = conn.db.SemestrOne.Where(w => w.Name == tbName.Text).FirstOrDefault();
                Row.Oct1 = Convert.ToInt32(tb01.Text);
                Row.Oct2 = Convert.ToInt32(tb02.Text);
                Row.Oct3 = Convert.ToInt32(tb03.Text);
                Row.Oct4 = Convert.ToInt32(tb04.Text);
                Row.Oct5 = Convert.ToInt32(tb05.Text);
                Row.Oct6 = Convert.ToInt32(tb06.Text);
                Row.Oct7 = Convert.ToInt32(tb07.Text);
                Row.Oct8 = Convert.ToInt32(tb08.Text);
                Row.Oct9 = Convert.ToInt32(tb09.Text);
                Row.Oct10 = Convert.ToInt32(tb10.Text);
                Row.Oct11 = Convert.ToInt32(tb11.Text);
                Row.Oct12 = Convert.ToInt32(tb12.Text);
                Row.Oct13 = Convert.ToInt32(tb13.Text);
                Row.Oct14 = Convert.ToInt32(tb14.Text);
                Row.Oct15 = Convert.ToInt32(tb15.Text);
                Row.Oct16 = Convert.ToInt32(tb16.Text);
                Row.Oct17 = Convert.ToInt32(tb17.Text);
                Row.Oct18 = Convert.ToInt32(tb18.Text);
                Row.Oct19 = Convert.ToInt32(tb19.Text);
                Row.Oct20 = Convert.ToInt32(tb20.Text);
                Row.Oct21 = Convert.ToInt32(tb21.Text);
                Row.Oct22 = Convert.ToInt32(tb22.Text);
                Row.Oct23 = Convert.ToInt32(tb23.Text);
                Row.Oct24 = Convert.ToInt32(tb24.Text);
                Row.Oct25 = Convert.ToInt32(tb25.Text);
                Row.Oct26 = Convert.ToInt32(tb26.Text);
                Row.Oct27 = Convert.ToInt32(tb27.Text);
                Row.Oct28 = Convert.ToInt32(tb28.Text);
                Row.Oct29 = Convert.ToInt32(tb29.Text);
                Row.Oct30 = Convert.ToInt32(tb30.Text);
                Row.Oct31 = Convert.ToInt32(tb31.Text);

                conn.db.SaveChanges();
                dg.ItemsSource = conn.db.SemestrOne.ToList();
                MessageBox.Show("Данные обновлены!");
            }
            catch
            {
                MessageBox.Show("Повторите попытку");
            }
        }
    }
}
