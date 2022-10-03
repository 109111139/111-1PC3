using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC3
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i_Clothes = 7;
            int i_Hat = 8;
            int i_Pants = 9;
            int total = 300 * i_Clothes + 350 * i_Hat + 400 * i_Pants;
            Response.Write(total);
        }
    }
}