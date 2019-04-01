using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet.後端作業三._01林秋輝
{
    public partial class CSHW3_01林秋輝 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("<div>CSHW3_第一題</div>");
            Response.Write("<br />");

            //弄一副牌出來
            string[] PK = new string[52];
            for (int i = 0; i < 52; i++)
            {
                PK[i] = (i + 1).ToString();
            }

            //測試圖片
            for (int i = 0; i < PK.Length; i++)
            {
                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");
            }


            //洗牌；使用Random洗牌
            //Random r = new Random();
            //Random(Class，類別) r(物件) = new Random()(建構子，函數，函式，鑄造物件的方法);

            //string[] PK1 = new string[52];
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////
            Random r = new Random();
            string X;
            int Y;
            for (int i = 0; i < PK.Length; i++)
            {
                //Response.Write(r.Next(52));     //for test
                Y = r.Next(52);
                //Response.Write("<div >i=" + i + "，Y=" + Y + "</div>");     //for test

                if (i == Y)
                {
                    while (i != Y)
                    {
                        Y = r.Next(52);
                        //Response.Write("<div >i="+i+"，Y="+Y+"</div>");     //for test

                    }
                }
                else
                {
                    X = PK[i];
                    PK[i] = PK[Y];
                    PK[Y] = X;

                }

            }

            for (int i = 0; i < PK.Length; i++)
            {
                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");
            }
            Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

            //發牌；P1,P2,P3,P4；分享52張牌

            /********************************************************

            //發牌；P1共13張牌
            for (int i = 0; i < PK.Length; i += 4)
            {
                if (i == 0)
                {
                    Response.Write("<span>P1：  </span>");

                }

                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");

            }
            Response.Write("<br/>");

            //發牌；P2共13張牌
            for (int i = 1; i < PK.Length; i += 4)
            {
                if (i == 1)
                {
                    Response.Write("<span>P2：  </span>");

                }

                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");

            }
            Response.Write("<br/>");

            //發牌；P3共13張牌
            for (int i = 2; i < PK.Length; i += 4)
            {
                if (i == 2)
                {
                    Response.Write("<span>P3：  </span>");

                }

                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");

            }
            Response.Write("<br/>");

            //發牌；P4共13張牌
            for (int i = 3; i < PK.Length; i += 4)
            {
                if (i == 3)
                {
                    Response.Write("<span>P4：  </span>");

                }

                Response.Write("<img src='poker_img/" + PK[i] + ".gif' />");

            }
            Response.Write("<br/>");


            ////////////////////////////////////////////////////////////////

            //20190204新增
            //產生四列之表格
            Table table = new Table();                  //create one object of type Table
            //table.ID = "tb";
            //table.Attributes.Add("border", "3px");  //自己加一個屬性
            table.CellPadding = 5;
            table.Style["margin-top"] = "15px";

            for (int i = 0; i < 4; i++)
            {
                TableRow tRow = new TableRow();
                table.Rows.Add(tRow);
                //tRow.Attributes.Add("border", "3px");
                tRow.Style["font-size"] = "16pt";         //設定Style
                tRow.Style["width"] = "100%";
                //tRow.VerticalAlign = VerticalAlign.Top;


                for (int j = 0; j < 13; j++)
                {
                    TableCell tCell_0 = new TableCell();
                    //tCell_0.Text = i.ToString();
                    tRow.Cells.Add(tCell_0);
                    Label VV = new Label();


                    VV.Text = "<img src='poker_img/" + PK[4 * j + i] + ".gif' />";
                    tCell_0.VerticalAlign = VerticalAlign.Top;
                    tCell_0.HorizontalAlign = HorizontalAlign.Center;
                    tCell_0.Controls.Add(VV);
                    tRow.Cells.Add(tCell_0);
                }

            }
            Page.Controls.Add(table);

            ////////////////////////////////////////////////////////////////

                 ********************************************************/


            //20190209修改
            //產生四列之表格，每列四張牌，共發13次
            Table table1 = new Table();                  //create one object of type Table
            table1.ID = "tb2";
            table1.Attributes.Add("border", "3px");  //自己加一個屬性
            table1.Style["font-size"] = "16pt";         //設定Style
            table1.Style["width"] = "100%";
            table1.CellPadding=5;
            table1.Style["margin-top"] = "15px";

            for (int i = 0; i < 14; i++)
            {
                TableRow tRow1 = new TableRow();
                table1.Rows.Add(tRow1);
                tRow1.Attributes.Add("border", "3px");
                tRow1.Style["font-size"] = "16pt";         //設定Style
                tRow1.Style["width"] = "100%";


                for (int j = 0; j < 4; j++)
                {


                    TableCell tCell_1 = new TableCell();
                    //tCell_1.Text = i.ToString();
                    tRow1.Cells.Add(tCell_1);
                    Label VV1 = new Label();

                    if (i == 0)
                    {
                        VV1.Text = "Player" + (j + 1);
                    }

                    else
                    {
                        VV1.Text = "<img src='poker_img/" + PK[4 * (i-1) + j] + ".gif' />";
                    }
                    //VV1.Text = "<img src='poker_img/" + PK[4 * i + j] + ".gif' />";
                    tCell_1.VerticalAlign = VerticalAlign.Top;
                    tCell_1.HorizontalAlign = HorizontalAlign.Center;
                    tCell_1.Controls.Add(VV1);
                    tRow1.Cells.Add(tCell_1);
                }

            }
            Page.Controls.Add(table1);

            //Response.Write("<hr>");
            ////////////////////////////////////////////////////////////////

        }
    }
}