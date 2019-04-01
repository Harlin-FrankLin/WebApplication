using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
using System.Configuration;

namespace ASPnet
{
    public partial class _33Member_Registeration : System.Web.UI.Page
    {
        SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MySystemConnectionString1"].ConnectionString);
                SqlCommand Cmd = new SqlCommand("select * from Edu order by EduLevel_Code desc", Conn);

                SqlDataReader rd;
                Conn.Open();
                rd = Cmd.ExecuteReader();
                ListItem item;
                while (rd.Read())
                {
                    item = new ListItem(rd["EduLevel"].ToString(), rd["EduLevel_Code"].ToString());
                    ddlEduLevel.Items.Add(item);
                }

                Conn.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                //if (fulPhoto.PostedFile.ContentType != "application/octet-stream" && fulPhoto.PostedFile.ContentType == "image/jpeg")
                //{
                    try
                    {
                        lblPhoto.Text = "";
                        SqlCommand Cmd = new SqlCommand("insert into members values(@account,hashbytes('sha2_256',@pwd),@name,@birthday,@email,@gender,@edu,@note,@photo)", Conn);
                        Cmd.Parameters.AddWithValue("@account", txtAccount.Text);
                        Cmd.Parameters.AddWithValue("@pwd", txtPwd.Text);
                        Cmd.Parameters.AddWithValue("@name", txtName.Text);
                        Cmd.Parameters.AddWithValue("@birthday", txtBirthday.Text);
                        Cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                        Cmd.Parameters.AddWithValue("@gender", rblGender.SelectedValue);
                        Cmd.Parameters.AddWithValue("@edu", ddlEduLevel.SelectedValue);
                        Cmd.Parameters.AddWithValue("@note", txtNote.Text);
                        Cmd.Parameters.AddWithValue("@photo", fulPhoto.FileBytes);

                        Conn.Open();
                        Cmd.ExecuteNonQuery();

                        Conn.Close();

                        //Response.Redirect("17GridView_DataSource.aspx");
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
                //else
                //    lblPhoto.Text = "格式有錯!!";
            }

            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            SqlCommand Cmd = new SqlCommand("select dbo.fnCheckMemberAccount(@account)", Conn);
            Cmd.Parameters.AddWithValue("@account", txtAccount.Text);

            SqlDataReader rd;
            Conn.Open();
            rd = Cmd.ExecuteReader();

            rd.Read();
            if (rd[0].ToString() == "0")
                args.IsValid = true;
            else
                args.IsValid = false;

            Conn.Close();
        }
    }
}



//create function fnCheckMemberAccount
//    (@account varchar(10))
//	returns int
//as
//begin
//    declare @aa varchar(10)

//    select @aa = account from Members where account = @account
	
//	if @@ROWCOUNT=0
//		return 0

//	return 1
//end