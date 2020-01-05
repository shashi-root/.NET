using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeesController : Controller
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False");
        // GET: Employees
        public ActionResult Index()
        {
            con.Open();
            List<Employee> emps = new List<Employee>();
            SqlCommand selcmd = new SqlCommand("select * from Employees", con);
            SqlDataReader dr = selcmd.ExecuteReader();
            while(dr.Read()){
                emps.Add(new Employee { EmpNO = (int)dr["EmpNo"],Name=dr["Name"].ToString(),Basic=(decimal)dr["Basic"],DeptNo=(int)dr["DeptNo"] });
            }
            dr.Close();
            con.Close();
            
            return View(emps);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            // Employee emp = new Employee { EmpNO = id, Name = "shashi", Basic = 12200, DeptNo = 20 };
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo=@EmpNo", con);
            cmd.Parameters.AddWithValue("@EmpNo", id);
            Employee emp = new Employee();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                emp.EmpNO = id;
                emp.Name = dr["Name"].ToString();
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }
            con.Close();
            dr.Close();
            return View(emp);
        }

        // GET: Employees/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]                                               //Attribute of post
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                con.Open();
               
                SqlCommand cmd = new SqlCommand("insert into Employees values(@EmpNO,@Name,@Basic,@DeptNo)", con);
                cmd.Parameters.AddWithValue("@EmpNO", emp.EmpNO);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.err = ex.Message;
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            //Read from database
            // SqlConnection con = new SqlConnection("con str here");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo=@EmpNo",con);
            cmd.Parameters.AddWithValue("@EmpNo", id);
            Employee emp = new Employee();

            
            SqlDataReader dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                emp.EmpNO = id;
                emp.Name = dr["Name"].ToString();
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }
            //Employee emp = new Employee();
            //emp.EmpNO = id;
            //emp.Name = "Shashi";
            //emp.Basic = 152222;
            //emp.DeptNo = 10;
            con.Close();
            dr.Close();
            return View(emp);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                // TODO: Add update logic here
                //Run your update command
                con.Open();
                SqlCommand cmd = new SqlCommand("update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo",con);
                cmd.Parameters.AddWithValue("@EmpNO", id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Basic", emp.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", emp.DeptNo);

                cmd.ExecuteNonQuery();
                con.Close();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo=@EmpNo", con);
            cmd.Parameters.AddWithValue("@EmpNo", id);
            Employee emp = new Employee();


            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                emp.EmpNO = id;
                emp.Name = dr["Name"].ToString();
                emp.Basic = (decimal)dr["Basic"];
                emp.DeptNo = (int)dr["DeptNo"];
            }
            //Employee emp = new Employee();
            //emp.EmpNO = id;
            //emp.Name = "Shashi";
            //emp.Basic = 152222;
            //emp.DeptNo = 10;
            con.Close();
            dr.Close();
            return View(emp);
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Employees where EmpNo=@EmpNo", con);
                cmd.Parameters.AddWithValue("@EmpNo", id);
                cmd.ExecuteNonQuery();
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
