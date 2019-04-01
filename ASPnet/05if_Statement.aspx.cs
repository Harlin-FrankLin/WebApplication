using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _05_Statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int a = 44;
            if (a >= 10)
            {
                Response.Write("<h3>"+"a的值大於等於10"+"</h3>");
            }
            else
            {
                Response.Write("<h3>" + "a的值小於10" + "</h3>");
            }

            Response.Write("<hr>");

            //0-6歲免票，7-20歲半票，21歲以上全票
            int age = 16;
            if (age >= 0)
            {

                if (age >= 21)
                {
                    Response.Write("<h3>" + "全票" + "</h3>");
                }
                else if (age > 6 && age<21)
                {
                    Response.Write("<h3>" + "半票" + "</h3>");
                }
                else
                {
                    Response.Write("<h3>" + "免票" + "</h3>");
                }

            }
            else
                Response.Write("<h3>" + "年齡輸入錯誤" + "</h3>");

            Response.Write("<hr>");

            //判斷分數等第
            //90以上為優等
            //80-89以上為甲等
            //70-79以上為乙等
            //60-69以上為丙等
            //60以下為丁等

            int socre = 85;
            if (socre >= 0)
            {
                if (socre >= 90)
                {
                    Response.Write("<h3>" + "優等" + "</h3>");
                }
                else if (socre >= 80 && socre<90)
                {
                    Response.Write("<h3>" + "甲等" + "</h3>");
                }
                else if (socre >= 70 && socre < 80)
                {
                    Response.Write("<h3>" + "乙等" + "</h3>");
                }
                else if (socre >= 60 && socre < 70)
                {
                    Response.Write("<h3>" + "丙等" + "</h3>");
                }
                else
                    Response.Write("<h3>" + "丁等" + "</h3>");

            }
            else
                Response.Write("<h3>" + "成績輸入錯誤" + "</h3>");

            Response.Write("<hr>");


        }
    }
}