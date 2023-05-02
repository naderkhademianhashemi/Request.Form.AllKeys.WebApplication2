using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Request.Form.AllKeys.WebApplication2.pages
{
    public partial class ReqFormAllKeys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void ButtonValues_Click(object sender, EventArgs e)
        {
            
            Response.Write("<br />");
            foreach (string key in Request.Form.AllKeys)
            {
                Response.Write(Request.Form[key] + "<br />");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<br />");
            Response.Write("<br />");
            Response.Write("keys" + "<br />");
            foreach (string key in Request.Form.AllKeys)
            {
                Response.Write(key + "<br />");
            }

            Response.Write("Contain forumaName0? : " +
                Request.Form.AllKeys.Contains("forumaName0"));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Form Elements:");

            foreach (string key in HttpContext.Current.Request.Form.AllKeys)
            {
                sb.AppendFormat(
                    "{0}={1}<br />", key, HttpContext.Current.Request.Form[key]);
            }
            Response.Write(sb);
        }
    }
}