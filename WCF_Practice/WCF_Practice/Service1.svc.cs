using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_Practice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        
        SqlConnection con = new SqlConnection();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public DataSet GetDataSet()
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
            catch 
            {
                return ds;
            }
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

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
