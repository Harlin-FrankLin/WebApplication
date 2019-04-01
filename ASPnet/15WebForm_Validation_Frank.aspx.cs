using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet
{
    public partial class _15WebForm_Validation_Frank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ranForBirthday.MaximumValue = DateTime.Now.ToString("d");

        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            for(int i=0;i<ltbInterest.Items.Count;i++)
            {
                ltbInterest2.Items.Add(ltbInterest.Items[i].Text);
            }
            ltbInterest.Items.Clear();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest2.Items.Count; i++)
            {
                ltbInterest.Items.Add(ltbInterest2.Items[i].Text);
            }
            ltbInterest2.Items.Clear();
        }

        protected void btnYes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest.Items.Count; i++)
            {
                if (ltbInterest.Items[i].Selected)
                {
                    ltbInterest2.Items.Add(ltbInterest.Items[i].Text);
                    ltbInterest.Items.RemoveAt(i);
                }
            }
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest2.Items.Count; i++)
            {
                if (ltbInterest2.Items[i].Selected)
                {
                    ltbInterest.Items.Add(ltbInterest2.Items[i].Text);
                    ltbInterest2.Items.RemoveAt(i);
                }
            }
        }

        protected void ranForID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string ID = txtID.Text;
            //Response.Write(txtID.Text);     //for test

            int C = 0, B=0,n=0,n1=0;
            //<% --英文字規則A(10)~Z(33)，最後四碼為W(32)Z(33)I(34)O(35)-- %>
            //英文轉成的數字, 個位數乘９再加上十位數
            //<% --各數字從右到左依次乘１、２、３、４．．．．８-- %>
            //    <% --求出(1),(2)之和後，為n，除10後之餘數,用10減該餘數,結果就是檢查碼,若餘數為0(最後一碼就是0)-- %>
            Response.Write("<div>驗證用身分證字號</div>");
            Response.Write("<div>A123456789，和為130；M123456789，和為140，Q123456789，和為167，A234567820，和為150</div>");


            for (int i=0;i< ID.Length; i++)
            {
                if (i == 0) {

                    C = 1;
                    switch(ID.Substring(i, 1)){
                        case "A": B = 10; break;
                        case "B": B = 11; break;
                        case "C": B = 12; break;
                        case "D": B = 13; break;
                        case "E": B = 14; break;
                        case "F": B = 15; break;
                        case "G": B = 16; break;
                        case "H": B = 17; break;
                        case "I": B = 34; break;
                        case "J": B = 18; break;
                        case "K": B = 19; break;
                        case "L": B = 20; break;
                        case "M": B = 21; break;
                        case "N": B = 22; break;
                        case "O": B = 35; break;
                        case "P": B = 23; break;
                        case "Q": B = 24; break;
                        case "R": B = 25; break;
                        case "S": B = 26; break;
                        case "T": B = 27; break;
                        case "U": B = 28; break;
                        case "V": B = 29; break;
                        case "W": B = 32; break;
                        case "X": B = 30; break;
                        case "Y": B = 31; break;
                        case "Z": B = 33; break;

                    }

                }
                else {
                    C = 9 - i;
                    if (C == 0) C = 1;
                    B = int.Parse(ID.Substring(i, 1));
                }
                n1 = n;
                if (i == 0)
                {
                    n = n + (B%10)*9+ (B /10);
                    Response.Write("n=" + n1 + "+(" + B + " %10)*9+(" + B + "/10)=" + n + "<br />");   //for check

                }
                else
                {
                    n = n + B * C;
                    Response.Write("n=" + n1 + "+" + B + " *" + C + "=" + n + "<br />");   //for check
                }
                //Response.Write(B + " *" + C + "=" + B * C + "<br />");   //for check

            }
            //int AsciiCodeO = (int)System.Convert.ToChar("A");
            //Response.Write("A："+AsciiCodeO);     //for test


            if(n%10==0)
                args.IsValid = true;    //驗證器會通過
            else
                args.IsValid = false;    //驗證器不通過；顯示錯誤訊息


        }
    }
}