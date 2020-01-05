using Login_Register_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_Register_Assignment.Controllers
{
    public class LoginController : Controller
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=Root;Integrated Security=True;Pooling=False");
        // GET: Login
        public ActionResult Index()
        {
            HttpCookie ckobj = Request.Cookies["cookie"];
            if(ckobj==null)
                 return View();
            else
            {
                TempData["FullName"] = ckobj["FullName"];
                return RedirectToAction("Home");
            }
        }
        public ActionResult Logout()
        {
            HttpCookie ckobj = Request.Cookies["cookie"];
            if (ckobj != null)
            {
                ckobj.Expires = DateTime.Now.AddDays(-10);

                Response.Cookies.Add(ckobj);
            }
            Session.Abandon();
            return View("Index");
        }
        // GET: Login/Details/5
        public ActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Details(Register reg)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from Assignment where Id=@Id and Password=@Password", con);
                cmd.Parameters.AddWithValue("@Id", reg.Id);
                cmd.Parameters.AddWithValue("@Password", reg.Password);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   

                    Session["Id"] = (string)dr["Id"];
                    Session.Timeout = 1;
                    if (reg.Remember)
                    {
                        HttpCookie ckobj = new HttpCookie("cookie");
                        ckobj.Values["Id"] = reg.Id;
                        ckobj.Values["Password"] = reg.Password;
                        ckobj.Values["FullName"] = (string)dr["FullName"];
                        ckobj.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(ckobj);
                    }
                    return RedirectToAction("Home");
                }
                return View();
                
            }
            catch (Exception)
            {

                return View();
            }
          
        }

        // GET: Login/Create
       [HttpGet]
       public ActionResult Home()
        {
            HttpCookie ckobj = Request.Cookies["cookie"];

            if (ckobj != null)
            {

                Session["Id"] = ckobj["Id"];
            }
            else
            {
                if (Session["Id"] == null)
                {
                    return RedirectToAction("Index");

                }
            }

            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(Register reg)
        {
            try
            {
                // TODO: Add insert logic here
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Assignment values(@Id,@Password,@FullName,@Email,@Mobile,@Gender,@Address)", con);
                cmd.Parameters.AddWithValue("@Id", reg.Id);               
                cmd.Parameters.AddWithValue("@Password", reg.Password);               
                cmd.Parameters.AddWithValue("@FullName", reg.FullName);               
                cmd.Parameters.AddWithValue("@Email", reg.Email);               
                cmd.Parameters.AddWithValue("@Mobile", reg.Mobile);               
                cmd.Parameters.AddWithValue("@Gender", reg.Gender);               
                cmd.Parameters.AddWithValue("@Address", reg.Address);               

                cmd.ExecuteNonQuery();
                con.Close();
                return RedirectToAction("Details");
            }
            catch (Exception ex)
            {
                ViewBag.err = ex.Message;
                return View();
            }
          
        }

        // GET: Login/Edit/5
        public ActionResult Edit()
        {
            try { 
            con.Open();
            Register rs = new Register();
            SqlCommand cmd = new SqlCommand("select * from Assignment where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Session["Id"]);
           

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rs.Id = (string)dr["Id"];
                rs.Password = (string)dr["Password"];
                rs.FullName = (string)dr["FullName"];
                rs.Email = (string)dr["Email"];
                rs.Mobile = (string)dr["Mobile"];
                rs.Gender = (string)dr["Gender"];
                rs.Address = (string)dr["Address"];

            }
                return View(rs);
            }
            catch (Exception e)
            {
                ViewBag.err = e.Message;
                return View();
                }
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(Register reg)
        {
            
                try
                {
                    // TODO: Add insert logic here
                    con.Open();

                    SqlCommand cmd = new SqlCommand("update Assignment set Password=@Password,FullName=@FullName,Email=@Email,Mobile=@Mobile,Gender=@Gender,Address=@Address where Id=@id", con);
                    cmd.Parameters.AddWithValue("@Id", Session["Id"]);
                    cmd.Parameters.AddWithValue("@Password", reg.Password);
                    cmd.Parameters.AddWithValue("@FullName", reg.FullName);
                    cmd.Parameters.AddWithValue("@Email", reg.Email);
                    cmd.Parameters.AddWithValue("@Mobile", reg.Mobile);
                    cmd.Parameters.AddWithValue("@Gender", reg.Gender);
                    cmd.Parameters.AddWithValue("@Address", reg.Address);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    return RedirectToAction("Home");
                }
                catch (Exception ex)
                {
                    ViewBag.err = ex.Message;
                    return View();
                }
        }

       
    }
}
