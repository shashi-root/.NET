using System;
using System.Collections.Generic;
using System.Data;
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

namespace ClienSide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        localhost.Web_Service web_obj = new localhost.Web_Service();
        DataSet ds = new DataSet();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = web_obj.getDataSet();

            mygrid.ItemsSource = ds.Tables["Emps"].DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            localhost.Web_Service web_obj = new localhost.Web_Service();
            string flag=web_obj.UpdateData(ds);
            if(flag=="true")
                 MessageBox.Show("Updated");
            else
            {
                MessageBox.Show(flag);
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object obj = web_obj.getClass();
        }
    }
}
