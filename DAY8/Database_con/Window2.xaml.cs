using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
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

namespace Database_con
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Departments";

                SqlDataAdapter sda = new SqlDataAdapter();
               
                
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Dept");

                cmd.CommandText = "select * from Employees";
                sda.SelectCommand = cmd;
                sda.Fill(ds,"Emps");

                mygrid1.ItemsSource = ds.Tables["Emps"].DefaultView;
               // mygrid1.ItemsSource = ds.Tables["Dept"].DefaultView;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 o = new Window1();
            o.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow o = new MainWindow();
            o.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False;MultipleActiveResultSets=true";
            con.Open();
            try
            {
                SqlCommand cmdup = new SqlCommand();
                cmdup.Connection = con;
                //Without stored procedure
                //cmdup.CommandType = CommandType.Text;
                //  cmdup.CommandText = "update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";

                //---------------------------------------------------------------------
                cmdup.CommandType = CommandType.StoredProcedure;
                cmdup.CommandText = "UpdateProc";
                //----------------------------------------------------------------------
                //Command To Insert
                SqlCommand cmdinsert = new SqlCommand("insert into Employess values(EmpNo=@EmpNo,Name=@Name,Basic=@Basic,DeptNo=@DeptNo)");
                cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
                cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdinsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });






                //SqlParameter p = new SqlParameter();
                //p.ParameterName = "@Name";
                //p.SourceColumn = "Name";
                //p.SourceVersion = DataRowVersion.Current;
                //cmdup.Parameters.Add(p);

                //add Parameters
                //below code is without stored procedure
                //cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                //cmdup.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
                //cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                //cmdup.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                //Using Stored procedure
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });


                SqlDataAdapter sda = new SqlDataAdapter();
               
                sda.UpdateCommand = cmdup;
                
                // sda.InsertCommand = cmdIns;
                // sda.DeleteCommand = smddel;

                sda.Update(ds,"Emps");
                MessageBox.Show("Updated");
                
                //  ds.Tables["Emps"].Columns["EmoNo"].

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataView dv = new DataView(ds.Tables["Emps"]);
            dv.RowFilter = "DeptNo=" + tbxDeptfil.Text;
            mygrid1.ItemsSource = dv;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ds.WriteXmlSchema("a.xsd");
            ds.WriteXml("a.xml", XmlWriteMode.DiffGram);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ds = new DataSet();
            ds.ReadXmlSchema("a.xsd");
            ds.ReadXml("a.xml", XmlReadMode.DiffGram);
            mygrid1.ItemsSource = ds.Tables["Emps"].DefaultView;
        }
    }
}
