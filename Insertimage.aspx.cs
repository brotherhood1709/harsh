using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data;
using System.Drawing;
using System.IO;


namespace Defination
{
    public partial class Insertimage : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Parth\\Defination\\Defination\\App_Data\\Images.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(HttpContext.Current.Request.PhysicalApplicationPath + "image/" + FileUpload1.FileName);
            }
            string sql = "insert into images values('"+FileUpload1.FileName+"')";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Response.Write("Inserted");

        }
    }
}