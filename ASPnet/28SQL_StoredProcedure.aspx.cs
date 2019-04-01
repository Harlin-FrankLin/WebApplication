using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class _28SQL_StoredProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //下拉式選單變動後，重新做資料繫結
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView3.DataBind();
        }

    }
}