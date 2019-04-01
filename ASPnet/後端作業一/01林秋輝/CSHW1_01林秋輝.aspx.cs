using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet.後端作業一._01林秋輝
{
    public partial class CSHW1_01林秋輝 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("<div>C#HW1_第一題</div>");
            Response.Write("<br />");
            /********************************************************
             * 宣告變數a為整數，值為42，宣告變數b為浮點數，值2.5，  *
             *將兩值分別做加、減、乘、除及取餘數之運算，並輸出其結果*
             ********************************************************/
            int a = 42;
            float b = 2.5f;

            decimal a2 = (decimal)a;      //(資料型態)變數名稱，強制將 變數 進行資料轉換
            decimal b2 = (decimal)b;

            Response.Write("<div>" + a + "+" + b + "=" + (a2 + b2) + "</div>");
            Response.Write("<div>" + a + "-" + b + "=" + (a2 - b2) + "</div>");
            Response.Write("<div>" + a + "*" + b + "=" + (a2 * b2) + "</div>");
            Response.Write("<div>" + a + "/" + b + "=" + (a2 / b2) + "</div>");
            Response.Write("<div>" + a + "%" + b + "=" + (a2 % b2) + "</div>");

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第二題</div>");
            Response.Write("<br />");
            /*****************************************
             * 撰寫一個將攝氏溫度轉換為華氏溫度的程式*
             * 攝氏溫度的值直接在程式中給定即可      *
             *(華氏＝攝氏 * 9 / 5 + 32)              *
             *****************************************/

            double C = 30.5;
            decimal F = (decimal)C * 9 / 5 + 32;

            Response.Write("<div>" + "攝氏" + C + "度=華氏" + (F) + "度" + "</div>");

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第三題</div>");
            Response.Write("<br />");
            /***********************************
            * 設有兩個變數X與Y，其值為任何整數 *
            * 試寫交換X與Y的值的程式           *
            *(例X=3,Y=5,執行完您的程式後X=5,Y=3*
            *        不可以再新增變數          *
            ************************************/

            int X = 969, Y = 524;
            X = X ^ Y;
            Y = X ^ Y;
            X = X ^ Y;

            Response.Write("<div>" + "X=" + X + ", Y=" + Y + "</div>");

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////
            //判斷分數等第(只能用switch不可以加任何if)
            //90以上為優等
            //80-89以上為甲等
            //70-79以上為乙等
            //60-69以上為丙等
            //60以下為丁等

            Response.Write("<div>C#HW1_第四題</div>");
            Response.Write("<br />");

            int score = 85;
            switch (score)
            {
                case int n when (n >= 90):
                    Response.Write("優等");
                    break;
                case int n when (n >= 80 && n < 90):
                    Response.Write("甲等");
                    break;
                case int n when (n >= 70 && n < 80):
                    Response.Write("乙等");
                    break;
                case int n when (n >= 60 && n < 70):
                    Response.Write("丙等");
                    break;
                default:
                    Response.Write("丁等");
                    break;

            }
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第五題</div>");
            Response.Write("<br />");
            //5.寫一顯示1~100整數中，不是5的倍數的程式。
            for (int i = 1; i < 101; i++)
            {
                if (i % 5 > 0)
                {
                    Response.Write("<span>" + i + "，</span>");
                }
            }
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第六題</div>");
            Response.Write("<br />");
            //6.	計算1~1000中除了3倍數外所有數的總合。
            int j = 0;
            for (int i = 1; i < 1001; i++)
            {
                if (i % 3 > 0)
                {
                    j += i;
                }

            }
            Response.Write("<div>1加到1000中，除了3倍數外所有數的總合為：" + j + "</div>");
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第七題</div>");
            Response.Write("<br />");

            //用for回圈顯示出下列圖形
            //*
            //**
            //***
            //****
            //*****
            string k = "";
            for (int i = 1; i <= 5; i++)
            {
                k += "*";
                Response.Write("<div>" + k + "</div>");

            }
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>C#HW1_第八題</div>");
            Response.Write("<br />");

            Response.Write("<table>");

            for (int i = 2; i < 10; i++)
            {
                if (i == 6)
                {
                    Response.Write("<tr></tr>");
                }
                Response.Write("<td>");

                for (int l = 1; l < 10; l++)
                {

                    Response.Write("<div>" + i + "*" + l + "=" + i * l + "</div>");
                    //Response.Write("<div>" + i + "*" + l + "=" + i * l + "，</div>");

                }
                Response.Write("</td>");

            }

            Response.Write("</table>");

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////


        }
    }
}