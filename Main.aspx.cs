using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            TextBox1.Text = "Press Type Message";
            TextBox1.Focus();

            LinkButton1.Text = "Click !!";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('" + TextBox1.Text + " ... Message !!');</script>");
    }
}