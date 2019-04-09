using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace spajanje_na_bazu.Controllers
{
    public class SqlConnectionObjectController : Controller
    {
        // GET: SqlConnectionObject
        public ActionResult Index()
        {
            //Prvo kreiramo conn string
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            // Nakon toga instanca SQLconnection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    Response.Write("Konekcija je uspjela");
                }
            }
            catch (SqlException sqex)
            {
                Response.Write("Greška spajanja na bazu: " + sqex.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Neka greška: " + ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            return View();
        }
    }
}