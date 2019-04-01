using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _03Statement_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int a = 10;     //宣告變數時即初始化
            a = 20;         //指定運算 a=20
            a = a + 10;
            a += 10;

            a -= 15;
            a *= 10;
            a /= 25;

            a = a + 1;
            a += 1;
            a++;

            //Response.Write("a=" + a);

            int x = 123, y = 456;
            float z = 12.14567f;
            float result = 0;
            result = x + z;     //溢位，失去精準度

            //Response.Write(result);

            float xx = 10000.8f;
            double yy = 9999.3;

            //Response.Write(xx-yy);

            decimal xx2 = (decimal)xx;      //手動進行資料十進位轉換運算，解決補數運算，失去精準度之問題。
            decimal yy2 = (decimal)yy;

            Response.Write(xx2 - yy2);


        }
    }
}