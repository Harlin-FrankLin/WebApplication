using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ASPnet
{
    public partial class _31ADOnet_SqlDataReader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
            SqlCommand Cmd = new SqlCommand("select * from products", Conn);

            //節省記憶體，耗費Disk I/O
            SqlDataReader rd;
            //開啟連線
            Conn.Open();
            rd = Cmd.ExecuteReader();
            while (rd.Read())
            {
                Response.Write(rd["product_id"] + "-" + rd["product_name"] + "<br />");
            }
            //連線關閉
            Conn.Close();

        }
    }
}