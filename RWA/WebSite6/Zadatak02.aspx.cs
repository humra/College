using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02 : System.Web.UI.Page
{
    public int BrojBoja
    {
        get
        {
            if (Session["BrojBoja"] == null)
            {
                Session["BrojBoja"] = 0;
            }
            return (int)Session["BrojBoja"];
        }
        set
        {
            Session["BrojBoja"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GenerirajPoljeZaUnosBoje(++BrojBoja);
        }
        else
        {
            ReGenerirajSvaPolja();
            PrikaziGumbZaPrikazBoja();
        }
    }

    private void PrikaziGumbZaPrikazBoja()
    {
        Button btn = new Button();
        btn.ID = "btnPrikaziBoje";
        btn.Text = "Prikazi unesene boje";
        btn.Click += btn_Click;
        form1.Controls.Add(btn);
    }

    void btn_Click(object sender, EventArgs e)
    {
        SakrijGumbZaPrikazBoja();

        DropDownList ddl = new DropDownList();
        ddl.ID = "ddlboje";

        for (int i = 1; i <= BrojBoja; i++)
        {
            ddl.Items.Add((form1.FindControl("txtBoja" + i) as TextBox).Text);
        }

        form1.Controls.Add(new LiteralControl("</br>"));
        form1.Controls.Add(new LiteralControl("Upisane boje: </br>"));
        form1.Controls.Add(ddl);
    }

    private void SakrijGumbZaPrikazBoja()
    {
        Button btn = form1.FindControl("btnPrikaziBoje") as Button;
        form1.Controls.Remove(btn);
    }

    private void ReGenerirajSvaPolja()
    {
        for (int i = 1; i <= BrojBoja; i++)
        {
            GenerirajPoljeZaUnosBoje(i);    
        }
    }

    private void GenerirajPoljeZaUnosBoje(int index)
    {
        Label lbl = new Label();
        lbl.ID = "lblBoja" + index;
        lbl.Text = "Boja " + index + ": ";
        form1.Controls.Add(lbl);

        TextBox txt = new TextBox();
        txt.ID = "txtBoja" + index;
        form1.Controls.Add(txt);
        form1.Controls.Add(new LiteralControl("   "));

        LinkButton lb = new LinkButton();
        lb.ID = "lb" + index;
        lb.Text = "Dodaj jos boja";
        lb.Click += lb_Click;
        form1.Controls.Add(lb);
        form1.Controls.Add(new LiteralControl("</br>"));
    }

    void lb_Click(object sender, EventArgs e)
    {
        SakrijGumbZaPrikazBoja();

        GenerirajPoljeZaUnosBoje(++BrojBoja);
        form1.Controls.Add(new LiteralControl("</br>"));
        PrikaziGumbZaPrikazBoja();
    }
}