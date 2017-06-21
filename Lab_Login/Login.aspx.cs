using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //check Form fields....
        //if (string.IsNullOrEmpty(txtUserName.Text))
        if (txtUserName.Text.Trim() == "") {
            lblPrompt.Text = "keyin";
            return;
        }


        //DB...select * from memeber where userID = ...
        //if (!DBCheck())
        // lblPrompt.text = "Password or username is wrong."

        Session["userName"] = txtUserName.Text;

        //Response.Cookies["userName"].Value = txtUserName.Text;
        //Response.Redirect("Default.aspx");

        string c = Session["reURL"].ToString();
        if (c == null)
            Response.Redirect("Default.aspx");
        else
            Response.Redirect(c);

    }
}