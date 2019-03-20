using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;
using System.Drawing;


namespace E_vision_task
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }
        private void DisplayRecord()
        {
            using (SqlConnection con = new SqlConnection("Data Source=ROKA\\SQLEXPRESS2;Initial Catalog=e-vision;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    string sql = "SELECT id,Name,Photo,Price,LastUpdated from Users";
                    if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                    {
                        sql += " WHERE Name LIKE @Name + '%'";
                        cmd.Parameters.AddWithValue("@Name", txtSearch.Text.Trim());
                    }
                    cmd.CommandText = sql;
                    cmd.Connection = con;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                    }
                }
            }
        }
        protected void Search(object sender, EventArgs e)
        {
            this.DisplayRecord();
        }

       
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            
            string filename = Path.GetFileName(FileUpload1.FileName); ;
            FileUpload1.SaveAs(Server.MapPath("~/" + filename));
            con = new SqlConnection("Data Source=ROKA\\SQLEXPRESS2;Initial Catalog=e-vision;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            
            SqlCommand cmd = new SqlCommand("insert into Users (Name,Photo,Price,LastUpdated) values(@na,@ImagePath,@pr,@la)", con);
            SqlParameter p1 = new SqlParameter("@na", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ImagePath", "images/" + filename);
            SqlParameter p3 = new SqlParameter("@pr", int.Parse(TextBox2.Text));
            SqlParameter p4 = new SqlParameter("@la", DateTime.Parse(TextBox3.Text));

            cmd.Parameters.Add(p1);
            //cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            if (Page.IsValid)
            {
                cmd.ExecuteNonQuery();
                DisplayRecord();
            }
            con.Close();
            //string name = TextBox1.Text;
            //Byte[] photo = System.Text.Encoding.UTF8.GetBytes(TextBox4.Text);
            //int price=int.Parse(TextBox2.Text);
            //DateTime lastUpdated = DateTime.Parse(TextBox3.Text);
            //if (Page.IsValid)
            //{
            //    s.insert(name, photo, price, lastUpdated);
            //   DisplayRecord();
        }
        protected void btnedit_Click(object sender, EventArgs e)
        {
            string filename = Path.GetFileName(FileUpload1.FileName); ;
            FileUpload1.SaveAs(Server.MapPath("~/" + filename));
            con = new SqlConnection("Data Source=ROKA\\SQLEXPRESS2;Initial Catalog=e-vision;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Users set Name=@N , Photo=@ImagePath , Price=@PR, LastUpdated=@L where id=@ID1", con);
            SqlParameter p1 = new SqlParameter("@N", TextBox1.Text);
            cmd.Parameters.AddWithValue("@ImagePath", "images/" + filename);
            SqlParameter p3 = new SqlParameter("@PR",  int.Parse(TextBox2.Text));
            SqlParameter p4 = new SqlParameter("@L", DateTime.Parse(TextBox3.Text));
            SqlParameter p5 = new SqlParameter("@ID1", int.Parse(TextBox4.Text));


            cmd.Parameters.Add(p1);
            //cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            if (Page.IsValid)
            {
                cmd.ExecuteNonQuery();
                DisplayRecord();
            }

            con.Close();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            SqlCommand cmd = new SqlCommand("delete from Users where ID=" + id, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh the GridView
            DisplayRecord();
        }
        protected void btnexport_Click(object sender, EventArgs e)
        {
             Response.Clear();

               Response.AddHeader("content-disposition", "attachment;filename=Products.xls");
               
               
               Response.ContentType = "application/vnd.xls";
               
               System.IO.StringWriter stringWrite = new System.IO.StringWriter();
               
               System.Web.UI.HtmlTextWriter htmlWrite = new HtmlTextWriter(stringWrite);
               
               GridView1.RenderControl(htmlWrite);
               
               Response.Write(stringWrite.ToString());
               
               Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
    }
}
