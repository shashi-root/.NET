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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Db_Pract
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
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            con.Open();
           
            try
            {
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Emps");
                mygrid.ItemsSource = ds.Tables["Emps"].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
       
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
           
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            con.Open();

            try
            {
               
                SqlCommand cmdin = new SqlCommand("insert into Employees values(@EmpNo,@Name,@Basic,@DeptNO)", con);
                cmdin.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNO", SourceVersion = DataRowVersion.Current }); 
                cmdin.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current }); 
                cmdin.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current }); 
                cmdin.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                SqlCommand cmdup = new SqlCommand("update Employees set EmpNO=@EmpNo,Name=@Name,Basic=@Basic,DeptNo=@DeptNo Where EmpNo=@EmpNo", con);
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNO", SourceVersion = DataRowVersion.Original });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                
                SqlCommand cmddel = new SqlCommand("delete from Employees where EmpNo=@EmpNo", con);
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNO", SourceVersion = DataRowVersion.Original });

                sda.InsertCommand = cmdin;
                sda.UpdateCommand = cmdup;
                sda.DeleteCommand = cmddel;

                //ds.GetChanges(DataRowState.Added);
                //sda.update(ds, "Emps");
                //DataRow dr = ds.Tables["Emps"].NewRow(); //row state detached
                //ds.AcceptChanges(); //Whaterver is changed row state will be changed to unchanged.
                // accept changes _ Reject Chsnges

                //--------Creating typed data set-------
                

                sda.Update(ds, "Emps");
                MessageBox.Show("updated");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
    }
}
