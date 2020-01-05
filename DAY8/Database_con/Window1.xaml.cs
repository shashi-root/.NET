using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


/*  //Notes
 *  
 *  >_DataReader is read only forward and locks the connection so we can't use data reaser inside reder in same connection.
 *  >_Set MultipleActiveResultSets=true to allow multiple data readers. in connections string.
 *  
 * 
 * 
 * 
 * */
namespace Database_con
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";
                // cmd.ExecuteNonQuery();

                //lblCount.Content = cmd.ExecuteScalar();

                SqlDataReader dremp = cmd.ExecuteReader();
                while (dremp.Read())
                {
                    lstEmployees.Items.Add(dremp["Name"]);
                }
                dremp.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Departments";
                
                SqlDataReader dremp = cmd.ExecuteReader();
                while (dremp.Read())
                {
                    lstEmployees.Items.Add(dremp["DeptNo"]);
                }
                lstEmployees.Items.Add("--------");
                dremp.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Departments";

                SqlDataAdapter da = new SqlDataAdapter();
               //Incmplt


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
