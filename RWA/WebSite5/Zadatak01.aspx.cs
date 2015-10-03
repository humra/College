using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01 : System.Web.UI.Page
{
    public int BrojBoja
    {
        get
        {
            if (Session["BrojBoja"] == null)
                Session["BrojBoja"] = 0;
            return (int)Session["BrojBoja"];
        }
        set { Session["BrojBoja"] = value; }
    }

    protected override void OnPreInit(EventArgs e)
    {
        GenerirajKontroleZaUnosBoja();
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void GenerirajKontroleZaUnosBoja()
    {
        if (BrojBoja != 0)
        {
            for (int i = 1; i <= BrojBoja; i++)
            {
                PrikaziPoljeZaUnosBoje(i);
            }
            PrikaziGumbZaPrikazBoja();
        }
    }

    protected void btnPrikaziPoljaZaUnosBoja_Click(object sender, EventArgs e)
    {
        BrojBoja = int.Parse(txtBoje.Text);
        GenerirajKontroleZaUnosBoja();
    }

    private void PrikaziPoljeZaUnosBoje(int index)
    {
        Label lbl = new Label();
        lbl.ID = "lblBoja" + index;
        lbl.Text = "Boja " + index + ": ";
        ph.Controls.Add(lbl);

        TextBox txtBoja = new TextBox();
        txtBoja.ID = "txtBoja" + index;
        ph.Controls.Add(txtBoja);

        ph.Controls.Add(new LiteralControl("<br/>"));
    }

    private void PrikaziGumbZaPrikazBoja()
    {
        form1.Controls.Add(new LiteralControl("<br/>"));

        Button btn = new Button();
        btn.ID = "btnPrikaziBoje";
        btn.Text = "Prikaži upisane boje";
        btn.Click += btn_Click;
        ph.Controls.Add(btn);
    }

    void btn_Click(object sender, EventArgs e)
    {
        for (int i = 1; i <= BrojBoja; i++)
        {
            TextBox txt = ph.FindControl("txtBoja" + i) as TextBox;
            blLista.Items.Add(txt.Text);
        }
    }
}