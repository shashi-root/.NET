using Db_Pract.DataSet1TableAdapters;
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

namespace Db_Pract
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        DataSet1 ds = new DataSet1();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ds = new DataSet1();
            DepartmentsTableAdapter dadeps = new DepartmentsTableAdapter();
            dadeps.Fill(ds.Departments);

            EmployeesTableAdapter daemps = new EmployeesTableAdapter();
            daemps.Fill(ds.Employees);

            mygrid.ItemsSource = ds.Employees;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            EmployeesTableAdapter daemps = new EmployeesTableAdapter();
            daemps.Update(ds.Employees);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow o = new MainWindow();
            o.Show();
        }
    }
}
