using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPnet.後端作業四._01林秋輝
{
    public partial class CSHW4_01林秋輝 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ltbInterest.Items.Count; i++)
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

    }
}