using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _07for_statement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 6; i++)
            {
                Response.Write("<h" + i + ">Welcome My Homepage!!</h" + i + ">");
            }
            Response.Write("<hr>");

            //用for回圈做1加到1000,輸出其結果
            int j = 0;
            for (int i = 1; i <= 1000; i++)
            {
                
                j += i;
                //Response.Write("<h3>" + i + "</h3>");
            }
            Response.Write("<h3>1加到1000的結果為：" + j + "</h3>");
            Response.Write("<hr>");

            //用for回圈顯示出下列圖形
            //*
            //**
            //***
            //****
            //*****
            string k = "";
            for (int i=1;i<=5;i++)
            {
                k += "*";
                Response.Write("<div>" + k + "</div>");

            }
            Response.Write("<hr>");

            //用巣狀for回圈顯示出下列圖形，時間複雜度增加
            //*
            //**
            //***
            //****
            //*****
            for (int i=1;i<=5;i++)
            {
                for (int l = 1; l <= i; l++)
                {
                    Response.Write("*");
                }
                Response.Write("<br />");

            }
            Response.Write("<hr>");

            //陣列，Array
            int[] arrNumber=new int[5];
            arrNumber[0] = 6;
            arrNumber[1] = 7;
            arrNumber[2] = 8;
            arrNumber[3] = 9;
            arrNumber[4] = 10;

            //Response.Write("<div>" + arrNumber[2] + "</div>");  //輸出8

            for (int i=0;i<arrNumber.Length;i++)
            {
                Response.Write("<div>" + arrNumber[i] + "</div>");
            }

            Response.Write("<hr>");


            string[] arrRainbow = { "紅", "橙", "黃", "綠", "藍", "靛", "紫" };
            string[] arrColor = { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            for (int i = 0; i < arrRainbow.Length; i++)
            {
                Response.Write("<span style='color:"+ arrColor[i] + "'>" + arrRainbow[i] + "</span>");
            }
            Response.Write("<hr>");

        }
    }
}