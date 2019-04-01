using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet.後端作業二._01林秋輝
{
    public partial class CSHW2_01林秋輝 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("<div>CSHW2_第一題</div>");
            Response.Write("<br />");

            int[] A = { 17, 6, 10, 5, 22 };
            Response.Write("陣列A={");
            foreach (int i in A)
            {
                Response.Write(i + ", ");
            }
            Response.Write("}，是否為質數？");
            Response.Write("<br />");
            Response.Write("<br />");

            foreach (int a in A)
            {
                int C = 1;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        C += 1;
                    }
                }

                if (C > 2)
                {
                    Response.Write("<div>" + a + "不是質數</div>");

                }
                else
                {
                    Response.Write("<div>" + a + "是質數</div>");

                }

            }

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>CSHW2_第二題</div>");
            Response.Write("<br />");

            int A1 = 594;
            int A2 = 1485;
            int g = 1;
            int s = 0;

            Response.Write(A1 + " 與 " + A2 + " 之最大公因數為 ");

            while (g > 0)
            {

                if (A1 > A2)
                {
                    g = A1 % A2;
                    s = A1 / A2;
                    A1 = A1 - s * A2;
                    if (g == 0)
                    {
                        g = A2;
                        break;
                    }

                }
                else
                {
                    g = A2 % A1;
                    s = A2 / A1;
                    A2 = A2 - s * A1;
                    if (g == 0)
                    {
                        g = A1;
                        break;
                    }

                }

            }
            Response.Write(g);

            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            Response.Write("<div>CSHW2_第三題</div>");
            Response.Write("<br />");

            int X = 23422432;
            int LofX = 0;
            int SofX = X;
            int LD, RD;

            //找出X之位數
            while (SofX > 0)
            {
                SofX /= 10;
                LofX += 1;
                //Response.Write("<div>SofX=" + SofX + "；LofX="+ LofX + "</div>");  //for check

            }
            Response.Write(X + " 是" + LofX + "位數");
            Response.Write("<br />");

            if (X < 0)
            {
                Response.Write(X + " 不是迴文");
            }
            else
            {
                for (int i = 1; i <= LofX / 2; i++)
                {

                    LD = (X / Convert.ToInt32(Math.Pow(10, ((LofX) - i)))) % 10;
                    RD = (X % Convert.ToInt32(Math.Pow(10, i))) / (Convert.ToInt32(Math.Pow(10, i - 1)));
                    Response.Write("<div>LD=" + LD + "，RD=" + RD + "，i=" + i + "<div/>");

                    if (LD != RD)
                    {
                        Response.Write(X + " 不是迴文");
                        break;
                    }
                    else if (i == LofX / 2)
                    {
                        Response.Write(X + " 是迴文");
                    }
                }


            }

            Response.Write("<hr>");
            //////////////////////////////////////////////////////////////


        }
    }
}