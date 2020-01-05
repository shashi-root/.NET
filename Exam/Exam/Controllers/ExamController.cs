using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exam.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Exam.Models.Exam e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Exam where UserName=@UserName and Password=@Password";
            cmd.Parameters.AddWithValue("@UserName", e.UserName);
            cmd.Parameters.AddWithValue("@Password", e.Password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["UserName"] = dr["UserName"];
                return RedirectToAction("Edit");
            }
            else
            {
                ViewBag.pwderr = "login failed";
                return View();
            }
            
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exam/Create
        public ActionResult Create()
        {

            return View();
        }
       
        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(Exam.Models.Exam e)
        {
            try
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "InsertProcedure";
                cmd.Parameters.AddWithValue("@UserName", e.UserName);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.ExecuteNonQuery();


                // TODO: Add insert logic here

                return RedirectToAction("Login");
            }
            catch(Exception ex)
            {
                ViewBag.err = ex.Message;
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit()
        {
            Exam.Models.Exam ex = new Models.Exam();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from Exam where UserName=@UserName";
            
            cmd.Parameters.AddWithValue("@UserName", Session["UserName"]);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                ex.UserName = (string)dr["UserName"];
                ex.Password = (string)dr["PassWord"];
            }
            
            return View(ex);
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(Exam.Models.Exam e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Exam;Integrated Security=True;Pooling=False";
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.CommandText = "UpdateProcedure";
                cmd.Parameters.AddWithValue("@UserName", e.UserName);
                cmd.Parameters.AddWithValue("@Password", e.Password);
                cmd.ExecuteNonQuery();
                // TODO: Add update logic here

                return RedirectToAction("Login");
            }
            catch(Exception ex)
            {
                ViewBag.err = ex.Message;
                return View();
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
