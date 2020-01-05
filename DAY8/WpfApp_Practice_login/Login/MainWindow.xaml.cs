using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login
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

        private void BtnLogin_Copy_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "insert into Records values(@Username,@Password)";
                cmd.Parameters.AddWithValue("@Username", tbxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", tbxPassword.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Great! you are now Registered User");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops...Username already Exist");
                MessageBox.Show("Exception " + ex);
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = "select * from Records where Username=@Username and Password=@Password";
                cmd.Parameters.AddWithValue("@Username", tbxUsername.Text);
                cmd.Parameters.AddWithValue("@Password", tbxPassword.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Welcome Sir");
                }
                else
                {
                    MessageBox.Show("You are not there..Please Register");
                }
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("oops! Check Username Maybe it's already there");
                MessageBox.Show("Exception " + ex);
            }
        }
    }
}
