using System;
using System.Data;
using System.Data.SqlClient;
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

namespace Database_con
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
                cmd.CommandText = "Insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
               // cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue(@"EmpNo", tbxEmpNo.Text);
                cmd.Parameters.AddWithValue(@"Name", tbxName.Text);
                cmd.Parameters.AddWithValue(@"Basic", tbxBasic.Text);
                cmd.Parameters.AddWithValue(@"DeptNo", tbxDeptNo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void BtnTransaction_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            SqlTransaction t;
            con.Open();
            t = con.BeginTransaction();
            try
            {
                
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = t;
                cmd.CommandType = CommandType.Text;
               
                cmd.CommandText = "Insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                // cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue(@"EmpNo", 13);
                cmd.Parameters.AddWithValue(@"Name", "amey11");
                cmd.Parameters.AddWithValue(@"Basic", 454554);
                cmd.Parameters.AddWithValue(@"DeptNo", 10);

               
                // cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con;
                cmd2.Transaction = t;
                cmd2.CommandType = CommandType.Text;
               
                cmd2.CommandText = "Insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";
                cmd2.Parameters.AddWithValue(@"EmpNo", 1);
                cmd2.Parameters.AddWithValue(@"Name", "amey");
                cmd2.Parameters.AddWithValue(@"Basic", 454554);
                cmd2.Parameters.AddWithValue(@"DeptNo", 10);

                
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                t.Commit();
                MessageBox.Show("Commited");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show("Rollback");
                t.Rollback();
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
                cmd.CommandText = "select count(*) from Employees";
                // cmd.ExecuteNonQuery();

                lblCount.Content= cmd.ExecuteScalar();

              

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
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsProc";
                // cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue("@EmpNo", tbxEmpNo.Text);
                cmd.Parameters.AddWithValue("@Name", tbxName.Text);
                cmd.Parameters.AddWithValue("@Basic", tbxBasic.Text);
                cmd.Parameters.AddWithValue("@DeptNo", tbxDeptNo.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted with stored proc");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
