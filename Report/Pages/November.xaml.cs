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
    /// Логика взаимодействия для November.xaml
    /// </summary>
    public partial class November : Page
    {
        public November()
        {
            InitializeComponent();
            dg.ItemsSource = Connect.conn.db.SemestrOne.ToList();

        }


        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Row = conn.db.SemestrOne.Where(w => w.Name == tbName.Text).FirstOrDefault();
                Row.Nov1 = Convert.ToInt32(tb01.Text);
                Row.Nov2 = Convert.ToInt32(tb02.Text);
                Row.Nov3 = Convert.ToInt32(tb03.Text);
                Row.Nov4 = Convert.ToInt32(tb04.Text);
                Row.Nov5 = Convert.ToInt32(tb05.Text);
                Row.Nov6 = Convert.ToInt32(tb06.Text);
                Row.Nov7 = Convert.ToInt32(tb07.Text);
                Row.Nov8 = Convert.ToInt32(tb08.Text);
                Row.Nov9 = Convert.ToInt32(tb09.Text);
                Row.Nov10 = Convert.ToInt32(tb10.Text);
                Row.Nov11 = Convert.ToInt32(tb11.Text);
                Row.Nov12 = Convert.ToInt32(tb12.Text);
                Row.Nov13 = Convert.ToInt32(tb13.Text);
                Row.Nov14 = Convert.ToInt32(tb14.Text);
                Row.Nov15 = Convert.ToInt32(tb15.Text);
                Row.Nov16 = Convert.ToInt32(tb16.Text);
                Row.Nov17 = Convert.ToInt32(tb17.Text);
                Row.Nov18 = Convert.ToInt32(tb18.Text);
                Row.Nov19 = Convert.ToInt32(tb19.Text);
                Row.Nov20 = Convert.ToInt32(tb20.Text);
                Row.Nov21 = Convert.ToInt32(tb21.Text);
                Row.Nov22 = Convert.ToInt32(tb22.Text);
                Row.Nov23 = Convert.ToInt32(tb23.Text);
                Row.Nov24 = Convert.ToInt32(tb24.Text);
                Row.Nov25 = Convert.ToInt32(tb25.Text);
                Row.Nov26 = Convert.ToInt32(tb26.Text);
                Row.Nov27 = Convert.ToInt32(tb27.Text);
                Row.Nov28 = Convert.ToInt32(tb28.Text);
                Row.Nov29 = Convert.ToInt32(tb29.Text);
                Row.Nov30 = Convert.ToInt32(tb30.Text);

                conn.db.SaveChanges();
                dg.ItemsSource = conn.db.SemestrOne.ToList();
                MessageBox.Show("Данные обновлены!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Повторите попытку" + ex);
            }
        }
    }
}
