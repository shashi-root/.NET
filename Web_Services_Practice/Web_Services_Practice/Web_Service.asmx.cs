using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_Services_Practice
{
    /// <summary>
    /// Summary description for Web_Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Web_Service : System.Web.Services.WebService
    {
        SqlDataAdapter sda = new SqlDataAdapter();
       
        SqlConnection con = new SqlConnection();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public Employee getClass()
        {
            Employee obj = new Employee();
            return obj;
        }
        [WebMethod]
        public DataSet getDataSet()
        {
            DataSet ds = new DataSet();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False";
            con.Open();

            try
            {
                ds = new DataSet();
                SqlCommand cmd = new SqlCommand("select * from Employees", con);
                sda.SelectCommand = cmd;
                sda.Fill(ds, "Emps");
                con.Close();
                return ds;
               
            }
            catch (Exception ex)
            {
                return ds;
            }
        }
        [WebMethod]
        public string UpdateData(DataSet ds)
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
                sda.InsertCommand = cmdin;

                SqlCommand cmdup = new SqlCommand("update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo Where EmpNo=@EmpNo", con);
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdup.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNO", SourceVersion = DataRowVersion.Original });

                sda.UpdateCommand = cmdup;

                SqlCommand cmddel = new SqlCommand("delete from Employees where EmpNo=@EmpNo", con);
                cmddel.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNO", SourceVersion = DataRowVersion.Original });
                sda.DeleteCommand = cmddel;

               

                sda.Update(ds, "Emps");
               
                con.Close();
                return "true";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
