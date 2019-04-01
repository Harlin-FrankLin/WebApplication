using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _04parameter_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /********************************************************
             * 宣告變數a為整數，值為42，宣告變數b為浮點數，值2.5，  *
             *將兩值分別做加、減、乘、除及取餘數之運算，並輸出其結果*
             ********************************************************/
            int a = 42;
            float b = 2.5f;

            decimal a2 = (decimal)a;      //(資料型態)變數名稱，強制將 變數 進行資料轉換
            decimal b2 = (decimal)b;

            Response.Write("<h3>" + a+"+"+b+"=" + (a2 + b2) + "</h3>");
            Response.Write("<h3>" + a+"-"+b+"=" + (a2 - b2) + "</h3>");
            Response.Write("<h3>" + a+"*"+b+"=" + (a2 * b2) + "</h3>");
            Response.Write("<h3>" + a+"/"+b+"=" + (a2 / b2) + "</h3>");
            Response.Write("<h3>" + a+"%"+b+"=" + (a2 % b2) + "</h3>");


            /*****************************************
             * 撰寫一個將攝氏溫度轉換為華氏溫度的程式*
             * 攝氏溫度的值直接在程式中給定即可      *
             *(華氏＝攝氏 * 9 / 5 + 32)              *
             *****************************************/

            double C = 30.5;
            decimal F = (decimal)C * 9 / 5 + 32;

            Response.Write("<h3>" + "攝氏"+C+"度=華氏" + (F) + "度" + "</h3>");

            /***********************************
            * 設有兩個變數X與Y，其值為任何整數 *
            * 試寫交換X與Y的值的程式           *
            *(例X=3,Y=5,執行完您的程式後X=5,Y=3*
            *        不可以再新增變數          *
            ************************************/

            int X = 969, Y = 524;
            //int X1 = Y, Y1 = X;
            //X = X1;
            //Y = Y1;

            //不會有加減乘除法，溢位之問題，XOR運算，相同值=0，不同值=1
            X = X ^ Y;
            Y = X ^ Y;
            X = X ^ Y;

            Response.Write("<h3>" + "X=" + X + ", Y=" + Y + "</h3>");

        }
    }
}