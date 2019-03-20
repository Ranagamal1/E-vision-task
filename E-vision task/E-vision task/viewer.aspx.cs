using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace E_vision_task
{
    public partial class viewer : System.Web.UI.Page
    { 
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            DisplayRecord();
        }
        public System.Data.DataTable DisplayRecord()
        {
            con = new SqlConnection("Data Source=ROKA\\SQLEXPRESS2;Initial Catalog=e-vision;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlDataAdapter Adp = new SqlDataAdapter("select * from Users", con);
            DataTable Dt = new DataTable();
            Adp.Fill(Dt);
            GridView1.DataSource = Dt;
            GridView1.DataBind();
            return Dt;
        }

    }
}