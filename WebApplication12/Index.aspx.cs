using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication12
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
            => SwitchPicture();

        protected void Button2_Click(object sender, EventArgs e)
            => SwitchPicture();

        private void SwitchPicture()
        {
            switch (Literal1.Text)
            {
                case "<img src=\"Content/logo-m-bg.png\"/>":
                    Literal1.Text = "<img src=\"Content/gerb.png\"/>";
                    break;
                case "<img src=\"Content/gerb.png\"/>":
                    Literal1.Text = "<img src=\"Content/logo-m-bg.png\"/>";
                    break;
                default:
                    Literal1.Text = "<img src=\"Content/logo-m-bg.png\"/>";
                    break;
            }
        }
    }
}