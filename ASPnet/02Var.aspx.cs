using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _02Var : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>Hello World!!</h1>");

            string var = "";
            var = "<h3>Hello World!!</h3>";
            Response.Write(var);

            //布林值
            bool gender = true;

            //整數
            int a = 2345;       //32bit整數
            long b = 2233445566;    //64bit整數
            short c = 444;      //16bit整數
            byte d = 5;        //8bit正整數

            //浮點數
            float f = 123.123f;
            double g = 123.123;

            //匈牙利命名法
            string strStudentNo = "12345678";
            int intNumber = 123;

            Response.Write("<h3>" + f + "</h3>");

        }
    }
}