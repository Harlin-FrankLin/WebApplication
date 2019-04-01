using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _09while_statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //09while_statement，while(){}，執行完成後，再檢查條件是否成立
            int i = 1;
            while (i <= 6)
            {
                Response.Write("<h" + i + ">Welcome My Homepage!!</h" + i + ">");
                i++;
            }

            ////////////////////////////////////////////////////////////////
            Response.Write("<hr>");

            int j = 1, a = 0;
            while (j <= 1000)
            {
                a += j;
                j++;
            }
            Response.Write("1加到1000的結果為：" + a);

            ////////////////////////////////////////////////////////////////
            Response.Write("<hr>");

            //用while回圈顯示出下列圖形
            //*
            //**
            //***
            //****
            //*****
            int l = 1;
            string result = "";
            while (l < 6)
            {
                result += "*";
                Response.Write("<div>"+result+"</div>");
                l++;
            }
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };
            int m = 0;
            while(m< arrRainbow.Length)
            {
                Response.Write("<span style='color:" + arrColor[m] + "'>" + arrRainbow[m] + "</span>");
                m++;
            }
            Response.Write("<hr>");

        }
    }
}