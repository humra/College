﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        int upisanBroj = int.Parse(args.Value);
        if (upisanBroj % 2 == 0)
            args.IsValid = true;
        else
            args.IsValid = false;
    }
}