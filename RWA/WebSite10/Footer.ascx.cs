using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Footer : System.Web.UI.UserControl
{
    public bool shortTime
    {
        get
        {
            if (Session["shortTime"] == null)
            {
                Session["shortTime"] = false;
            }
            return (bool)Session["shortTime"];
        }

        set
        {
            Session["shortTime"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbVrijeme.Text = DateTime.Now.ToShortDateString();
        }
    }
    protected void lbVrijeme_Click(object sender, EventArgs e)
    {
        shortTime = !shortTime;

        if (shortTime)
        {
            lbVrijeme.Text = DateTime.Now.ToShortDateString();
        }
        else
        {
            lbVrijeme.Text = DateTime.Now.ToLongDateString();
        }
    }
}